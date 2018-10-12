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
    public partial class Form3 : Form
    {
        // variáveis visíveis em toda a classe
        string nome, fone, prof;
        DateTime dtNasc;

        public Form3( Pessoa pessoa )
        {
            InitializeComponent();

            this.nome = pessoa.Nome;
            this.fone = pessoa.Fone;
            this.prof = pessoa.Profissao;
            this.dtNasc = pessoa.DataNasc;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            tbxNome.Text = nome;
            dtpNasc.Value = dtNasc;
            mtbFone.Text = fone;
            tbxProfissao.Text = prof;
        }
    }
}
