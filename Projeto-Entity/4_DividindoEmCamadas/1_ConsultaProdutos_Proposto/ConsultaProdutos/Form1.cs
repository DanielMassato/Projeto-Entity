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
        SqlConnection conn = Conexoes.GetSqlConnection();
        DataTable tbProdutos = new DataTable();
        BindingSource bsProdutos = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                        @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
                                 T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
                                 PR.QTD_MINIMA  
                          FROM PRODUTOS PR 
                               JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                               JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
                          WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
                          ORDER BY DESCRICAO ";
            // passar os parâmetros
            cmd.Parameters.AddWithValue("@descricao", "%" + tbxDescricao.Text + "%");
            cmd.Parameters.AddWithValue("@tipo", tbxTipo.Text + "%");
            // criar DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                tbProdutos.Clear();
                da.Fill(tbProdutos);

                bsProdutos.DataSource = tbProdutos;
                dgvProdutos.DataSource = bsProdutos;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.Parameters.AddWithValue("@fator", 1 + updPorc.Value / 100);

            // armazena os números identificadores de cada linha selecionada no grid
            List<int> rowId = new List<int>();
            // armazena a posição do ponteiro de registro
            int pos = bsProdutos.Position;

            if (rbFiltro.Checked)
            {
                cmd.CommandText =
                        @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                      FROM PRODUTOS PR 
                           JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                      WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo ";


                cmd.Parameters.AddWithValue("@descricao", "%" + tbxDescricao.Text + "%");
                cmd.Parameters.AddWithValue("@tipo", tbxTipo.Text + "%");
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

                cmd.CommandText = @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                                    WHERE ID_PRODUTO IN (" + ids + ")";
            }

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();

                btnFiltra.PerformClick();

                // reposiciona o ponteiro de registro
                bsProdutos.Position = pos;
                // seleciona as mesmas linhas selecionadas anteriormente
                for (int i = 0; i < rowId.Count; i++)
                {
                    dgvProdutos.Rows[rowId[i]].Selected = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
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

        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o valor foi encontrado 
            int pos = -1;
            // filtrar os dados contidos no DataTable
            // NOME LIKE 'MO%'
            DataRow[] linhas = tbProdutos.Select(nomeCampo +
                " LIKE '" + valor.Replace("'", "''") + "%'");
            // se encontrol algum dado
            if (linhas.Length > 0)
            {
                // descobrir a posição onde ele está
                pos = bsProdutos.Find(nomeCampo, linhas[0][nomeCampo]);
                // deslocar o ponteiro para esta posição
                bsProdutos.Position = pos;
            }
            // retornar true se encontrou (pos >= 0) ou false
            // se não encontrou (pos < 0)
            return pos >= 0;
        }

        private void tbxProcura_Click(object sender, EventArgs e)
        {
            if (!Locate("DESCRICAO", tbxProcura.Text))
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

            // percorrer as colunas do grid
            for (int c = 0; c < dgvProdutos.Columns.Count; c++)
            {
                dgvProdutos.Columns[c].HeaderText = titulos[c];
                dgvProdutos.Columns[c].DefaultCellStyle.Format = formatos[c];

                if (align[c] == "^")
                {
                    // alinha os dados
                    dgvProdutos.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleCenter;
                    // alinha o título da coluna
                    dgvProdutos.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleCenter;
                }
                else if (align[c] == "<")
                {
                    // alinha os dados
                    dgvProdutos.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleLeft;
                    // alinha o título da coluna
                    dgvProdutos.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleLeft;
                }
                else if (align[c] == ">")
                {
                    // alinha os dados
                    dgvProdutos.Columns[c].DefaultCellStyle.Alignment =
                                             DataGridViewContentAlignment.MiddleRight;
                    // alinha o título da coluna
                    dgvProdutos.Columns[c].HeaderCell.Style.Alignment =
                                             DataGridViewContentAlignment.MiddleRight;
                }

            }

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
            // se for para XML
            if (rbXMLAtributos.Checked || rbXMLElementos.Checked)
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.xml";
                dlsSalvar.Filter = "Arquivos xml|*.xml|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "xml";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;
                // using System.Xml.Linq
                // cria o documento XML com seu elemento principal <Produtos>
                XElement docXml = new XElement("Produtos");
                // percorrer as linhas do DataTable
                for (int lin = 0; lin < tbProdutos.Rows.Count; lin++)
                {
                    // cria o elemento de linha <Produto>
                    XElement linha = new XElement("Produto");
                    if (rbXMLAtributos.Checked)
                    {
                        for (int col = 0; col < dgvProdutos.Columns.Count; col++)
                        {
                            linha.SetAttributeValue(
                                tbProdutos.Columns[col].ColumnName,// nome campo
                                tbProdutos.Rows[lin][col] // conteúdo
                                                   );
                        } // for col
                    }
                    else // elementos
                    {
                        for (int col = 0; col < dgvProdutos.Columns.Count; col++)
                        {
                            linha.Add( new XElement(
                                tbProdutos.Columns[col].ColumnName,// nome campo
                                tbProdutos.Rows[lin][col] // conteúdo
                                                   ));
                        } // for col
                    }

                    // adicina o elemento de linha <Produto> no documento XML
                    // <Produtos>
                    docXml.Add(linha);
                } // for lin

                // grava o arquivo XML
                docXml.Save(dlsSalvar.FileName);
            }
            else // CSV
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.csv";
                dlsSalvar.Filter = "Arquivos csv|*.csv|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "csv";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                // objeto necessário para sanvar arquivo texto
                // using System.IO
                StreamWriter sw = new StreamWriter(dlsSalvar.FileName,false,Encoding.Default);
                // percorrer as linhas do DataTable
                for (int lin = 0; lin < tbProdutos.Rows.Count; lin++)
                {
                    string linha = "";
                    // percorrer as colunas do DataTable
                    for (int col = 0; col < tbProdutos.Columns.Count; col++)
                    {
                        // concatenar o conteúdo do campo na variável linha
                        linha += tbProdutos.Rows[lin][col].ToString();
                        // se não for a última coluna concatenar o ";"
                        if (col < tbProdutos.Columns.Count - 1)
                            linha += ";";
                    } // for col
                    // gravar a linha no arquivo
                    sw.WriteLine(linha);
                } // for lin
                // fechar o arquivo
                sw.Close();
            }
            // using System.Diagnostics
            // mostra o arquivo dentro do seu aplicativo padrão
            Process.Start(dlsSalvar.FileName);
        }

         

    }
}


