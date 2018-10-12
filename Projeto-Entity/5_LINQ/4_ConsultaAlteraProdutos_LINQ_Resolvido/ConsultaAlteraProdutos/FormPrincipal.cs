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


namespace ConsultaAlteraProdutos
{
    public partial class FormPrincipal : Form
    {
        // criar objeto contendo o Entity Data Model
        // vai precisar ser acessado também do FormProdutosEdicao
        public static PEDIDOSEntities prods = new PEDIDOSEntities();
        // para armazenar dados do usuário logado
        public static string usrNOME;
        public static short usrNIVEL;

        // controle do tipo de operação que está sendo executada
        public enum EditStatus { Consulta, Inclui, Altera, Exclui };
        public static EditStatus RecStatus;

        // Para compartilhar os dados da consulta com todo o formulário
        // substitui o DataTable usado no projeto anterior
        List<ProdutosConsulta> produtos = new List<ProdutosConsulta>();

        // BindingSource para controlar posição de ponteiro
        BindingSource bsProdutos = new BindingSource();

        // método para retornar com o ID_PRODUTO selecionado no Grid
        int getIdProduto()
        {
            int lin = dgvProdutos.SelectedCells[0].RowIndex;
            return Convert.ToInt32(dgvProdutos["ID_PRODUTO",lin].Value);
        }

        public static Exception GetInnerException(Exception ex)
        {
            if (ex.InnerException == null)
                return ex;
            else
                return GetInnerException(ex.InnerException);
        }

        public FormPrincipal()
        {
            InitializeComponent();

        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            //SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
            //       T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
            //       PR.QTD_MINIMA  
            //FROM PRODUTOS PR 
            //     JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
            //     JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
            //WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
            //ORDER BY DESCRICAO
            try
            {
                // 1. fazer a pesquisa com LINQ
                produtos = prods.PRODUTOS
                           .Where(pr => pr.DESCRICAO.Contains(tbxDescricao.Text) &&
                                        pr.TIPOPRODUTO.TIPO.StartsWith(tbxTipo.Text))
                           .OrderBy(pr => pr.DESCRICAO)
                           .Select(pr => new ProdutosConsulta
                           {
                               ID_PRODUTO = pr.ID_PRODUTO,
                               COD_PRODUTO = pr.COD_PRODUTO,
                               DESCRICAO = pr.DESCRICAO,
                               TIPO = pr.TIPOPRODUTO.TIPO,
                               UNIDADE = pr.UNIDADES.UNIDADE,
                               PRECO_VENDA = pr.PRECO_VENDA,
                               QTD_REAL = pr.QTD_REAL.Value,
                               QTD_MINIMA = pr.QTD_MINIMA.Value
                           }).ToList();
                // 3. mostrar no grid usando o BindingSource
                bsProdutos.DataSource = produtos;
                dgvProdutos.DataSource = bsProdutos;
            }
            catch(Exception ex)
            {
                ex = GetInnerException(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
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

        private void tnUltimo_Click(object sender, EventArgs e)
        {
            bsProdutos.MoveLast();
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            // procura (com LINQ) o primeiro produto com desctição começando com
            // o que foi digitado em tbxProcura
            var prod = produtos
                       .Where(p => p.DESCRICAO.ToUpper()
                                    .StartsWith(tbxProcura.Text.ToUpper()))
                       .OrderBy(p => p.DESCRICAO).ToList();

            // se não encontrou ninguem
            if (prod.Count() == 0)
            {
                Console.Beep(200, 100);
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
            else
            {
                // devolve em que posição do List (produtos) está o 
                // primeiro produto da lista consultada em prod.
                // int pos = produtos.IndexOf(prod.First());
                int pos = produtos.IndexOf(prod[0]);
                // selecionar o primeiro produto encontrado
                bsProdutos.Position = pos;
            }
        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            // 1. configura a progressBar zerando a propriedade Value e com
            //    Maximum igual a quantidade de linhas do DataTable
            pb.Maximum = produtos.Count;
            pb.Value = 0;

            // 2. percorrer as linhas da lista de produtos
            for (int lin = 0; lin < produtos.Count; lin++)
            {
                // 2.1. pega o ID_PRODUTO que está na linha número lin do DataTable
                int id = produtos[lin].ID_PRODUTO;
                // 2.2. ler o produto com este ID a partir do Entity Data Model (LINQ)
                var prod = prods.PRODUTOS
                           .Where(p => p.ID_PRODUTO == id).First();
                // 2.3. alterar o preço do produto (var ficar com status ALTERADO)
                prod.PRECO_VENDA *= 1 + updPorc.Value / 100;
                // 2.4. atualizar a progressBar
                pb.Value++;
            }
            // 3. gravar as alterações no banco de dados
            try
            {
                // Aplicar no banco as alterações feitas no EDM
                prods.SaveChanges();
                // Atualizar os dados da consulta
                btnFiltra.PerformClick();
            }
            catch (Exception ex)
            {
                ex = GetInnerException(ex);
                MessageBox.Show(ex.Message);
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
            int id = getIdProduto();
            // criar o form de edição
            FormProdutosEdicao frm = new FormProdutosEdicao(id);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                // atualizar a consulta
                btnFiltra.PerformClick();
                // reposicionar o ponteiro no registro que foi
                // alterado/incluido
                var prod = produtos
                           .Where(p => p.ID_PRODUTO == frm.IdProduto);

                if (prod.Count() > 0)
                {
                    int pos = produtos.IndexOf(prod.First());

                    bsProdutos.Position = pos;
                    // NÃO FUNCIONA QUANDO BindinSource está associado
                    // à um List
                    //bsProdutos.Find("ID_PRODUTO", frm.IdProduto);
                }
            }
        }
        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Cuidado",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                // pegar o ID do produto selecionado no grid
                int id = getIdProduto();
                // consultar este produto a partir do EDM
                var prod = prods.PRODUTOS
                           .Where(p => p.ID_PRODUTO == id).First();
                // remover este produto do EDM
                prods.PRODUTOS.Remove(prod);

                try
                {
                    // salvar as alterações no banco de dados
                    prods.SaveChanges();
                    // atualizar a cnsulta
                    btnFiltra.PerformClick();
                }
                catch (Exception ex)
                {
                    // retira o status de EXCLUIDO deste registro
                    // porque DEU ERRO NA EXCLUSÃO. Se não retirarmos
                    // esse status, qualquer SaveChanges() que formos
                    // executar posteriormente, vai querer excluir este
                    // produto novamente
                    prods.Entry(prod).State =
                         System.Data.Entity.EntityState.Unchanged;

                    ex = GetInnerException(ex);
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }

    public class ProdutosConsulta
    {
        public int ID_PRODUTO { get; set; }
        public string COD_PRODUTO { get; set; }
        public string DESCRICAO { get; set; }
        public string TIPO { get; set; }
        public string UNIDADE { get; set; }
        public Nullable<decimal> PRECO_VENDA { get; set; }
        public Nullable<int> QTD_REAL { get; set; }
        public int QTD_MINIMA { get; set; }
    }


}


