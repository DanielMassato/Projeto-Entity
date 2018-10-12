using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ParametrosParaForm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            tbxNome.Text = FormPrincipal.Nome;
            dtpNasc.Value = FormPrincipal.DataNasc;
            mtbFone.Text = FormPrincipal.Fone;
            tbxProfissao.Text = FormPrincipal.Profissao;
        }
    }
}
