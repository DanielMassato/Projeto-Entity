using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Diagnostics;
using System.IO;

using System.Xml;

namespace ConsultaAlteraProdutos
{
    public partial class FormPrincipal : Form
    {
        //// cria objeto da classe ServiceProdutos
        //public static ServiceProdutos.ProdutosServiceSoapClient prods = 
        //               new ServiceProdutos.ProdutosServiceSoapClient();

        public enum EditStatus { Consulta, Altera, Inclui, Exclui }
        public static EditStatus RecStatus;

        DataTable tbProdutos = new DataTable();
        
        //BindingSource para controlar posição de ponteiro
        BindingSource bsProdutos = new BindingSource();


        public FormPrincipal()
        {
            InitializeComponent();
            tbProdutos.Columns.Add("ID_PRODUTO");
            tbProdutos.Columns.Add("COD_PRODUTO");
            tbProdutos.Columns.Add("DESCRICAO");
            tbProdutos.Columns.Add("TIPO");
            tbProdutos.Columns.Add("UNIDADE");
            tbProdutos.Columns.Add("PRECO_VENDA");
            tbProdutos.Columns.Add("QTD_MINIMA");
            tbProdutos.Columns.Add("QTD_REAL");
        }


        private void btnFiltra_Click(object sender, EventArgs e)
        {
            string erro = "";

            //var prs = prods.ListaProdutos(tbxDescricao.Text, tbxTipo.Text, ref erro);
            //bsProdutos.DataSource = null;
            //tbProdutos.Clear();
            //foreach (var item in prs)
            //{

            //    tbProdutos.Rows.Add(new object[] 
            //       { item.ID_PRODUTO,
            //         item.COD_PRODUTO,
            //         item.DESCRICAO,
            //         item.TIPO,
            //         item.UNIDADE,
            //         item.PRECO_VENDA,
            //         item.QTD_MINIMA,
            //         item.QTD_REAL});
            //}

            //if (tbProdutos != null)
            //{
            //    // associar o BindingSource ao DataTable
            //    bsProdutos.DataSource = tbProdutos;
            //    // associar o grid (dgvProdutos) ao BindingSource
            //    dgvProdutos.DataSource = bsProdutos;

            //    gridConfigCols();
            //}
            //else MessageBox.Show(erro);


        }

