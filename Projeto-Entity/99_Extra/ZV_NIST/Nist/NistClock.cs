/*
 *      C# class for retrieving accurate date and time from NIST atomic clock timeservers.
 *      By Don Cross - 30 August 2008 - http://cosinekitty.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Nist
{
    public class NistClock
    {
        public NistClock ()
            : this (IPAddress.Parse ("132.163.4.101"))
        {
        }

        public NistClock (IPAddress _timeServerIpAddress)
        {
            timeServerIpAddress = _timeServerIpAddress;
        }

        public bool PrintDiagnosticMessages
        {
            get { return printDiagnosticMessages; }
            set { printDiagnosticMessages = value; }
        }

        private string QueryDaytimeString (out TimeSpan roundTripTime)
        {
            // Use RFC-867 protocol to query time from NIST time server...

            int count = 0;
            Stopwatch stopWatch = new Stopwatch ();

            while (true) {
                ++count;

                using (Socket socket = new Socket (AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)) {
                    IPEndPoint hostEndPoint = new IPEndPoint (timeServerIpAddress, 13);

                    stopWatch.Reset ();
                    stopWatch.Start ();
                    socket.Connect (hostEndPoint);
                    int numberOfBytes = socket.Receive (buffer);
                    stopWatch.Stop ();

                    if (numberOfBytes == 51) {
                        roundTripTime = stopWatch.Elapsed;
                        string daytimeString = System.Text.ASCIIEncoding.ASCII.GetString (buffer, 0, numberOfBytes).Trim ();
                        return daytimeString;
                    } else {
                        if (printDiagnosticMessages) {
                            Console.WriteLine ("Attempt #{0}:  byte count received = {1}", count, numberOfBytes);
                        }
                    }
                }
                System.Threading.Thread.Sleep (100);
            }
        }

        private static char[] SeparatorArray = new char[] { ' ' };

        // In USA, we use "." as decimal point (e.g. pi = 3.141592)
        // but in Europe, they use commas (pi = 3,141592).
        // The following is needed for parsing double with "." delimiter for users with non-US defaults:
        private static System.Globalization.CultureInfo EnglishUSACulture = new System.Globalization.CultureInfo ("en-US");

        private static DateTime ParseDaytimeProtocol (string daytimeString)
        {
            // 54708 08-08-30 18:53:02 50 0 0 770.8 UTC(NIST) *
            //   0       1        2     3 4 5   6      7      8
            // http://tf.nist.gov/service/its.htm
            // See "Daytime Protocol (RFC-867)"

            string[] resultTokens = daytimeString.Split (SeparatorArray, StringSplitOptions.RemoveEmptyEntries);
            if (resultTokens[7] != "UTC(NIST)" || resultTokens[8] != "*") {
                throw new ApplicationException (string.Format ("Invalid RFC-867 daytime protocol string: '{0}'", daytimeString));
            }

            int mjd = int.Parse (resultTokens[0]);  // "JJJJ is the Modified Julian Date (MJD). The MJD has a starting point of midnight on November 17, 1858."
            DateTime now = new DateTime (1858, 11, 17);
            now = now.AddDays (mjd);

            string[] timeTokens = resultTokens[2].Split (':');
            int hours = int.Parse (timeTokens[0]);
            int minutes = int.Parse (timeTokens[1]);
            int seconds = int.Parse (timeTokens[2]);
            double millis = double.Parse (resultTokens[6], EnglishUSACulture);     // this is speculative: official documentation seems out of date!

            now = now.AddHours (hours);
            now = now.AddMinutes (minutes);
            now = now.AddSeconds (seconds);
            now = now.AddMilliseconds (-millis);

            return now;
        }

        public DateTime GetCorrectedSystemLocalTime ()
        {
            TimeSpan diff = MeasureSystemClockError ();
            DateTime corrected = DateTime.Now + diff;
            return corrected;
        }

        public TimeSpan MeasureSystemClockError ()
        {
            TimeSpan roundTrip;
            string daytimeString = QueryDaytimeString (out roundTrip);
            double halfTripMilliseconds = roundTrip.TotalMilliseconds / 2.0;
            TimeSpan halfTrip = new TimeSpan (0, 0, 0, 0, (int)halfTripMilliseconds);

            DateTime nist = NistClock.ParseDaytimeProtocol (daytimeString) + halfTrip;
            DateTime here = DateTime.Now.ToUniversalTime ();
            TimeSpan diff = (nist - here);

            return diff;
        }

        public TimeSpan SynchronizeLocalClock ()
        {
            TimeSpan diff = MeasureSystemClockError ();
            DateTime corrected = DateTime.Now + diff;
            NistClock.SetTimeLocal (corrected);
            return diff;
        }

        // Code snippet for setting system time found at:
        // http://www.codeguru.com/forum/archive/index.php/t-246724.html

        [StructLayout (LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wYear;
            public short wMonth;
            public short wDayOfWeek;
            public short wDay;
            public short wHour;
            public short wMinute;
            public short wSecond;
            public short wMilliseconds;
        }

        [DllImport ("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime ([In] ref SYSTEMTIME st);   // http://msdn.microsoft.com/en-us/library/ms724942(VS.85).aspx

        public static void SetTimeLocal (DateTime local)
        {
            SetTimeUtc (local.ToUniversalTime ());
        }

        public static void SetTimeUtc (DateTime utc)
        {
            SYSTEMTIME st = new SYSTEMTIME ();  // http://msdn.microsoft.com/en-us/library/ms724950(VS.85).aspx
            st.wYear = (short)utc.Year;
            st.wMonth = (short)utc.Month;
            st.wDayOfWeek = 0;     // Microsoft documentation (see URL above) says: "The wDayOfWeek member of the SYSTEMTIME structure is ignored."
            st.wDay = (short)utc.Day;
            st.wHour = (short)utc.Hour;
            st.wMinute = (short)utc.Minute;
            st.wSecond = (short)utc.Second;
            st.wMilliseconds = (short)utc.Millisecond;

            if (!SetSystemTime (ref st)) {
                throw new ApplicationException ("Error setting time.");
            }
        }

        private IPAddress timeServerIpAddress;
        private byte[] buffer = new byte[256];
        private bool printDiagnosticMessages = false;
    }
}


/*
    $Log: NistClock.cs,v $
    Revision 1.7  2009/02/15 00:45:57  Don.Cross
    Display last sync time and correction, or error text.

    Revision 1.6  2009/02/14 21:14:43  Don.Cross
    Oops!  GuiNistClock.exe was getting local time mixed up with universal time, and setting the local clock wrong!

    Revision 1.5  2009/02/14 20:14:56  Don.Cross
    Reinstating the half-trip correction.

    Revision 1.4  2009/02/14 20:13:14  Don.Cross
    Corrected a few flaws in my previous checkin.

    Revision 1.3  2009/02/14 19:36:43  Don.Cross
     Marcel Meuwissen sent me an email informing me of 2 problems that needed to be fixed:
    1. I thought I was correcting for round-trip time, but I was actually adjusting for fractional seconds at the NIST server.
    2. Calling double.Parse does not work in European culture settings because they use "," instead of "." as decimal point.

    Revision 1.2  2009/02/13 03:20:52  Don.Cross
    I now have a working NIST clock GUI!

    Revision 1.1  2009/02/13 02:12:10  Don.Cross
    Reworking NistClock class so that it is reusable.
    Starting a GuiNistClock project.

    Revision 1.8  2008/10/30 00:58:26  Don.Cross
    Added msync option to NistClock.exe, which measures the time 10 times, then discards the min and max differences.
    The average of the remaining 8 measurements is used to adjust the time.

    Revision 1.7  2008/09/06 18:48:17  Don.Cross
    Adding ability to adjust the digital clock time using a millisecond increment.
    It is not working yet, so it needs more debugging.
    Adding generic console mode in DigitalClockConsole.exe.
    Print diagnostic messages in NistClock.exe if it has to retry.

    Revision 1.6  2008/08/30 22:00:24  Don.Cross
    Made the program more user-friendly.

    Revision 1.5  2008/08/30 21:45:24  Don.Cross
    Added option to set the local system time to the value indicated by the NIST time server.

    Revision 1.4  2008/08/30 21:00:48  Don.Cross
    It looks like the NIST Daytime format includes a round-trip correction, even though none of the documentation says so.
    Everywhere I look on the Web, the msADV field is described as a fixed constant, but currently it seems to be returning
    a correction for the fractional part of a second that can be subtracted to get true time.
    Making this assumption, I seem to be getting time measurements accurate to plus or minus 10 milliseconds!
    Implemented my own DateTime display format that is sortable, terse, and includes milliseconds.

    Revision 1.3  2008/08/30 19:54:13  Don.Cross
    Bug fix: duplicate spaces caused empty entries.
    Also display local time.

    Revision 1.2  2008/08/30 19:36:44  Don.Cross
    Implemented parser method to convert NIST string to DateTime.

    Revision 1.1  2008/08/30 19:21:34  Don.Cross
    Created NistClock class to abstract and encapsulate querying daytime protocol string from NIST time server.

*/