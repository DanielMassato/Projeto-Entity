using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;

namespace TabelaComDocsFora
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = new OleDbConnection(@"Provider=SQLOLEDB;Data Source=4P16_INSTRUTOR\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=PEDIDOS");
        DataTable tbDocs = new DataTable();
        OleDbDataAdapter daDocs = new OleDbDataAdapter();
        BindingSource bsDocs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        void executaSelect()
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM TABELACOMDOCSFORA";
            daDocs.SelectCommand = cmd;
            tbDocs.Clear();
            daDocs.Fill(tbDocs);
            bsDocs.DataSource = tbDocs;
            dgvDocs.DataSource = bsDocs;
        }



        void gravaDados()
        {
            OleDbCommandBuilder cb = new OleDbCommandBuilder(daDocs);
            daDocs.Update(tbDocs);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            gravaDados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            executaSelect();
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // NOME DO ARQUIVO selecionado
                string fileName = openFileDialog1.FileName;
                // cria (na memória) uma linha vazia com a mesma estrutura da tabela
                DataRow dr = tbDocs.NewRow();
                dr["DESCRICAO"] = "TESTE";
                dr["PATH_DOCTO"] = fileName;
                // adiciona a linha no DataTable
                tbDocs.Rows.Add(dr);
                // gera o comando INSERT e executa
                gravaDados();
                // atualiza a consulta
                executaSelect();
            }

        }

        private void btnVerDocto_Click(object sender, EventArgs e)
        {
            // lê o caminho e o nome do arquivo da tabela
            string fileName = tbDocs.Rows[bsDocs.Position]["PATH_DOCTO"].ToString();
            // abre o arquivo no aplicativo correspondente
            Process.Start(fileName);
        }

        private void dgvDocs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gravaDados();
        }
    }
}
