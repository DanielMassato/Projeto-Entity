using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Imaging;

namespace Webcam_Test
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private WebCam_Capture.WebCamCapture UserControl1;
		private WebCam_Capture.WebCamCapture WebCamCapture;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button cmdStart;
		private System.Windows.Forms.Button cmdStop;
		private System.Windows.Forms.Button cmdContinue;
		private System.Windows.Forms.NumericUpDown numCaptureTime;
		private System.Windows.Forms.Label label1;
        private Button btnSalvar;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.WebCamCapture = new WebCam_Capture.WebCamCapture();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdContinue = new System.Windows.Forms.Button();
            this.numCaptureTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureTime)).BeginInit();
            this.SuspendLayout();
            // 
            // WebCamCapture
            // 
            this.WebCamCapture.CaptureHeight = 240;
            this.WebCamCapture.CaptureWidth = 320;
            this.WebCamCapture.FrameNumber = ((ulong)(0ul));
            this.WebCamCapture.Location = new System.Drawing.Point(17, 17);
            this.WebCamCapture.Name = "WebCamCapture";
            this.WebCamCapture.Size = new System.Drawing.Size(342, 252);
            this.WebCamCapture.TabIndex = 0;
            this.WebCamCapture.TimeToCapture_milliseconds = 100;
            this.WebCamCapture.ImageCaptured += new WebCam_Capture.WebCamCapture.WebCamEventHandler(this.WebCamCapture_ImageCaptured);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 252);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(6, 264);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(78, 24);
            this.cmdStart.TabIndex = 1;
            this.cmdStart.Text = "Start";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(90, 264);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(78, 24);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdContinue
            // 
            this.cmdContinue.Location = new System.Drawing.Point(174, 264);
            this.cmdContinue.Name = "cmdContinue";
            this.cmdContinue.Size = new System.Drawing.Size(78, 24);
            this.cmdContinue.TabIndex = 3;
            this.cmdContinue.Text = "Continue";
            this.cmdContinue.Click += new System.EventHandler(this.cmdContinue_Click);
            // 
            // numCaptureTime
            // 
            this.numCaptureTime.Location = new System.Drawing.Point(162, 306);
            this.numCaptureTime.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.numCaptureTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCaptureTime.Name = "numCaptureTime";
            this.numCaptureTime.Size = new System.Drawing.Size(66, 20);
            this.numCaptureTime.TabIndex = 4;
            this.numCaptureTime.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Capture Time (Milliseconds)";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(258, 265);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(342, 342);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCaptureTime);
            this.Controls.Add(this.cmdContinue);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "WebCam Capture";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Closing += new System.ComponentModel.CancelEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCaptureTime)).EndInit();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			// set the image capture size
			this.WebCamCapture.CaptureHeight = this.pictureBox1.Height;
			this.WebCamCapture.CaptureWidth = this.pictureBox1.Width;
		}

		private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			// stop the video capture
			this.WebCamCapture.Stop();
            
		}

		/// <summary>
		/// An image was capture
		/// </summary>
		/// <param name="source">control raising the event</param>
		/// <param name="e">WebCamEventArgs</param>
		private void WebCamCapture_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
		{
			// set the picturebox picture
			this.pictureBox1.Image = e.WebCamImage;
		}

		private void cmdStart_Click(object sender, System.EventArgs e)
		{
			// change the capture time frame
			this.WebCamCapture.TimeToCapture_milliseconds = (int) this.numCaptureTime.Value;

			// start the video capture. let the control handle the
			// frame numbers.
			this.WebCamCapture.Start(0);

		}

		private void cmdStop_Click(object sender, System.EventArgs e)
		{
			// stop the video capture
			this.WebCamCapture.Stop();
		}

		private void cmdContinue_Click(object sender, System.EventArgs e)
		{
			// change the capture time frame
			this.WebCamCapture.TimeToCapture_milliseconds = (int) this.numCaptureTime.Value;

			// resume the video capture from the stop
			this.WebCamCapture.Start(this.WebCamCapture.FrameNumber);
		}

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Save(@"C:\foto.bmp", ImageFormat.Bmp);
        }
	}
}
