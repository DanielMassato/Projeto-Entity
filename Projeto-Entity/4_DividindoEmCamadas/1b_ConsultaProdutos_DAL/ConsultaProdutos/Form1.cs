using LibFWGeral;
using LibPedidosDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ConsultaProdutos
{
    public partial class Form1 : Form
    {
        //SqlConnection conn = Conexoes.GetSqlConnection();
        //DataTable tbProdutos = new DataTable();

        //SqlQuery produtos = new SqlQuery(Conexoes.GetSqlConnection());
        Produtos produtos = new Produtos(Conexoes.GetSqlConnection());

        BindingSource bsProdutos = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            if (produtos.ConsultaGrid(tbxDescricao.Text,
                                      tbxTipo.Text) >= 0)
            {
                bsProdutos.DataSource = produtos.Table;
                dgvProdutos.DataSource = bsProdutos;
            }
            else
                MessageBox.Show(produtos.Error.Message);

        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            // SqlCommand cmd = conn.CreateCommand();
            // produtos.Command.Parameters.AddWithValue("@fator", 1 + updPorc.Value / 100);

            // armazena os números identificadores de cada linha selecionada no grid
            List<int> rowId = new List<int>();
            // armazena a posição do ponteiro de registro
            int pos = bsProdutos.Position;

            if (rbFiltro.Checked)
            {
                produtos.ReajustaPrecos(tbxDescricao.Text,
                                  tbxTipo.Text, updPorc.Value);
            }
            else // selecionados
            {
                string ids = "";

                DataGridViewSelectedRowCollection linhas = dgvProdutos.SelectedRows;

                if (linhas.Count == 0)
                {
                    MessageBox.Show("Nenhuma linha selecionada!!!");
                    return;
                }

                for (int i = 0; i < linhas.Count; i++)
                {
                    int id = (int)linhas[i].Cells["ID_PRODUTO"].Value;
                    ids += id.ToString();
                    if (i < linhas.Count - 1) ids += ",";
                    // adiciona na lista o número que identifica a linha selecionada
                    // do grid
                    rowId.Add(linhas[i].Cells[0].RowIndex);
                }

                produtos.ReajustaPrecos(ids, updPorc.Value);
            }

            if (produtos.Error == null)
            {
                btnFiltra.PerformClick();

                // reposiciona o ponteiro de registro
                bsProdutos.Position = pos;
                // seleciona as mesmas linhas selecionadas anteriormente
                for (int i = 0; i < rowId.Count; i++)
                {
                    dgvProdutos.Rows[rowId[i]].Selected = true;
                }

            }
            else
                MessageBox.Show(produtos.Error.Message);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveFirst();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bsProdutos.MovePrevious();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveNext();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveLast();
        }

        private void tbxProcura_Click(object sender, EventArgs e)
        {
            if (! produtos.Locate("DESCRICAO", tbxProcura.Text,
                                  bsProdutos ))
            {
                Console.Beep(800, 100);
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bsProdutos.CurrentChanged += bsProdutos_CurrentChanged;

            btnFiltra.PerformClick();

            // títulos das colunas
            string[] titulos = {"ID:", "Código:","Descrição:","Tipo:","Unid.:","Pr.Venda:",
                                "Qtd.Real:", "Qtd.Mín.:"};
            // formatação das colunas numéricas
            string[] formatos = { "0000", "", "", "", "", "R$ 0.00", "#,##0", "#,##0" };
            // alinhamentos das colunas
            string[] align = { "^", "<", "<", "<", "<", ">", ">", ">" };

            GridUtils.ConfigCols(titulos, formatos, align, dgvProdutos);

        }

        void bsProdutos_CurrentChanged(object sender, EventArgs e)
        {
            lblPosicao.Text = (bsProdutos.Position + 1) + "/" +
                              bsProdutos.Count;

            btnPrimeiro.Enabled = bsProdutos.Position > 0;
            btnAnterior.Enabled = bsProdutos.Position > 0;

            btnProximo.Enabled =
                bsProdutos.Position < bsProdutos.Count - 1;
            btnUltimo.Enabled =
                bsProdutos.Position < bsProdutos.Count - 1;
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportDataTable exDt = new ExportDataTable();
            exDt.Table = produtos.Table;
            exDt.TagRoot = "Produtos";
            exDt.TagRow = "Produto";

            // se for para XML
            if (rbXMLAtributos.Checked || rbXMLElementos.Checked)
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.xml";
                dlsSalvar.Filter = "Arquivos xml|*.xml|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "xml";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                exDt.FileName = dlsSalvar.FileName;

                if (rbXMLAtributos.Checked)
                    exDt.ExportToXMLAttributes();
                else
                    exDt.ExportToXMLElements();
                        

            }
            else // CSV
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.csv";
                dlsSalvar.Filter = "Arquivos csv|*.csv|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "csv";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                exDt.CsvWithCollumNames = true;

                exDt.FileName = dlsSalvar.FileName;
                exDt.ExportToCSV();

            }
            // using System.Diagnostics
            // mostra o arquivo dentro do seu aplicativo padrão
            Process.Start(dlsSalvar.FileName);
        }

         

    }
}


