using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObjTypeCast
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPessoa frm = new FormPessoa();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormFuncionario frm = new FormFuncionario();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormVendedor frm = new FormVendedor();
            frm.Show();
        }
    }
}
