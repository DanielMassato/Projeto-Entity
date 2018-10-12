using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace CapsLock
{
    public class Form1 : System.Windows.Forms.Form
    {
        private NotifyIcon m_notifyicon;
        private ContextMenu m_menu;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Timer timer = new Timer();
        private bool canClose = false;

        void timer_tick(object sender, EventArgs e)
        {
            if (Console.CapsLock)
            {
                m_notifyicon.Text = "caps ON";
                m_notifyicon.Icon = new Icon(GetType(), "capsOn.ico");
            }
            else
            {
                m_notifyicon.Text = "caps OFF";
                m_notifyicon.Icon = new Icon(GetType(), "capsOff.ico");
            }
            Update();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (! canClose)
            {
            e.Cancel = true;
            Hide();
            }
        }

        public Form1()
        {
            Text = "caps ON";

            m_menu = new ContextMenu();
            m_menu.MenuItems.Add(0,
                new MenuItem("Configurar", new System.EventHandler(Show_Click)));
            m_menu.MenuItems.Add(1,
                new MenuItem("Ocultar", new System.EventHandler(Hide_Click)));
            m_menu.MenuItems.Add(2,
                new MenuItem("Sair", new System.EventHandler(Exit_Click)));

            m_notifyicon = new NotifyIcon();
            m_notifyicon.Text = "caps ON";
            m_notifyicon.Visible = true;
            m_notifyicon.Icon = new Icon(GetType(), "capsOn.ico");
            m_notifyicon.ContextMenu = m_menu;

            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_tick);
            this.Shown += new EventHandler(Form1_Shown);
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            timer_tick(null, null);
            InitializeComponent();

        }

        protected void Exit_Click(Object sender, System.EventArgs e)
        {
            canClose = true;
            Close();
        }
        protected void Hide_Click(Object sender, System.EventArgs e)
        {
            Hide();
        }
        protected void Show_Click(Object sender, System.EventArgs e)
        {
            Show();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.m_notifyicon.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(12, 29);
            this.trackBar1.Maximum = 10000;
            this.trackBar1.Minimum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(138, 25);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.TickFrequency = 500;
            this.trackBar1.Value = 1000;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tempo para atualização:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "1 seg.";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(216, 75);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer.Interval = trackBar1.Value;
            label2.Text = ( Convert.ToDouble( trackBar1.Value )/ 1000).ToString("0.00") + " seg.";
        }
    }  
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
    }
}
