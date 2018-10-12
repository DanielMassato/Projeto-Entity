using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;
using LibPedidosDAL;
using LibFWGeral;

namespace ConsultaAlteraProdutos
{
    public partial class FormPrincipal : Form
    {
        // cria objeto da classe Produtos
        Produtos prods = new Produtos(Conexoes.GetSqlConnection());

        // BindingSource para controlar posição de ponteiro
        BindingSource bsProdutos = new BindingSource();

        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            if (prods.ConsultaGrid(tbxDescricao.Text, tbxTipo.Text) >= 0)
            {
                // associar o BindingSource ao DataTable
                bsProdutos.DataSource = prods.Table;
                // associar o grid (dgvProdutos) ao BindingSource
                dgvProdutos.DataSource = bsProdutos;
            }
            else MessageBox.Show(prods.Error.Message);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveFirst();
        }

        private void tnAnterior_Click(object sender, EventArgs e)
        {
            bsProdutos.MovePrevious();
        }

        private void tnProximo_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveNext();
        }

        private void tnUltimo_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveLast();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // força a execução do evento Click de btnFiltra
            btnFiltra.PerformClick();
            // formatar as colunas do grid
            string[] titulos = {"ID:", "Código:", "Descrição:", "Tipo:",
                               "Unidade:", "Pr. Venda:", "Quant:", "Qtd.Mín.:"};
            // formatação das colunas numéricas
            string[] formatos =  {"0000", "", "", "", "", "R$ 0.00",
                                  "#,##0", "#,##0" };
            // loop para percorrer as colunas do Grid
            for (int i = 0; i < dgvProdutos.Columns.Count; i++)
            {
                // titulo da coluna
                dgvProdutos.Columns[i].HeaderText = titulos[i];
                // formato de apresentação
                dgvProdutos.Columns[i].DefaultCellStyle.Format = formatos[i];
            }
            // alinhar a coluna 0 no centro
            dgvProdutos.Columns[0].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleCenter;
            // alinhar Preco Venda  (coluna 5) à direita
            dgvProdutos.Columns[5].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleRight;
            // alinhar Quantidade  (coluna 6) à direita
            dgvProdutos.Columns[6].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleRight;
            dgvProdutos.Columns[7].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleRight;
        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            // lista para armazenar os identificadores das linhas selec.
            List<int> rowIndex = new List<int>();
            // salva a posição do ponteiro no momento 
            int pos = bsProdutos.Position;

            // se for reajustar pelo filtro
            if (rbFiltro.Checked)
            {
                prods.ReajustaPrecos( tbxDescricao.Text,tbxTipo.Text,updPorc.Value);
            }
            else // reajuste dos selecionados
            {
                string ids = "";
                // gerar a lista de ID_PRODUTO selecionados no grid
                DataGridViewSelectedRowCollection linhas = dgvProdutos.SelectedRows;
                if (linhas.Count == 0)
                {
                    MessageBox.Show("Nenhuma linha selecionada...");
                    return;
                }
                // percorrer a variável linhas
                for (int i = 0; i < linhas.Count; i++)
                {
                    // pegar o ID_PRODUTO que está na coluna zero da linha
                    int id = (int)linhas[i].Cells[0].Value;
                    // concatenar em ids
                    ids += id.ToString();
                    // se não for o último ID, concatenar uma vírgula
                    if (i < linhas.Count - 1) ids += ",";
                    // armazenar o identificador de cada linha
                    rowIndex.Add(linhas[i].Cells[0].RowIndex);
                }

                prods.ReajustaPrecos(ids, updPorc.Value);
            }
            // executar o UPDATE
            if (prods.Error == null)
            {
                // atualizar a consulta do grid
                btnFiltra.PerformClick();
                // reposicionar o ponteiro no mesmo registro que estava
                bsProdutos.Position = pos;
                // selecionar as mesmas linhas de antes
                for (int i = 0; i < rowIndex.Count; i++)
                {
                    dgvProdutos.Rows[rowIndex[i]].Selected = true;
                }
            }
            else
            {
                MessageBox.Show(prods.Error.Message);
            }
        }
       

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            // executa o método Locate procurando no campo DESCRICAO o dado
            // digitado em tbxProcura. Se não encontrar...
            if (! prods.Locate("DESCRICAO", tbxProcura.Text,bsProdutos))
            {
                // emite um beep no auto-falante do computador
                Console.Beep(100, 100);
                // posiciona o cursor de texto uma posição à esquerda.
                // ou seja, à esquerda do caractere que acaba de ser digitado
                tbxProcura.SelectionStart--;
                // seleciona 1 caractere à direita da posição atual do cursor de texto
                tbxProcura.SelectionLength = 1;
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportDataTable exDt = new ExportDataTable();

            exDt.Table = prods.Table;

            exDt.TagRoot = "Produtos";
            exDt.TagRow = "Produto";
            exDt.CsvWithCollumNames = true;

            // se for para XML
            if (rbXMLAtributos.Checked || rbXMLElementos.Checked)
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.xml";
                dlsSalvar.Filter = "Arquivos xml|*.xml|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "xml";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                // NOVO
                exDt.FileName = dlsSalvar.FileName;
                if (rbXMLAtributos.Checked) exDt.ExportToXMLAttributes();
                else exDt.ExportToXMLElements();

            }
            else // CSV
            {
                // configurar a janela de salvar para XML
                dlsSalvar.FileName = "Produtos.csv";
                dlsSalvar.Filter = "Arquivos csv|*.csv|Todos os arquivos|*.*";
                dlsSalvar.DefaultExt = "csv";
                // se não confirmar o salvamento
                if (dlsSalvar.ShowDialog() == DialogResult.Cancel) return;

                // NOVO
                exDt.FileName = dlsSalvar.FileName;
                exDt.ExportToCSV();

            }
            // using System.Diagnostics
            // mostra o arquivo dentro do seu aplicativo padrão
            Process.Start(dlsSalvar.FileName);

        }
    }
}


