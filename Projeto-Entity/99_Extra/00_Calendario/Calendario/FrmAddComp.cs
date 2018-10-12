using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calendario
{
    public partial class FrmAddComp : Form
    {
        public DateTime dtComp;

        public FrmAddComp()
        {
            InitializeComponent();
        }

        public FrmAddComp(DateTime dt)
        {
            InitializeComponent();
            dtComp = dt;
            dtp1.Value = dt;
        }


        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Calendario.data", true);
            sw.WriteLine('\x0011');
            sw.WriteLine(dtp1.Value.Date.ToString("yyyy.MM.dd") +
                          dtpHora.Value.ToString("HH.mm") +
                          tbxTit.Text.PadRight(100, ' ') );
            sw.WriteLine(tbxDet.Text);
            //sw.WriteLine('\x0010');
            sw.Close();
            sw.Dispose();
            Close();
        }

        private void FrmAddComp_Load(object sender, EventArgs e)
        {

        }
    }
}