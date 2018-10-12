using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Recebe
{
    public partial class Form1 : Form
    {
        // declara número identificador da nossa mensagem
        private const int WM_TESTMESSAGE = 0xA123;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message message)
        {
            //filter the RF_TESTMESSAGE
            if (message.Msg == WM_TESTMESSAGE)
            {
                //display that we recieved the message, of course we could do
                //something else more important here.
                this.listBox1.Items.Add("Captei Vossa Mensagem...");
            }
            //be sure to pass along all messages to the base also
            base.WndProc(ref message);
        }
    }
}
