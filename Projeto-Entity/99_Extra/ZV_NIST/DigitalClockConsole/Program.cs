using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Diagnostics;

namespace DigitalClockConsole
{
    class Program
    {
        static int Main (string[] args)
        {
            int errorlevel = 1;

            try {
                bool sync = false;
                bool prompt = false;
                int numTrials = 1;
                DayOfWeek dayOfWeekToWrite = DayOfWeek.Sunday;
                bool shouldWriteDayOfWeek = false;
                int hourToWrite = -1;
                int minuteToWrite = -1;
                int secondToWrite = -1;

                if (args.Length > 0) {
                    foreach (string x in args) {
                        string[] token = x.Split (':');
                        if (token.Length == 2) {
                            switch (token[0]) {
                                case "trials":
                                    if (!int.TryParse (token[1], out numTrials) || numTrials < 1) {
                                        Console.WriteLine ("Invalid number of trials specified: '{0}'", token[1]);
                                        return 1;
                                    }
                                    break;

                                case "sync":
                                    sync = true;
                                    break;

                                case "wd":
                                    // I was using the following, but it is too strict:
                                    //dayOfWeekToWrite = (DayOfWeek) Enum.Parse (typeof(DayOfWeek), token[1]);
                                    dayOfWeekToWrite = ParseDayOfWeek (token[1]);
                                    shouldWriteDayOfWeek = true;
                                    break;

                                case "wh":
                                    hourToWrite = FilterValue (token[1], 0, 59);
                                    break;

                                case "wm":
                                    minuteToWrite = FilterValue (token[1], 0, 59);
                                    break;

                                case "ws":
                                    secondToWrite = FilterValue (token[1], 0, 59);
                                    break;

                                default:
                                    Console.WriteLine ("Unknown option '{0}'", token[0]);
                                    return 1;
                            }
                        } else if (token.Length == 1) {
                            switch (token[0]) {
                                case "sync":
                                    sync = true;
                                    break;

                                case "prompt":
                                    prompt = true;
                                    break;

                                default:
                                    Console.WriteLine ("Unknown option '{0}'", token[0]);
                                    return 1;
                            }
                        } else {

                            Console.WriteLine ("Invalid command line argument '{0}'", x);
                            return 1;
                        }
                    }
                }

                const int DELAY_BETWEEN_TRIALS = 137;   // weird number to try to avoid "resonance" with clock display functions

                using (DonClock donclock = new DonClock ("COM1")) {
                    if (shouldWriteDayOfWeek) {
                        donclock.WriteDay (dayOfWeekToWrite);
                    }

                    if (hourToWrite >= 0 && hourToWrite <= 59) {
                        donclock.WriteHour (hourToWrite);
                    }

                    if (minuteToWrite >= 0 && minuteToWrite <= 59) {
                        donclock.WriteMinute (minuteToWrite);
                    }

                    if (secondToWrite >= 0 && secondToWrite <= 59) {
                        donclock.WriteSecond (secondToWrite);
                    }

                    double averageDriftInSeconds = 0.0;
                    double[] diffArray = new double[numTrials];

                    for (int i = 0; i < numTrials; ++i) {
                        if (i > 0) {
                            System.Threading.Thread.Sleep (DELAY_BETWEEN_TRIALS);
                        }

                        DateTime now = DateTime.Now;
                        DonTime dontime = donclock.ReadTime ();
                        DonTime systime = new DonTime (DateTime.Now);

                        double diffInSeconds = 0.001 * (dontime.TotalMilliseconds - systime.TotalMilliseconds);
                        diffArray[i] = diffInSeconds;
                        averageDriftInSeconds = diffInSeconds;      // will be overwritten with true average later, if numTrials > 0.

                        if (i == 0 || i == numTrials - 1) {
                            if (i > 0) {
                                Console.WriteLine ();
                                Console.WriteLine ();
                            }
                            Console.WriteLine ("dontime  = {0}   {1} ms", dontime, dontime.TotalMilliseconds);
                            Console.WriteLine ("systime  = {0}   {1} ms", systime, systime.TotalMilliseconds);
                            Console.WriteLine ("diff = {0:0.000}", diffInSeconds);
                            Console.WriteLine ();
                        } else {
                            Console.Write ("\rTrial #{0}", (1 + i));
                        }
                    }

                    if (numTrials > 1) {
                        double dev = StandardDeviation (diffArray, out averageDriftInSeconds);
                        Console.WriteLine ("Average = {0:0.00000}, Standard Deviation = {1:0.00000}", averageDriftInSeconds, dev);
                    }

                    if (sync) {
                        if (Math.Abs (averageDriftInSeconds) >= 0.001) {
                            double adjustment = -averageDriftInSeconds;
                            DonTime updatedTime = donclock.AdjustTime (adjustment);
                            Console.WriteLine ("Clock time was adjusted by {0:0.000} seconds.", adjustment);
                            Console.WriteLine ("Clock reported updated time as {0}", updatedTime);
                        } else {
                            Console.WriteLine ("No clock adjustment was needed.");
                        }
                    }

                    if (prompt) {
                        Console.WriteLine ("Entering raw prompt mode.  Enter a blank line to exit...");
                        while (true) {
                            string line = Console.ReadLine ();
                            if (string.IsNullOrEmpty (line)) {
                                break;
                            }
                            string response = donclock.SendRawCommand (line);
                            Console.WriteLine ("{0}", response);
                        }
                    }

                    errorlevel = 0;
                }
            } catch (Exception e) {
                errorlevel = 2;
                Console.WriteLine ("ERROR:  {0}", e.Message);
            }

            return errorlevel;
        }

