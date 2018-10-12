using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Envia
{
    public partial class Form1 : Form
    {
        // declara dunção API do Windows para enviar mensagens
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, IntPtr wParam, IntPtr lParam);
        // declara número identificador da nossa mensagem
        // mensagens de usuário a partir de 0x0400
        private const int WM_TESTMESSAGE = 0xA123;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obtem o precesso atual (esta aplicação)
            Process proc = Process.GetCurrentProcess();
            //gera lista de aplicações em execução
            Process[] processes = Process.GetProcesses(); //(proc.ProcessName);

            if (processes.Length > 1)
            {
               
                foreach (Process p in processes)
                {
                    if (p.Id != proc.Id)
                    {
                        //envia a mensagem
                        SendMessage(p.MainWindowHandle, WM_TESTMESSAGE, IntPtr.Zero, IntPtr.Zero);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nenhuma outra aplicação em execução");
            }
        }
    }
}
