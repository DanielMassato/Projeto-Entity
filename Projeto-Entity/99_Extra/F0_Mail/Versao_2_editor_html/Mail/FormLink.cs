using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mail
{
    public partial class FormLink : Form
    {
        public string Texto;
        public string URL;

        public FormLink()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Texto = tbxTexto.Text;
            URL = tbxURL.Text;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Texto = "";
            URL = "";
            Close();
        }
    }
}
