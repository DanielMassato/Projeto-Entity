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
using System.IO;

namespace TabelaComDocsDentro
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
            cmd.CommandText = "SELECT * FROM TABELACOMDOCSDENTRO";
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
            dgvDocs.Columns[3].Visible = false;
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // nome do arquivo que será importado
                string fileName = openFileDialog1.FileName;
                // extrai a extensão do arquivo
                string ext = Path.GetExtension(fileName);
                // cria uma linha vazia (na memória) com a mesma estrutura da tabela
                DataRow dr = tbDocs.NewRow();
                dr["DESCRICAO"] = "TESTE";
                dr["TIPO"] = ext;
                // Cria um manipulador de arquivo para leitura
                FileStream fs = File.OpenRead(fileName);
                // cria array de bytes para armazenar o conteúdo do documento
                byte[] b = new byte[fs.Length];
                // lê o arquivo e copia pra dentro do array de bytes
                fs.Read(b, 0, b.Length);
                // grava o aray no campo DOCTO
                dr["DOCTO"] = b;
                fs.Close();
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
            // gera um nome de arquivo temporário com a extensão
            // igual ao do documento atual
            string fileName = "temp_" + 
                   DateTime.Now.ToString("ddMMyy_hhmmss") +
                   tbDocs.Rows[bsDocs.Position]["TIPO"].ToString();
            // cria um manipulador de arquivo para gravação
            FileStream fs = File.OpenWrite(fileName);
            // lê o conteúdo do campo DOCTO e armazena em array de bytes
            byte[] b = (byte[])tbDocs.Rows[bsDocs.Position]["DOCTO"];
            // grava o array de bytes no arquivo
            fs.Write(b, 0, b.Length);
            fs.Close();
            // abre o arquivo utilizando o aplicativo associado a
            // ele no Windows
            Process.Start(fileName);
        }

   

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            gravaDados();
        }

 
    }
}
