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
        // public static PEDIDOSEntities prods = new PEDIDOSEntities();

        // controle do tipo de operação que está sendo executada
        public enum EditStatus { Consulta, Inclui, Altera, Exclui };
        public static EditStatus RecStatus;
        // Para compartilhar os dados da consulta com todo o formulário
        
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

            // 1. fazer a pesquisa com LINQ

            

            // 3. mostrar no grid usando o BindingSource
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //// força a execução do evento Click de btnFiltra
            //btnFiltra.PerformClick();
            //// formatar as colunas do grid
            //string[] titulos = {"ID:", "Código:", "Descrição:", "Tipo:",
            //                   "Unidade:", "Pr. Venda:", "Quant:", "Qtd.Mín.:"};
            //// formatação das colunas numéricas
            //string[] formatos =  {"0000", "", "", "", "", "R$ 0.00",
            //                      "#,##0", "#,##0" };
            //// loop para percorrer as colunas do Grid
            //for (int i = 0; i < dgvProdutos.Columns.Count; i++)
            //{
            //    // titulo da coluna
            //    dgvProdutos.Columns[i].HeaderText = titulos[i];
            //    // formato de apresentação
            //    dgvProdutos.Columns[i].DefaultCellStyle.Format = formatos[i];
            //}
            //// alinhar a coluna 0 no centro
            //dgvProdutos.Columns[0].DefaultCellStyle.Alignment =
            //                     DataGridViewContentAlignment.MiddleCenter;
            //// alinhar Preco Venda  (coluna 5) à direita
            //dgvProdutos.Columns[5].DefaultCellStyle.Alignment =
            //                     DataGridViewContentAlignment.MiddleRight;
            //// alinhar Quantidade  (coluna 6) à direita
            //dgvProdutos.Columns[6].DefaultCellStyle.Alignment =
            //                     DataGridViewContentAlignment.MiddleRight;
            //dgvProdutos.Columns[7].DefaultCellStyle.Alignment =
            //                    DataGridViewContentAlignment.MiddleRight;
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
  


            //// se não encontrou ninguem
            //if (prod.Count() == 0)
            //{
            //    Console.Beep(200, 100);
            //    tbxProcura.SelectionStart--;
            //    tbxProcura.SelectionLength = 1;
            //}
            //else
            //{
            //    // selecionar o primeiro produto encontrado
            //    bsProdutos.Position =
            //        // devolve a posição onde encontra na coluna ID_PRODUTO
            //        bsProdutos.Find("ID_PRODUTO",
            //        // o primeiro registro da lista retornada pelo LINQ
            //           prod.First().ID_PRODUTO);
            //}
        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {
            // 1. configura a progressBar zerando a propriedade Value e com
            //    Maximum igual a quantidade de linhas do DataTable

            
            // 2. percorrer as linhas da lista de produtos
            
            
                // 2.1. pega o ID_PRODUTO que está na linha número lin do DataTable
                
                // 2.2. ler o produto com este ID a partir do Entity Data Model (LINQ)

                
                // 2.3. alterar o preço do produto (var ficar com status ALTERADO)
                
                // 2.4. atualizar a progressBar
                
            
            // 3. gravar as alterações no banco de dados
            
                // Aplicar no banco as alterações feitas no EDM
                

                // Atualizar os dados da consulta
            
            
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
                bsProdutos.Position =
                    bsProdutos.Find("ID_PRODUTO", frm.IdProduto);
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

                
                // remover este produto do EDM
                

                try
                {
                    // salvar as alterações no banco de dados

                    // atualizar a cnsulta
                    btnFiltra.PerformClick();
                }
                catch (Exception ex)
                {
                    ex = GetInnerException(ex);
                    MessageBox.Show(ex.Message);
                }
            }
        }

    }
}


