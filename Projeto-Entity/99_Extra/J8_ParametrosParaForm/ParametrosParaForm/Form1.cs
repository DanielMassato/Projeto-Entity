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
    public partial class Form1 : Form
    {
        // variáveis visíveis em toda a classe
        string nome, fone, prof;
        DateTime dtNasc;

        public Form1(string nome, DateTime dtNasc, string fone, string prof)
        {
            InitializeComponent();
            // transfere os parâmetros recebidos para as variáveis da classe
            this.nome = nome;
            this.fone = fone;
            this.prof = prof;
            this.dtNasc = dtNasc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxNome.Text = nome;
            dtpNasc.Value = dtNasc;
            mtbFone.Text = fone;
            tbxProfissao.Text = prof;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