        private void gridConfigCols()
        {
            // formatar as colunas do grid
            string[] titulos = {"ID:", "Código:", "Descrição:", "Tipo:",
                               "Unidade:", "Pr. Venda:", "Quant:", "Qtd.Mín.:"};
            string[] campos = { "ID_PRODUTO", "COD_PRODUTO", "DESCRICAO", "TIPO", "UNIDADE", "PRECO_VENDA", "QTD_MINIMA", "QTD_REAL" };
            // formatação das colunas numéricas
            string[] formatos =  {"0000", "", "", "", "", "R$ 0.00",
                                  "#,##0", "#,##0" };
            // loop para percorrer as colunas do Grid
            for (int i = 0; i < dgvProdutos.Columns.Count; i++)
            {
                dgvProdutos.Columns[i].DataPropertyName = campos[i];
                // titulo da coluna
                dgvProdutos.Columns[i].HeaderText = titulos[i];
                // formato de apresentação
                dgvProdutos.Columns[i].DefaultCellStyle.Format = formatos[i];

                dgvProdutos.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
            }
            // alinhar a coluna 0 no centro
            dgvProdutos.Columns[0].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleCenter;
            // alinhar Preco Venda  (coluna 5) à direita
            dgvProdutos.Columns["PRECO_VENDA"].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleRight;
            // alinhar Quantidade  (coluna 6) à direita
            dgvProdutos.Columns["QTD_REAL"].DefaultCellStyle.Alignment =
                                 DataGridViewContentAlignment.MiddleRight;
            dgvProdutos.Columns[7].DefaultCellStyle.Alignment =
                                DataGridViewContentAlignment.MiddleRight;
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

        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            //// lista para armazenar os identificadores das linhas selec.
            //List<int> rowIndex = new List<int>();
            //// salva a posição do ponteiro no momento 
            //int pos = bsProdutos.Position;

            //string ids = "";
            //// gerar a lista de ID_PRODUTO selecionados no grid
            //DataGridViewSelectedRowCollection linhas = dgvProdutos.SelectedRows;
            //if (linhas.Count == 0)
            //{
            //    MessageBox.Show("Nenhuma linha selecionada...");
            //    return;
            //}
            //else
            //    // percorrer a variável linhas
            //    for (int i = 0; i < linhas.Count; i++)
            //    {
            //        // pegar o ID_PRODUTO que está na coluna zero da linha
            //        int id = Convert.ToInt32(linhas[i].Cells[0].Value);
            //        // concatenar em ids
            //        ids += id.ToString();
            //        // se não for o último ID, concatenar uma vírgula
            //        if (i < linhas.Count - 1) ids += ",";
            //        // armazenar o identificador de cada linha
            //        rowIndex.Add(linhas[i].Cells[0].RowIndex);
            //    }
            //string erro = "";
            //// Executa o reajuste de precos das linhas selecionadas

            //prods.ReajustaPrecosIDs(ids, updPorc.Value, ref erro);

           
            //if (erro == "")
            //{
            //    // atualizar a consulta do grid
            //    btnFiltra.PerformClick();
            //    // reposicionar o ponteiro no mesmo registro que estava
            //    bsProdutos.Position = pos;
            //    // selecionar as mesmas linhas de antes
            //    for (int i = 0; i < rowIndex.Count; i++)
            //    {
            //        dgvProdutos.Rows[rowIndex[i]].Selected = true;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(erro);
            //}
        }


        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            var prs = tbProdutos.AsEnumerable()
                     .Where(p => p.Field<string>("DESCRICAO").StartsWith(tbxProcura.Text))
                     .OrderBy(p => p.Field<string>("DESCRICAO"));
            // executa o método Locate procurando no campo DESCRICAO o dado
            // digitado em tbxProcura. Se não encontrar...
            if (prs.Count() == 0)
            {
                // emite um beep no auto-falante do computador
                Console.Beep(1000, 100);
                // MOX
                // posiciona o cursor de texto uma posição à esquerda.
                // ou seja, à esquerda do caractere que acaba de ser digitado
                tbxProcura.SelectionStart--;
                // seleciona 1 caractere à direita da posição atual do cursor de texto
                tbxProcura.SelectionLength = 1;
            }
            else
            {
                bsProdutos.Position = bsProdutos.Find("ID_PRODUTO", 
                                prs.First().Field<string>("ID_PRODUTO"));
                
            }
        }


        private void btnIncluiAltera_Click(object sender, EventArgs e)
        {
            // descobrir qual botão foi clicado
            ToolStripButton btn = (ToolStripButton)sender;
            // sinalizar o tipo de operação
            if (btn.Tag.ToString() == "I")
                RecStatus = EditStatus.Inclui;
            else
                RecStatus = EditStatus.Altera;

            // devolve a linha selecionada no grid
            DataRowView drv = (DataRowView)bsProdutos.Current;
            int id = Convert.ToInt32(drv["ID_PRODUTO"]);
            // criar o form de edição
            FormProdutosEdicao frm =
                         new FormProdutosEdicao(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // atualizar a consulta
                btnFiltra.PerformClick();
                // reposicionar o ponteiro no registro que foi
                // alterado/incluido
                bsProdutos.Position =
                    bsProdutos.Find("ID_PRODUTO", frm.IdProduto);
            }

        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Confirma Exclusão?",
            //    "Cuidado!!!", MessageBoxButtons.YesNo,
            //    MessageBoxIcon.Warning,
            //    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{
            //    // descobrir o ID do produto selecionado no grid
            //    // devolve a linha selecionada no grid
            //    DataRowView drv = (DataRowView)bsProdutos.Current;
            //    int id = Convert.ToInt32(drv["ID_PRODUTO"]);
            //    // salvar a posição para onde retornar depois da exclusão
            //    int pos = bsProdutos.Position;
            //    // se for a última linha...
            //    if (pos == bsProdutos.Count - 1) pos--;
            //    string erro = "";
            //    // excluir o produto
            //    prods.ExcluiProduto(id, ref erro);
            //    // se não deu erro
            //    if (erro == "")
            //    {
            //        btnFiltra.PerformClick();
            //        bsProdutos.Position = pos;
            //    }
            //    else
            //    {
            //        if (erro.Contains("FK_"))
            //            erro = "Este produto está sendo usado em outro cadastro";

            //        MessageBox.Show(erro);
            //    }

            //}
        }
    }
        
    
}


