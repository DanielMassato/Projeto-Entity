using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SetDateTime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // estrutura para armazenar as partes da data e hora
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

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME st);


        private void btnSetDate_Click(object sender, EventArgs e)
        {
            SYSTEMTIME st = new SYSTEMTIME();
            st.wYear = (short)dtpData.Value.Year;
            st.wMonth = (short)dtpData.Value.Month;
            st.wDay = (short)dtpData.Value.Day;
            st.wHour = (short)dtpHora.Value.Hour;
            st.wMinute = (short)dtpHora.Value.Minute;
            st.wSecond = (short)dtpHora.Value.Second;

            SetSystemTime(ref st);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            wb.Navigate("http://www.horariodebrasilia.org/");
        }

        public DateTime GetNISTDate(bool convertToLocalTime)
        {
            Random ran = new Random(DateTime.Now.Millisecond);
            DateTime date = DateTime.Today;
            string serverResponse = string.Empty;

            // Represents the list of NIST servers
            string[] servers = new string[] {
                         "201.49.148.135",
                         "200.186.125.195",
                         "200.160.0.8 ",
                         "200.189.40.8 ",
                         "200.192.232.8 "
                          };

            // Try each server in random order to avoid blocked requests due to too frequent request
            for (int i = 0; i < 5; i++)
            {
                try
                {
                    // Open a StreamReader to a random time server
                    StreamReader reader = new StreamReader(new System.Net.Sockets.TcpClient(servers[i], 13).GetStream());
                    serverResponse = reader.ReadToEnd();
                    reader.Close();

                    // Check to see that the signiture is there
                    if (serverResponse.Length > 47 && serverResponse.Substring(38, 9).Equals("UTC(NIST)"))
                    {
                        // Parse the date
                        int jd = int.Parse(serverResponse.Substring(1, 5));
                        int yr = int.Parse(serverResponse.Substring(7, 2));
                        int mo = int.Parse(serverResponse.Substring(10, 2));
                        int dy = int.Parse(serverResponse.Substring(13, 2));
                        int hr = int.Parse(serverResponse.Substring(16, 2));
                        int mm = int.Parse(serverResponse.Substring(19, 2));
                        int sc = int.Parse(serverResponse.Substring(22, 2));

                        if (jd > 51544)
                            yr += 2000;
                        else
                            yr += 1999;

                        date = new DateTime(yr, mo, dy, hr, mm, sc);

                        // Convert it to the current timezone if desired
                        if (convertToLocalTime)
                            date = date.ToLocalTime();

                        // Exit the loop
                        tbxHTML.Text += servers[i] + ", ";
                        ;
                    }

                }
                catch (Exception ex)
                {
                    /* Do Nothing...try the next server */
                }
            }

            return date;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd/MM/yy - hh:mm:ss", new System.Globalization.CultureInfo("pt-BR"));

                //GetNISTDate(true).ToString("dd/MM/yyyy - hh:mm:ss");
        }


         
    }
}
