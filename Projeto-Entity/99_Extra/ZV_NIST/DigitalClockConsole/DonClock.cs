using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace DigitalClockConsole
{
    public class DonClock : IDisposable
    {
        public DonClock (string serialPortName)
        {
            port = new SerialPort (serialPortName, BaudRate, Parity.None, 8, StopBits.One);
            port.Open ();
            ClearOutAnyGarbage ();
        }

        public const int BaudRate = 38400;

        public double TheoreticalSerialDelayInSeconds
        {
            get
            {
                // transmit:  "r;"  2 bytes
                // receive 16 (sometimes 18) bytes.
                // total = 18 bytes.
                return 18.0 / (0.1 * (double)BaudRate);
            }
        }

        public DonTime AdjustTime (double adjustmentInSeconds)
        {
            int milliseconds = (int) Math.Round (1000.0 * adjustmentInSeconds);
            port.Write (string.Format ("a{0};", milliseconds));
            return new DonTime (ReadReply ());
        }

        public DonTime ReadTime ()
        {
            port.Write ("r;");
            string reply = ReadReply ();
            DonTime time = new DonTime (reply);
            return time;
        }

        public int ReadTimeStamp ()
        {
            port.Write ("m;");
            string reply = ReadReply ();
            return int.Parse (reply);
        }

        public string SendRawCommand (string line)
        {
            if (!line.EndsWith (";")) {
                line = line + ";";
            }

            port.Write (line);
            return ReadReply ();
        }


        public DonTime WriteDay (DayOfWeek dayOfWeek)
        {
            return WriteTimeComponent ('d', (int)dayOfWeek);
        }

        public DonTime WriteHour (int hour)
        {
            return WriteTimeComponent ('h', hour);
        }

        public DonTime WriteMinute (int minute)
        {
            return WriteTimeComponent ('m', minute);
        }

        public DonTime WriteSecond (int second)
        {
            return WriteTimeComponent ('s', second);
        }

        private DonTime WriteTimeComponent (char symbol, int value)
        {
            port.Write (string.Format ("w{0}{1};", symbol, value));
            string reply = ReadReply ();
            DonTime time = new DonTime (reply);
            return time;
        }

        private void ClearOutAnyGarbage ()
        {
            // When we first connect, there could be garbage sitting in the clock's serial buffer.
            // Go ahead and send a command that will be seen as invalid, regardless of what is in the buffer (or not)...
            port.Write ("~;");
            string reply = ReadReply ();
            if (reply != "Unknown command" && !reply.StartsWith ("Digital Clock - by Don Cross - http://cosinekitty.com")) {
                throw new ApplicationException (string.Format ("Unexpected reply from clock: '{0}'", reply));
            }
        }

        private string ReadReply ()
        {
            bool firstLine = true;
            string reply = string.Empty;

            bool continuation = true;
            while (continuation) {
                string line = port.ReadLine ();
                if (line.EndsWith ("\r")) {
                    line = line.Substring (0, line.Length - 1);
                }
                continuation = line.StartsWith ("*");
                if (continuation) {
                    line = line.Substring (1).Trim ();
                }

                if (firstLine) {
                    firstLine = false;
                } else {
                    line = Environment.NewLine + line;
                }

                reply += line;
            }

            return reply;
        }

        public void Dispose ()
        {
            if (port != null) {
                port.Dispose ();
                port = null;
            }
        }

        SerialPort port;
    }
}

/*
    $Log: DonClock.cs,v $
    Revision 1.6  2008/09/06 18:59:51  Don.Cross
    Fixed bug in digital clock firmware: now calcualting millisecond time stamps correctly for 'm' command.
    Fixed bug in DigitalClockConsole: properly handle running this program before clock is fully booted up.

    Revision 1.5  2008/09/06 18:48:17  Don.Cross
    Adding ability to adjust the digital clock time using a millisecond increment.
    It is not working yet, so it needs more debugging.
    Adding generic console mode in DigitalClockConsole.exe.
    Print diagnostic messages in NistClock.exe if it has to retry.

    Revision 1.4  2008/08/30 15:15:28  Don.Cross
    Added theoretical serial delay calculations, but it is not matching up very well with actual measurements.

    Revision 1.3  2008/08/30 12:28:21  Don.Cross
    Added methods in DonClock to write time values back to the clock.
    Added DonTime constructor that takes a DateTime.
    Added DonTime.TotalTenthsOfSeconds, to facilitate chronological arithmetic.

    Revision 1.2  2008/08/27 02:10:13  Don.Cross
    Added DonTime class to abstract time as represented by the digital clock.

*/