        private static int FilterValue (string s, int min, int max)
        {
            int x = int.Parse (s);
            if (x < min || x > max) {
                throw new ApplicationException (string.Format ("The value {0} was not within the required range {1}..{2}", s, min, max));
            } else {
                return x;
            }
        }

        private static DayOfWeek ParseDayOfWeek (string s)
        {
            switch (s.ToLower()) {
                case "sun":
                case "sunday":
                    return DayOfWeek.Sunday;

                case "mon":
                case "monday":
                    return DayOfWeek.Monday;

                case "tue":
                case "tuesday":
                    return DayOfWeek.Tuesday;

                case "wed":
                case "wednesday":
                    return DayOfWeek.Wednesday;

                case "thu":
                case "thursday":
                    return DayOfWeek.Thursday;

                case "fri":
                case "friday":
                    return DayOfWeek.Friday;

                case "sat":
                case "saturday":
                    return DayOfWeek.Saturday;

                default:
                    throw new ApplicationException (string.Format ("Invalid day of week '{0}'", s));
            }
        }

        private static double StandardDeviation (double[] data, out double average)
        {
            // http://en.wikipedia.org/wiki/Standard_deviation

            double sum = 0.0;
            foreach (double x in data) {
                sum += x;
            }

            average = sum / data.Length;

            sum = 0.0;
            foreach (double x in data) {
                double diff = x - average;
                sum += diff * diff;
            }

            double dev = Math.Sqrt (sum / data.Length);
            return dev;
        }
    }
}

/*
    $Log: Program.cs,v $
    Revision 1.11  2008/09/06 18:48:17  Don.Cross
    Adding ability to adjust the digital clock time using a millisecond increment.
    It is not working yet, so it needs more debugging.
    Adding generic console mode in DigitalClockConsole.exe.
    Print diagnostic messages in NistClock.exe if it has to retry.

    Revision 1.10  2008/09/03 09:35:25  Don.Cross
    Fixed cosmetic issue: needed WriteLines before printing final trial.

    Revision 1.9  2008/08/31 11:53:38  Don.Cross
    Added command line option to DigitalClockConsole.exe for running multiple trials.
    Also calculate average and standard deviation when the number of trials is more than 1.
    Created spreadsheet drift_data.xls for computing drift rate in seconds per day.

    Revision 1.8  2008/08/30 21:43:57  Don.Cross
    Instead of trying to correct for serial delay after the fact, I realized that most of the delay is in the reply from the clock.
    The amount of time it takes for the clock to receive the "r;" command is tiny compared to the time to write the reply.
    Therefore, I should just get the local system time before querying the remote clock.

    Revision 1.7  2008/08/30 15:15:28  Don.Cross
    Added theoretical serial delay calculations, but it is not matching up very well with actual measurements.

    Revision 1.6  2008/08/30 12:49:59  Don.Cross
    Calculate the difference between system time and Don Clock time.

    Revision 1.5  2008/08/30 12:28:21  Don.Cross
    Added methods in DonClock to write time values back to the clock.
    Added DonTime constructor that takes a DateTime.
    Added DonTime.TotalTenthsOfSeconds, to facilitate chronological arithmetic.

    Revision 1.4  2008/08/27 02:10:13  Don.Cross
    Added DonTime class to abstract time as represented by the digital clock.

    Revision 1.3  2008/08/27 01:48:06  Don.Cross
    Making a DonClock class to encapsulate the clock logic.

    Revision 1.2  2008/08/27 01:33:29  Don.Cross
    Learned to use System.Diagnostics.Stopwatch to do high-precision timing.

    Revision 1.1  2008/08/27 01:12:57  Don.Cross
    C# program for talking to my digital clock.

*/
