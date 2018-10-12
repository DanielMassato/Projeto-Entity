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

            cmd.Parameters.AddWithValue("@descricao", "%" + tbxDescricao.Text + "%");
            cmd.Parameters.AddWithValue("@tipo", tbxTipo.Text + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tbProdutos.Clear();

            try
            {
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

            // para armazenar as linhas selecionadas no grid
            List<int> rowId = new List<int>();
            // para armazenar a posição do ponteiro de registro
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
            else
            {
                DataGridViewSelectedRowCollection linhas =
                                                dgvProdutos.SelectedRows;
                string ids = "";
                // se não existirem linhas selecionadas
                if (linhas.Count == 0)
                {
                    MessageBox.Show("Nenhuma linha selecionada");
                    return;
                }
                // percorrer as linhas selecionadas e montar a lista
                // de IDs de procuto
                for (int i = 0; i < linhas.Count; i++)
                {
                    // pegar o ID_PRODUTO da linha i
                    int id = (int)linhas[i].Cells["ID_PRODUTO"].Value;
                    // concatenar na lista
                    ids += id.ToString();
                    // se não for o último, concatenar uma vírgula
                    if (i < linhas.Count - 1) ids += ",";
                    // adicionar o identificador de linha na lista
                    // de linhas selecionadas
                    rowId.Add(linhas[i].Cells[0].RowIndex);
                }
                // montar o comando UPDATE
                cmd.CommandText = 
                @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                  WHERE ID_PRODUTO IN (" + ids + ")";
            }
            // executar o comando
            try
            {                
                conn.Open();
                cmd.ExecuteNonQuery();
                // atualiza a consulta
                btnFiltra.PerformClick();

                // restaurar o grid como antes do reajuste
                bsProdutos.Position = pos;

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

        private void Form1_Load(object sender, EventArgs e)
        {
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

            bsProdutos.CurrentChanged += BsProdutos_CurrentChanged;

        }

        private void BsProdutos_CurrentChanged(object sender, EventArgs e)
        {
            btnPrimeiro.Enabled = bsProdutos.Position > 0;
            btnAnterior.Enabled = bsProdutos.Position > 0;

            btnProximo.Enabled = bsProdutos.Position < bsProdutos.Count - 1;
            btnUltimo.Enabled = bsProdutos.Position < bsProdutos.Count - 1;

            lblRecNo.Text = (bsProdutos.Position + 1) + " / " +
                            bsProdutos.Count; 
        }

        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o dado foi encontrado dentro
            // do DataTable
            int pos = -1;
            // filtrar o DataTable 
            DataRow[] linhas = tbProdutos.Select(nomeCampo + " LIKE '" +valor.Replace("'", "''") + "%'");

            if (linhas.Length > 0)
            {
                // descobre a posição onde está esse nome
                // dentro do DataTable
                pos = bsProdutos.Find(nomeCampo,linhas[0][nomeCampo]);
                // posicionar na linha correspondente
                bsProdutos.Position = pos;
            }
            return pos >= 0;
        }
        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            if (!Locate("DESCRICAO", tbxProcura.Text))
            {
                Console.Beep(800, 100);
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            // se for para XML
            if (rbXMLAtributos.Checked || rbXMLElementos.Checked)
            {
                dlsSalvar.FileName = "Produtos.xml";
                dlsSalvar.DefaultExt = "xml";
                dlsSalvar.Filter = "Arq. xml|*.xml|Todos|*.*";

                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                // criar o documento XML com o seu elemento raiz <Produtos>
                XElement docXml = new XElement("Produtos");
                // percorrer as linhas do DataTable
                for (int lin = 0; lin < tbProdutos.Rows.Count; lin++)
                {
                    // criar o elemento para cada produto
                    XElement prod = new XElement("Produto");
                    // percorrer as colunas desta linha do DataTable
                    for (int col = 0; col < tbProdutos.Columns.Count; col++)
                    {
                        // se for XML com atributos
                        if (rbXMLAtributos.Checked)
                        {
                            prod.SetAttributeValue(
                                // nome do atributo (nome do campo)
                                tbProdutos.Columns[col].ColumnName,
                                // valor do atributo (conteúdo do campo)
                                tbProdutos.Rows[lin][col]
                                );
                        }
                        else // XML com elementos
                        {
                            prod.Add(new XElement(
                                // nome do elemento (nome do campo)
                                tbProdutos.Columns[col].ColumnName,
                                // valor do elemento (conteúdo do campo)
                                tbProdutos.Rows[lin][col]
                                ));
                        }

                    } // for col
                    // adicionar esta linha no documento Xml
                    docXml.Add(prod);

                } // for lin
                // salvar o documento Xml
                docXml.Save(dlsSalvar.FileName);
            }
            else // é CSV
            {
                dlsSalvar.FileName = "Produtos.csv";
                dlsSalvar.DefaultExt = "csv";
                dlsSalvar.Filter = "Arq. csv|*.csv|Todos|*.*";

                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                // objeto para salvar arquivo texto (System.IO)
                StreamWriter sw = new StreamWriter(dlsSalvar.FileName, false, Encoding.Default);
                // percorrer as linhas do DataTable
                for (int lin = 0; lin < tbProdutos.Rows.Count; lin++)
                {
                    // variável para concatenar os campos
                    string linha = "";
                    // percorrer as colunas do DataTable
                    for (int col = 0; col < tbProdutos.Columns.Count; col++)
                    {
                        linha += tbProdutos.Rows[lin][col];
                        // se não for a última coluna concatenar um ponto-e-vírgula
                        if (col < tbProdutos.Columns.Count - 1) linha += ";";
                    } // cor col
                    // gravar a linha no arquivo
                    sw.WriteLine(linha);
                } // for lin
                // fechar o arquivo
                sw.Close();
            }

            // abrir o arquivo salvo (System.Diagnostics)
            Process.Start(dlsSalvar.FileName);
        }
    }
}


