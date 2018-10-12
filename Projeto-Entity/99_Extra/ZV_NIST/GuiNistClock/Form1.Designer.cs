namespace GuiNistClock
{
    partial class ClockForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            this.components = new System.ComponentModel.Container ();
            this.TimeLabel = new System.Windows.Forms.Label ();
            this.DateLabel = new System.Windows.Forms.Label ();
            this.TogglerLink = new System.Windows.Forms.LinkLabel ();
            this.CheckBox_LocalDateTime = new System.Windows.Forms.CheckBox ();
            this.SyncError = new System.Windows.Forms.ErrorProvider (this.components);
            this.UpdateTimer = new System.Windows.Forms.Timer (this.components);
            this.SyncButton = new System.Windows.Forms.Button ();
            this.SyncStatusLabel = new System.Windows.Forms.Label ();
            this.ClockToolTip = new System.Windows.Forms.ToolTip (this.components);
            this.MyWebSiteLink = new System.Windows.Forms.LinkLabel ();
            ((System.ComponentModel.ISupportInitialize)(this.SyncError)).BeginInit ();
            this.SuspendLayout ();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.DarkBlue;
            this.TimeLabel.Font = new System.Drawing.Font ("Lucida Console", 32F);
            this.TimeLabel.ForeColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Location = new System.Drawing.Point (13, 21);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding (19, 0, 19, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size (364, 48);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "--:--:-- AM";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLabel.Click += new System.EventHandler (this.TimeLabel_Click);
            // 
            // DateLabel
            // 
            this.DateLabel.Font = new System.Drawing.Font ("Lucida Console", 10F);
            this.DateLabel.ForeColor = System.Drawing.Color.Wheat;
            this.DateLabel.Location = new System.Drawing.Point (44, 89);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size (294, 25);
            this.DateLabel.TabIndex = 1;
            this.DateLabel.Text = "----/--/-- --------";
            this.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DateLabel.Click += new System.EventHandler (this.label1_Click_1);
            // 
            // TogglerLink
            // 
            this.TogglerLink.AutoSize = true;
            this.TogglerLink.Font = new System.Drawing.Font ("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TogglerLink.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.TogglerLink.LinkColor = System.Drawing.Color.FromArgb (((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TogglerLink.Location = new System.Drawing.Point (357, 98);
            this.TogglerLink.Name = "TogglerLink";
            this.TogglerLink.Size = new System.Drawing.Size (20, 16);
            this.TogglerLink.TabIndex = 2;
            this.TogglerLink.TabStop = true;
            this.TogglerLink.Text = "...";
            this.TogglerLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.linkLabel1_LinkClicked);
            // 
            // CheckBox_LocalDateTime
            // 
            this.CheckBox_LocalDateTime.AutoSize = true;
            this.CheckBox_LocalDateTime.Checked = true;
            this.CheckBox_LocalDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBox_LocalDateTime.Font = new System.Drawing.Font ("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_LocalDateTime.ForeColor = System.Drawing.Color.Lavender;
            this.CheckBox_LocalDateTime.Location = new System.Drawing.Point (13, 138);
            this.CheckBox_LocalDateTime.Name = "CheckBox_LocalDateTime";
            this.CheckBox_LocalDateTime.Size = new System.Drawing.Size (131, 18);
            this.CheckBox_LocalDateTime.TabIndex = 3;
            this.CheckBox_LocalDateTime.Text = "Local date and time";
            this.CheckBox_LocalDateTime.UseVisualStyleBackColor = true;
            this.CheckBox_LocalDateTime.CheckedChanged += new System.EventHandler (this.CheckBoxLocalDateTime_CheckedChanged);
            // 
            // SyncError
            // 
            this.SyncError.ContainerControl = this;
            // 
            // UpdateTimer
            // 
            this.UpdateTimer.Enabled = true;
            this.UpdateTimer.Interval = 500;
            this.UpdateTimer.Tick += new System.EventHandler (this.UpdateTimer_Tick);
            // 
            // SyncButton
            // 
            this.SyncButton.Font = new System.Drawing.Font ("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SyncButton.Location = new System.Drawing.Point (13, 168);
            this.SyncButton.Name = "SyncButton";
            this.SyncButton.Size = new System.Drawing.Size (87, 20);
            this.SyncButton.TabIndex = 4;
            this.SyncButton.Text = "Sync Now!";
            this.SyncButton.UseVisualStyleBackColor = true;
            this.SyncButton.Click += new System.EventHandler (this.SyncButton_Click);
            // 
            // SyncStatusLabel
            // 
            this.SyncStatusLabel.Font = new System.Drawing.Font ("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SyncStatusLabel.ForeColor = System.Drawing.Color.Yellow;
            this.SyncStatusLabel.Location = new System.Drawing.Point (122, 168);
            this.SyncStatusLabel.Name = "SyncStatusLabel";
            this.SyncStatusLabel.Size = new System.Drawing.Size (245, 20);
            this.SyncStatusLabel.TabIndex = 5;
            this.SyncStatusLabel.Text = "Not yet synchronized.";
            this.SyncStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SyncStatusLabel.Click += new System.EventHandler (this.SyncStatusLabel_Click);
            // 
            // ClockToolTip
            // 
            this.ClockToolTip.Popup += new System.Windows.Forms.PopupEventHandler (this.ViewToggleToolTip_Popup);
            // 
            // MyWebSiteLink
            // 
            this.MyWebSiteLink.AutoSize = true;
            this.MyWebSiteLink.Font = new System.Drawing.Font ("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWebSiteLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MyWebSiteLink.LinkColor = System.Drawing.Color.FromArgb (((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MyWebSiteLink.Location = new System.Drawing.Point (90, 223);
            this.MyWebSiteLink.Name = "MyWebSiteLink";
            this.MyWebSiteLink.Size = new System.Drawing.Size (194, 11);
            this.MyWebSiteLink.TabIndex = 6;
            this.MyWebSiteLink.TabStop = true;
            this.MyWebSiteLink.Tag = "";
            this.MyWebSiteLink.Text = "Visit the author\'s web site";
            this.MyWebSiteLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler (this.VisitWebSite_LinkClicked_1);
            // 
            // ClockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF (7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size (389, 243);
            this.Controls.Add (this.MyWebSiteLink);
            this.Controls.Add (this.SyncStatusLabel);
            this.Controls.Add (this.SyncButton);
            this.Controls.Add (this.CheckBox_LocalDateTime);
            this.Controls.Add (this.TogglerLink);
            this.Controls.Add (this.DateLabel);
            this.Controls.Add (this.TimeLabel);
            this.Font = new System.Drawing.Font ("Lucida Console", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding (19, 14, 19, 14);
            this.MaximizeBox = false;
            this.Name = "ClockForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Clock - by Don Cross - http://cosinekitty.com";
            this.Load += new System.EventHandler (this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler (this.ClockForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.SyncError)).EndInit ();
            this.ResumeLayout (false);
            this.PerformLayout ();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.LinkLabel TogglerLink;
        private System.Windows.Forms.CheckBox CheckBox_LocalDateTime;
        private System.Windows.Forms.ErrorProvider SyncError;
        private System.Windows.Forms.Timer UpdateTimer;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.Label SyncStatusLabel;
        private System.Windows.Forms.ToolTip ClockToolTip;
        private System.Windows.Forms.LinkLabel MyWebSiteLink;
    }
}


/*
    $Log: Form1.Designer.cs,v $
    Revision 1.14  2009/02/15 18:30:21  Don.Cross
    Added a link to my web site.

    Revision 1.13  2009/02/15 18:13:41  Don.Cross
    Changed check-box to toggle between localized time and date formats and my custom format for UTC.

    Revision 1.12  2009/02/15 17:50:39  Don.Cross
    In 12-hour display, now show the more natural-looking " 1:23:45 PM" instead of "01:23:45 PM".
    When first loading the clock program, before the first sync, immediately show the date and time
    so that the placeholder text doesn't linger while the first sync is running (sometimes it can be slow).

    Revision 1.11  2009/02/15 17:32:02  Don.Cross
    I learned that a single ToolTip object can serve every control on a form, so I renamed my tool tip to have a generic name of ClockToolTip.
    I added tips for the Sync Now button and most recent sync status.

    Revision 1.10  2009/02/15 17:23:09  Don.Cross
    I learned how to use tool tips.  I added a tool tip for the "..." control that toggles the display size.

    Revision 1.9  2009/02/15 00:45:57  Don.Cross
    Display last sync time and correction, or error text.

    Revision 1.8  2009/02/15 00:02:30  Don.Cross
    Added a "Sync Now" button.

    Revision 1.7  2009/02/14 23:30:51  Don.Cross
    Display an error condition if anything bad happens trying to synchronize.
    Clear the error message after successfully synchronizing.

    Revision 1.6  2009/02/14 23:09:36  Don.Cross
    Added toggle between 24-hour and 12-hour time.  Default to 12-hour time.

    Revision 1.5  2009/02/14 22:41:22  Don.Cross
    I figured out how to add a control to toggle the height of my form between a large and small value.
    I will use this to add extra optional information to the display.

    Revision 1.4  2009/02/14 19:36:43  Don.Cross
     Marcel Meuwissen sent me an email informing me of 2 problems that needed to be fixed:
    1. I thought I was correcting for round-trip time, but I was actually adjusting for fractional seconds at the NIST server.
    2. Calling double.Parse does not work in European culture settings because they use "," instead of "." as decimal point.

    Revision 1.3  2009/02/13 03:35:17  Don.Cross
    Added date to clock display.
    Changed colors.

    Revision 1.2  2009/02/13 03:20:52  Don.Cross
    I now have a working NIST clock GUI!

*/