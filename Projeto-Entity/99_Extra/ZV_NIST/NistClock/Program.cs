/*
 *      C# program for retrieving/synchronizing atomic clock time from NIST.
 *      By Don Cross - 30 August 2008 - http://cosinekitty.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Nist;

namespace NistClockCommandLine
{
    class Program
    {
        static int Main (string[] args)
        {
            int i;

            IPAddress hostIpAddress = IPAddress.Parse ("132.163.4.101");
            NistClock nistClock = new NistClock (hostIpAddress);
            nistClock.PrintDiagnosticMessages = true;

            if (args.Length == 0) {
                PrintUsage ();
            } else {
                if (args[0] == "msync") {
                    int numberOfSamples = 10;
                    if (args.Length >= 2) {
                        numberOfSamples = int.Parse (args[1]);
                    }
                    if (numberOfSamples < 3) {
                        Console.WriteLine ("Illegal number of samples = {0}", numberOfSamples);
                        return 1;
                    }

                    double[] measurement = new double[numberOfSamples];

                    int minIndex = 0;
                    int maxIndex = 0;

                    for (i = 0; i < numberOfSamples; ++i) {
                        if (i > 0) {
                            System.Threading.Thread.Sleep (2000);   // avoid spamming NIST and pissing them off!
                        }
                        TimeSpan diff = nistClock.MeasureSystemClockError ();
                        measurement[i] = diff.TotalSeconds;
                        if (measurement[i] < measurement[minIndex]) {
                            minIndex = i;
                        }
                        if (measurement[i] > measurement[maxIndex]) {
                            maxIndex = i;
                        }
                        Console.WriteLine ("Trial #{0}:  {1,8:0.0000}", i, measurement[i]);
                    }

                    double sum = 0.0;   // sum of differences, expressed in seconds
                    double maxRemaining = -666.0e+6;
                    double minRemaining = -666.0e+6;
                    bool firstRemainingMeasurement = true;
                    int numSamplesKept = 0;
                    for (i = 0; i < numberOfSamples; ++i) {
                        if (i == minIndex || i == maxIndex) {
                            // Ignore this data point
                            if (firstRemainingMeasurement) {
                                firstRemainingMeasurement = false;
                                minRemaining = maxRemaining = measurement[i];
                            } else {
                                if (measurement[i] < minRemaining) {
                                    minRemaining = measurement[i];
                                }
                                if (measurement[i] > maxRemaining) {
                                    maxRemaining = measurement[i];
                                }
                            }
                        } else {
                            sum += measurement[i];
                            ++numSamplesKept;      // note that minIndex could be the same as maxIndex, so we cannot assume numSamplesKept == numberOfSamples - 2.
                        }
                    }
                    double average = sum / numSamplesKept;
                    double spread = maxRemaining - minRemaining;

                    Console.WriteLine ("Excluding minimum = {0,8:0.0000} and maximum = {1,8:0.0000}", measurement[minIndex], measurement[maxIndex]);
                    Console.WriteLine ("Spread of remaining data = {0,8:0.0000} seconds.", spread);
                    DateTime adjusted = DateTime.Now.AddSeconds (average);
                    NistClock.SetTimeUtc (adjusted.ToUniversalTime());
                    Console.WriteLine ("Average difference = {0,8:0.0000}", average);
                    Console.WriteLine ("Set time to: {0}", adjusted);
                } else {
                    TimeSpan diff = nistClock.MeasureSystemClockError ();
                    DateTime here = DateTime.Now.ToUniversalTime ();
                    DateTime nist = here + diff;

                    switch (args[0]) {
                        case "read":
                            Console.WriteLine ("NIST = {0}", MyFormat (nist));
                            Console.WriteLine ("Here = {0}", MyFormat (here));
                            Console.WriteLine ("diff = {0,8:0.0000} seconds", diff.TotalSeconds);
                            break;

                        case "sync":
                            NistClock.SetTimeUtc (nist);
                            Console.WriteLine ("Set system clock to: {0}", MyFormat (nist));
                            Console.WriteLine ("This required adding {0,8:0.0000} seconds to the system clock.", diff.TotalSeconds);
                            break;

                        default:
                            Console.WriteLine ("ERROR:  Unknown command '{0}'", args[0]);
                            Console.WriteLine ("Run NistClock.exe with no command line parameters for help.");
                            return 1;
                    }
                }
            }

            return 0;
        }

        private static void PrintUsage ()
        {
            Console.WriteLine ("{0}",
@"
NistTime.exe  -  Freeware by Don Cross  -  http://cosinekitty.com

This program allows one of the following command line options:

    read    Retrieves the current UTC value from NIST time server.
            Displays the NIST time and the system time, along with
            the difference between the two values.

    sync    Synchronizes the system clock with the NIST time server.
            This is typically accurate to plus or minus 10 milliseconds,
            but accuracy may vary depending on unpredictable Internet delays.

    msync   Same as sync, only averages 10 measurements, discarding the min and max.

"
                );
        }

        private static string MyFormat (DateTime dt)
        {
            return string.Format ("{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}.{6:000} UTC",
                dt.Year,
                dt.Month,
                dt.Day,
                dt.Hour,
                dt.Minute,
                dt.Second,
                dt.Millisecond
            );
        }
    }
}

/*
    $Log: Program.cs,v $
    Revision 1.18  2009/02/14 21:14:42  Don.Cross
    Oops!  GuiNistClock.exe was getting local time mixed up with universal time, and setting the local clock wrong!

    Revision 1.17  2009/02/14 20:13:14  Don.Cross
    Corrected a few flaws in my previous checkin.

    Revision 1.16  2009/02/14 19:36:43  Don.Cross
     Marcel Meuwissen sent me an email informing me of 2 problems that needed to be fixed:
    1. I thought I was correcting for round-trip time, but I was actually adjusting for fractional seconds at the NIST server.
    2. Calling double.Parse does not work in European culture settings because they use "," instead of "." as decimal point.

    Revision 1.15  2009/02/13 02:12:09  Don.Cross
    Reworking NistClock class so that it is reusable.
    Starting a GuiNistClock project.

    Revision 1.14  2008/10/30 18:06:58  Don.Cross
    Display format tweaking.

    Revision 1.13  2008/10/30 17:57:11  Don.Cross
    Reworked the msync algorithm so I can see the spread of min/max of data remaining after original min/max have been excluded.

    Revision 1.12  2008/10/30 16:28:07  Don.Cross
    Oops!  Forgot to actually change the computer clock in 'msync'.

    Revision 1.11  2008/10/30 00:58:27  Don.Cross
    Added msync option to NistClock.exe, which measures the time 10 times, then discards the min and max differences.
    The average of the remaining 8 measurements is used to adjust the time.

    Revision 1.10  2008/09/06 18:48:17  Don.Cross
    Adding ability to adjust the digital clock time using a millisecond increment.
    It is not working yet, so it needs more debugging.
    Adding generic console mode in DigitalClockConsole.exe.
    Print diagnostic messages in NistClock.exe if it has to retry.

    Revision 1.9  2008/09/03 09:41:50  Don.Cross
    When updating the system clock, display the amount of time the clock was corrected by.

    Revision 1.8  2008/08/30 22:00:24  Don.Cross
    Made the program more user-friendly.

    Revision 1.7  2008/08/30 21:45:24  Don.Cross
    Added option to set the local system time to the value indicated by the NIST time server.

    Revision 1.6  2008/08/30 21:00:48  Don.Cross
    It looks like the NIST Daytime format includes a round-trip correction, even though none of the documentation says so.
    Everywhere I look on the Web, the msADV field is described as a fixed constant, but currently it seems to be returning
    a correction for the fractional part of a second that can be subtracted to get true time.
    Making this assumption, I seem to be getting time measurements accurate to plus or minus 10 milliseconds!
    Implemented my own DateTime display format that is sortable, terse, and includes milliseconds.

    Revision 1.5  2008/08/30 19:54:13  Don.Cross
    Bug fix: duplicate spaces caused empty entries.
    Also display local time.

    Revision 1.4  2008/08/30 19:36:44  Don.Cross
    Implemented parser method to convert NIST string to DateTime.

    Revision 1.3  2008/08/30 19:21:34  Don.Cross
    Created NistClock class to abstract and encapsulate querying daytime protocol string from NIST time server.

    Revision 1.2  2008/08/30 18:57:55  Don.Cross
    Added cvs log tag.

*/