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
    public partial class Form2 : Form
    {
        // variáveis visíveis em toda a classe
        string nome, fone, prof;
        DateTime dtNasc;

        public Form2( object[] dados )
        {
            InitializeComponent();

            this.nome = dados[0].ToString();
            this.dtNasc = Convert.ToDateTime(dados[1]);
            this.fone = dados[2].ToString();
            this.prof = dados[3].ToString();            
        }

        private void Form2_Load(object sender, EventArgs e)
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
