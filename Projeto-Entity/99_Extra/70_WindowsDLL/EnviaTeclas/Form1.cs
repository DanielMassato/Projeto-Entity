using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnviaTeclas
{
    public partial class Form1 : Form
    {
        [DllImport("USER32.DLL")]
        public static extern IntPtr FindWindow(string lpClassName,
           string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetForegroundWindow();

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Obtem ID da aplicação ativa no momento            
            IntPtr appAtiva = GetForegroundWindow(); //FindWindow("Notepad", "Bloco de Notas");

            //// Verify that Calculator is a running process.
            //if (appAtiva == IntPtr.Zero)
            //{
            //    MessageBox.Show("Calculator is not running.");
            //    return;
            //}

            // Make Calculator the foreground application and send it 
            // a set of calculations.
            //SetForegroundWindow(appAtiva);
            SendKeys.SendWait("MAGNO O BÃO !!!!!!\n");
        }
    }
}
