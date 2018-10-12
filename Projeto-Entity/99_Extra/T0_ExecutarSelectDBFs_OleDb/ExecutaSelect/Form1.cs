using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.IO;

namespace ExecutaSelect
{
    public partial class Form1 : Form
    {
        // objetos para conexão com o banco de dados
        OleDbConnection conOle; //= new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Y_Dados\DBFs;Persist Security Info=False;Extended Properties=dBase III");
        // objeto para armazenar o resultado de instrução SELECT
        DataTable tbSelect = new DataTable();
        // objeto para efetuar a navegação nos dados do SELECT,
        // controlar a posição do ponteiro e sicronizar a tela
        // com o DataTable
        BindingSource bsSelect = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecSQL_Click(object sender, EventArgs e)
        {
            // objeto para armazenar e executar instruções SQL
            OleDbCommand cmd = conOle.CreateCommand();
            /*
             * OU
             * OleDbCommand cmd = new OleDbCommand()
             * cmd.Connection = conOle
             * 
             */
            // se existir texto selecionado no TextBox
            if (tbxSQL.SelectionLength > 0)
                cmd.CommandText = tbxSQL.SelectedText;
            else
                cmd.CommandText = tbxSQL.Text;
            try
            {
                int linhas;
                // se for comando SELECT
                if (cmd.CommandText.ToUpper().Trim().StartsWith("SELECT"))
                {
                    // objeto que facilita a execução de instruções SELECT
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    // limpar o objeto DataTable
                    tbSelect.Rows.Clear();
                    tbSelect.Columns.Clear();
                    // executar o SELECT
                    da.Fill(tbSelect);
                    // exibir o resultado na tela (DataGridView)
                    bsSelect.DataSource = tbSelect;
                    dgvSelect.DataSource = bsSelect;
                    linhas = tbSelect.Rows.Count;

                    tabControl1.SelectedIndex = 1;
                }
                else // não é SELECT
                {
                    conOle.Open();
                    linhas = cmd.ExecuteNonQuery();
                }

                lblStatus.Text = linhas.ToString() + 
                     " linhas afetadas...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // fecha a conexão com o banco de dados
                conOle.Close();
            }
        }

        private void tbxSQL_KeyDown(object sender, KeyEventArgs e)
        {
            // se for a tecla F5 OU
            if (e.KeyCode == Keys.F5 ||
                // pressionou Ctrl + E
                e.Control && e.KeyCode == Keys.E)
            {
                btnExecSQL.PerformClick();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            conOle.Open();
            mostraCampos(lbxTabelas.SelectedItem.ToString());
            //mostraIndices(lbxTabelas.SelectedItem.ToString());
            mostraDados(lbxTabelas.SelectedItem.ToString());
            conOle.Close();

        }

        private void mostraCampos(string tabela)
        {
            
            OleDbCommand cmd = conOle.CreateCommand();
            cmd.CommandText = "SELECT * FROM [" + tabela + "] WHERE 0=1";
            OleDbDataReader dr = cmd.ExecuteReader(CommandBehavior.KeyInfo);
            DataTable tbCampos = dr.GetSchemaTable();
            dgvCampos.DataSource = tbCampos;
        }

        private void mostraIndices(string tabela)
        {
           
        }

        private void mostraDados(string tabela)
        {
            OleDbCommand cmd = conOle.CreateCommand();
            cmd.CommandText = "SELECT * FROM " + tabela;

            cmd.Parameters.AddWithValue("tab", tabela);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbDados = new DataTable();
            da.Fill(tbDados);
            dgvDados.DataSource = tbDados;
        }

        private void tsbPrimeiro_Click(object sender, EventArgs e)
        {
            bsSelect.MoveFirst();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            bsSelect.MovePrevious();
        }

        private void tsbProximo_Click(object sender, EventArgs e)
        {
            bsSelect.MoveNext();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            bsSelect.MoveLast();
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                lblDBFDir.Text = folderBrowserDialog1.SelectedPath;
                conOle = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + lblDBFDir.Text + ";Persist Security Info=False;Extended Properties=dBase III");
                DirectoryInfo dir = new DirectoryInfo(lblDBFDir.Text);
                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo file in files)
                {
                    if (file.Extension.ToUpper() == ".DBF")
                        lbxTabelas.Items.Add(file.Name);
                }

            }
        }

    }
}
