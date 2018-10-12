using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Reflection;
using Nist;

namespace GuiNistClock
{
    public partial class ClockForm : Form
    {
        private int originalHeight;
        private int extraHeight = 120;
        private string syncErrorText = null;        // set to update/clear an NIST sync error condition
        private bool immediateSyncRequsted = false;
        private DateTime prevSyncTime = DateTime.MinValue;
        private double prevAdjustment = 0;
        private Uri myWebSite = new Uri ("http://cosinekitty.com/");

        public ClockForm ()
        {
            InitializeComponent ();
            StartClockThread ();
            originalHeight = Size.Height;
            ToggleHeight ();
            ClockToolTip.SetToolTip (SyncButton, "Click this button to immediately synchronize your system clock with the NIST atomic clock.");
            ClockToolTip.SetToolTip (SyncStatusLabel, "Displays time of most recent sync, and how much your clock was adjusted.");
            ClockToolTip.SetToolTip (MyWebSiteLink, myWebSite.AbsoluteUri);
        }

        private void StartClockThread ()
        {
            clockThread = new Thread (ClockThreadFunction);
            clockThread.Start ();
        }

        void ClockThreadFunction ()
        {
            try {
                // The first synchronize may introduce a noticeable delay,
                // so display time quickly, then sync, then display again.
                DateTime now = DateTime.Now;
                DisplayTime (FormatTime (now), FormatDate (now));

                Synchronize ();

                now = DateTime.Now;
                string prevTimeFormat = FormatTime (now);
                DisplayTime (prevTimeFormat, FormatDate (now));

                while (true) {
                    Thread.Sleep (100);
                    now = DateTime.Now;
                    if (immediateSyncRequsted || (now - prevSyncTime).TotalHours > 1.0) {
                        Synchronize ();
                        now = DateTime.Now;
                    }
                    string currentTimeFormat = FormatTime (now);
                    if (currentTimeFormat != prevTimeFormat) {
                        DisplayTime (currentTimeFormat, FormatDate(now));
                        prevTimeFormat = currentTimeFormat;
                    }
                }
            } catch (ThreadAbortException) {
                // ignore this and exit gracefully: the parent thread is telling us to exit.
            } catch (Exception e) {
                MessageBox.Show (e.ToString ());
            }
        }

        private void Synchronize ()
        {
            try {
                NistClock nistClock = new NistClock ();
                TimeSpan error = nistClock.SynchronizeLocalClock ();
                prevAdjustment = error.TotalSeconds;
                syncErrorText = string.Empty;   // clear any prior error text
                prevSyncTime = DateTime.Now;
            } catch (Exception) {
                syncErrorText = "There was an error trying to synchronize with the NIST timeserver.\nAre you connected to the Internet?";
            }

            immediateSyncRequsted = false;
            SetControlPropertyValue (SyncButton, "Enabled", true);
        }

        private void TimeLabel_Click (object sender, EventArgs e)
        {

        }

        private void Form1_Load (object sender, EventArgs e)
        {
        }

        private Thread clockThread = null;

        private void ClockForm_FormClosing (object sender, FormClosingEventArgs e)
        {
            if (clockThread != null && clockThread.IsAlive) {
                clockThread.Abort ();
                clockThread = null;
            }
        }

        private void DisplayTime (string timeFormat, string dateFormat)
        {
            SetControlPropertyValue (TimeLabel, "Text", timeFormat);
            SetControlPropertyValue (DateLabel, "Text", dateFormat);
        }

        delegate void SetControlValueCallback (Control oControl, string propName, object propValue);
        private void SetControlPropertyValue (Control oControl, string propName, object propValue)
        {
            // http://www.shabdar.org/cross-thread-operation-not-valid.html
            if (oControl.InvokeRequired) {
                SetControlValueCallback d = new SetControlValueCallback (SetControlPropertyValue);
                oControl.Invoke (d, oControl, propName, propValue);
            } else {
                Type t = oControl.GetType ();
                PropertyInfo[] props = t.GetProperties ();
                foreach (PropertyInfo p in props) {
                    if (p.Name == propName) {
                        p.SetValue (oControl, propValue, null);
                        return;
                    }
                }

                throw new ApplicationException (string.Format ("Could not find property {0} in object {1}", propName, oControl));
            }
        }

        private string FormatTime (DateTime now)
        {
#if false
            int hour = now.Hour;
            string ampm = (hour >= 12) ? "PM" : "AM";
            if (hour >= 13) {
                hour -= 12;
            }
            return string.Format ("{0:#0}:{1:00}:{2:00} {3}", hour, now.Minute, now.Second, ampm);
#else
            if (CheckBox_LocalDateTime.Checked) {
                return now.ToLongTimeString ();
            } else {
                DateTime utc = now.ToUniversalTime ();
                return string.Format ("{0:00}:{1:00}:{2:00} UTC", utc.Hour, utc.Minute, utc.Second);
            }
#endif
        }

