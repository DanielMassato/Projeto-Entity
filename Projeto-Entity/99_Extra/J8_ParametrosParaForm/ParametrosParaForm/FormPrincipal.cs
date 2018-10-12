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
    public partial class FormPrincipal : Form
    {
        public static string Nome;
        public static string Fone;
        public static string Profissao;
        public static DateTime DataNasc;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Form1(tbxNome.Text, dtpNasc.Value, mtbFone.Text, tbxProfissao.Text)).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Form2( new object[] {tbxNome.Text, dtpNasc.Value, mtbFone.Text, tbxProfissao.Text} )).ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form3(new Pessoa ( tbxNome.Text, dtpNasc.Value, mtbFone.Text, tbxProfissao.Text ))).ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Nome = tbxProfissao.Text;
            DataNasc = dtpNasc.Value;
            Fone = mtbFone.Text;
            Profissao = tbxProfissao.Text;

            (new Form4()).ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PessoaStatic.Nome = tbxProfissao.Text;
            PessoaStatic.DataNasc = dtpNasc.Value;
            PessoaStatic.Fone = mtbFone.Text;
            PessoaStatic.Profissao = tbxProfissao.Text;

            (new Form5()).ShowDialog();
        }
    }

    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Fone { get; set; }
        public string Profissao { get; set; }

        public Pessoa(string nome, DateTime dtNasc, string fone, string prof)
        {
            Nome = nome;
            DataNasc = dtNasc;
            Fone = fone;
            Profissao = prof;
        }
    }

    public static class PessoaStatic
    {
        public static string Nome;
        public static string Fone;
        public static string Profissao;
        public static DateTime DataNasc;
    }
}
