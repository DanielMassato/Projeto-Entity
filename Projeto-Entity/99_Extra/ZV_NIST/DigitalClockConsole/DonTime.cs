using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DigitalClockConsole
{
    public class DonTime
    {
        public DonTime ()
        {
            day = DayOfWeek.Sunday;
            hour = 0;
            minute = 0;
            second = 0;
            millis = 0;
        }

        public DonTime (DateTime systime)
        {
            day = systime.DayOfWeek;
            hour = systime.Hour;
            minute = systime.Minute;
            second = systime.Second;
            millis = systime.Millisecond;
        }

        public DonTime (string clockFormatString)
        {
            // Sun 00:00:00.000 ?
            // 0123456789012345678
            //           111111111
            if (clockFormatString.Length != 16 && clockFormatString.Length != 18) {
                throw new ApplicationException ("Invalid string: must have length of 16 or 18.");
            }

            switch (clockFormatString.Substring (0, 3)) {
                case "Sun":
                    day = DayOfWeek.Sunday;
                    break;

                case "Mon":
                    day = DayOfWeek.Monday;
                    break;

                case "Tue":
                    day = DayOfWeek.Tuesday;
                    break;

                case "Wed":
                    day = DayOfWeek.Wednesday;
                    break;

                case "Thu":
                    day = DayOfWeek.Thursday;
                    break;

                case "Fri":
                    day = DayOfWeek.Friday;
                    break;

                case "Sat":
                    day = DayOfWeek.Saturday;
                    break;

                default:
                    throw new ApplicationException ("Invalid day of week");
            }

            hour   = ParseField (clockFormatString, 4,  2,   24);
            minute = ParseField (clockFormatString, 7,  2,   60);
            second = ParseField (clockFormatString, 10, 2,   60);
            millis = ParseField (clockFormatString, 13, 3, 1000);
            reboot = clockFormatString.EndsWith ("?");
        }

        private int ParseField (string clockFormatString, int startIndex, int length, int radix)
        {
            string s = clockFormatString.Substring (startIndex, length);
            while (s.Length > 1 && s[0] == '0') {
                s = s.Substring (1);
            }
            int x = int.Parse (s);
            if (x < 0 || x >= radix) {
                throw new ApplicationException ("Numeric value out of bounds.");
            }
            return x;
        }

        public override string ToString ()
        {
            return string.Format (
                "{0} {1:00}:{2:00}:{3:00}.{4:000}", 
                day.ToString().Substring(0, 3),
                hour,
                minute,
                second,
                millis
            );
        }

        /// <summary>
        /// The total number of milliseconds represented by this DonTime,
        /// a value between 0 and 604,799,999.  Helps calculate differences in time.
        /// </summary>
        public int TotalMilliseconds
        {
            get
            {
                int x = (int)day;
                x = (24 * x) + hour;
                x = (60 * x) + minute;
                x = (60 * x) + second;
                x = (1000 * x) + millis;
                return x;
            }
        }

        public DayOfWeek Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = Filter (value, 24); }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = Filter (value, 60); }
        }

        public int Second
        {
            get { return second; }
            set { second = Filter (value, 60); }
        }

        public int Millis
        {
            get { return millis; }
            set { millis = Filter (value, 1000); }
        }

        public bool Reboot
        {
            get { return reboot; }
            set { reboot = value; }
        }

        private static int Filter (int value, int radix)
        {
            if (value < 0 || value >= radix) {
                throw new ApplicationException (string.Format ("Invalid value {0}", value));
            } else {
                return value;
            }
        }

        private DayOfWeek day;
        private int hour;       // 0..23
        private int minute;     // 0..59
        private int second;     // 0..59
        private int millis;     // 0..999
        private bool reboot = false;    // set whenever the clock has been rebooted, but the time not adjusted
    }
}

/*
    $Log: DonTime.cs,v $
    Revision 1.3  2008/08/30 15:15:28  Don.Cross
    Added theoretical serial delay calculations, but it is not matching up very well with actual measurements.

    Revision 1.2  2008/08/30 12:28:21  Don.Cross
    Added methods in DonClock to write time values back to the clock.
    Added DonTime constructor that takes a DateTime.
    Added DonTime.TotalTenthsOfSeconds, to facilitate chronological arithmetic.

    Revision 1.1  2008/08/27 02:10:13  Don.Cross
    Added DonTime class to abstract time as represented by the digital clock.

*/