        private string FormatDate (DateTime now)
        {
            if (CheckBox_LocalDateTime.Checked) {
                return now.ToLongDateString ();
            } else {
                DateTime utc = now.ToUniversalTime ();
                return string.Format ("{0:0000}/{1:00}/{2:00} {3}", utc.Year, utc.Month, utc.Day, utc.DayOfWeek);
            }
        }

        private void label1_Click_1 (object sender, EventArgs e)
        {
        }

        private void ToggleHeight ()
        {
            if (Size.Height == originalHeight) {
                Size = new Size (Size.Width, Size.Height - extraHeight);
                ClockToolTip.SetToolTip (TogglerLink, "Click here to show options and more information.");
            } else {
                Size = new Size (Size.Width, Size.Height + extraHeight);
                ClockToolTip.SetToolTip (TogglerLink, "Click here to show smaller clock display.");
            }
        }

        private void linkLabel1_LinkClicked (object sender, LinkLabelLinkClickedEventArgs e)
        {
            ToggleHeight ();
        }

        private void CheckBoxLocalDateTime_CheckedChanged (object sender, EventArgs e)
        {

        }

        private void UpdateTimer_Tick (object sender, EventArgs e)
        {
            if (syncErrorText != null) {
                SyncError.SetError (TimeLabel, syncErrorText);
                if (syncErrorText.Length > 0) {
                    SyncStatusLabel.Text = "Could not synchronize.";
                    SyncStatusLabel.ForeColor = Color.Red;
                    syncErrorText = null;
                    prevSyncTime = DateTime.MinValue;
                }
            }

            if (prevSyncTime != DateTime.MinValue) {
                SyncStatusLabel.Text = string.Format ("Sync at {0} ({1:0.000} sec)", FormatTime (prevSyncTime), prevAdjustment);
                SyncStatusLabel.ForeColor = Color.LightGreen;
            }
        }

        private void SyncButton_Click (object sender, EventArgs e)
        {
            SyncButton.Enabled = false;
            immediateSyncRequsted = true;
        }

        private void SyncStatusLabel_Click (object sender, EventArgs e)
        {

        }

        private void ViewToggleToolTip_Popup (object sender, PopupEventArgs e)
        {

        }

        private void VisitWebSite_LinkClicked_1 (object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start (myWebSite.AbsoluteUri);
        }
    }
}


/*
    $Log: Form1.cs,v $
    Revision 1.16  2009/02/15 18:30:21  Don.Cross
    Added a link to my web site.

    Revision 1.15  2009/02/15 18:13:41  Don.Cross
    Changed check-box to toggle between localized time and date formats and my custom format for UTC.

    Revision 1.14  2009/02/15 17:50:39  Don.Cross
    In 12-hour display, now show the more natural-looking " 1:23:45 PM" instead of "01:23:45 PM".
    When first loading the clock program, before the first sync, immediately show the date and time
    so that the placeholder text doesn't linger while the first sync is running (sometimes it can be slow).

    Revision 1.13  2009/02/15 17:32:02  Don.Cross
    I learned that a single ToolTip object can serve every control on a form, so I renamed my tool tip to have a generic name of ClockToolTip.
    I added tips for the Sync Now button and most recent sync status.

    Revision 1.12  2009/02/15 17:23:09  Don.Cross
    I learned how to use tool tips.  I added a tool tip for the "..." control that toggles the display size.

    Revision 1.11  2009/02/15 00:45:57  Don.Cross
    Display last sync time and correction, or error text.

    Revision 1.10  2009/02/15 00:02:30  Don.Cross
    Added a "Sync Now" button.

    Revision 1.9  2009/02/14 23:30:51  Don.Cross
    Display an error condition if anything bad happens trying to synchronize.
    Clear the error message after successfully synchronizing.

    Revision 1.8  2009/02/14 23:13:12  Don.Cross
    Fixed bugs in FormatTime.

    Revision 1.7  2009/02/14 23:09:36  Don.Cross
    Added toggle between 24-hour and 12-hour time.  Default to 12-hour time.

    Revision 1.6  2009/02/14 22:41:22  Don.Cross
    I figured out how to add a control to toggle the height of my form between a large and small value.
    I will use this to add extra optional information to the display.

    Revision 1.5  2009/02/14 19:36:43  Don.Cross
     Marcel Meuwissen sent me an email informing me of 2 problems that needed to be fixed:
    1. I thought I was correcting for round-trip time, but I was actually adjusting for fractional seconds at the NIST server.
    2. Calling double.Parse does not work in European culture settings because they use "," instead of "." as decimal point.

    Revision 1.4  2009/02/14 01:38:16  Don.Cross
    For now, I am going to trap and ignore any exceptions that may happen trying to synchronize with NIST's clock.
    I also had random problems with the program hanging when I tried to close it, so I am trying out
    Thread.Abort instead of setting flags and stuff.

    Revision 1.3  2009/02/13 03:35:17  Don.Cross
    Added date to clock display.
    Changed colors.

    Revision 1.2  2009/02/13 03:20:52  Don.Cross
    I now have a working NIST clock GUI!

*/