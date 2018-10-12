using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace ConsultaAlteraProdutos
{
    public partial class FormProdutosEdicao : Form
    {

        public int IdProduto;
        // o construtor deste form foi alterado de modo a receber
        // o ID do produto e o objeto que gerencia a tabela, já
        // criado em FormProdutos
        public FormProdutosEdicao( int idProduto)
        {
            InitializeComponent();

            this.IdProduto = idProduto;

            // usando LINQ, carregar o  ComboBox de tipos de produto
            var tipos = from t in FormPrincipal.prods.TIPOPRODUTO
                        orderby t.TIPO
                        select t;
            cmbTipo.DataSource = tipos.ToList();
            cmbTipo.DisplayMember = "TIPO";
            cmbTipo.ValueMember = "COD_TIPO";

            // usando LINQ, carregar o ComboBox de Unidades de medida
            var unidades = FormPrincipal.prods.UNIDADES
                           .OrderBy(u => u.UNIDADE);

            cmbUnidades.DataSource = unidades.ToList();
            cmbUnidades.DisplayMember = "UNIDADE";
            cmbUnidades.ValueMember = "COD_UNIDADE";

            if (FormPrincipal.RecStatus == FormPrincipal.EditStatus.Altera)
            {
                Text = "Alterando dados do produto";
                // usando LINQ, ler na variável prod os dados do produto que será alterado 
                var prod = FormPrincipal.prods.PRODUTOS
                          .Where(p => p.ID_PRODUTO == idProduto).First();

                // mostrar os dados na tela
                tbxCOD_PRODUTO.Text = prod.COD_PRODUTO;
                tbxDESCRICAO.Text = prod.DESCRICAO;
                tbxCOD_TIPO.Text = prod.COD_TIPO.ToString();
                tbxCOD_UNIDADE.Text = prod.COD_UNIDADE.ToString();
                tbxCLAS_FISC.Text = prod.CLAS_FISC;
                updPRECO_CUSTO.Value = prod.PRECO_CUSTO.Value;
                updPRECO_VENDA.Value = prod.PRECO_VENDA.Value;
                updQTD_MINIMA.Value = prod.QTD_MINIMA.Value;
                updQTD_REAL.Value = prod.QTD_REAL.Value;
                updIPI.Value = prod.IPI.Value;
                // mostrar as descrições corretas de TIPO e UNIDADE
                cmbTipo.SelectedValue = prod.COD_TIPO;
                cmbUnidades.SelectedValue = prod.COD_UNIDADE;
            }
            else
            {
                Text = "Incluindo novo produto";
                cmbTipo.SelectedValue = 0;
                cmbUnidades.SelectedValue = 1;
                tbxCOD_TIPO.Text = "0";
                tbxCOD_UNIDADE.Text = "1";

            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue != null)
                tbxCOD_TIPO.Text = cmbTipo.SelectedValue.ToString();
        }

        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUnidades.SelectedValue != null)
                tbxCOD_UNIDADE.Text = cmbUnidades.SelectedValue.ToString();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            //// declarar objeto da classe PRODUTOS (campos da tabela)
            PRODUTOS prod;
            // se for inclusão
            if (FormPrincipal.RecStatus == FormPrincipal.EditStatus.Inclui)
            {
                // instanciar objeto da classe PRODUTOS colocando nele 
                // os dados digitados na tela
                prod = new PRODUTOS
                {
                    ID_PRODUTO = 0,
                    COD_PRODUTO = tbxCOD_PRODUTO.Text,
                    DESCRICAO = tbxDESCRICAO.Text,
                    COD_TIPO = Convert.ToInt16(tbxCOD_TIPO.Text),
                    COD_UNIDADE = Convert.ToInt16(tbxCOD_UNIDADE.Text),
                    CLAS_FISC = tbxCLAS_FISC.Text,
                    PRECO_CUSTO = updPRECO_CUSTO.Value,
                    PRECO_VENDA = updPRECO_VENDA.Value,
                    QTD_MINIMA = (int)updQTD_MINIMA.Value,
                    QTD_REAL = (int)updQTD_REAL.Value,
                    IPI = (int)updIPI.Value
                };
                // adiciona este novo produto no Entity Data Model (EDM)
                // vai ficar com status de INSERIDO
                FormPrincipal.prods.PRODUTOS.Add(prod);
            }
            else // é alteração
            {
                // ler os dados do produto que está sendo alterado colocando
                // o resultado na variável prod
                prod = FormPrincipal.prods.PRODUTOS
                    .Where(p => p.ID_PRODUTO == IdProduto).First();

                // substituir os dados deste produto pelos dados
                // digitados na tela. Vai ficar com stadus de ALTERADO
                prod.COD_PRODUTO = tbxCOD_PRODUTO.Text;
                prod.DESCRICAO = tbxDESCRICAO.Text;
                prod.COD_TIPO = Convert.ToInt16(tbxCOD_TIPO.Text);
                prod.COD_UNIDADE = Convert.ToInt16(tbxCOD_UNIDADE.Text);
                prod.CLAS_FISC = tbxCLAS_FISC.Text;
                prod.PRECO_CUSTO = updPRECO_CUSTO.Value;
                prod.PRECO_VENDA = updPRECO_VENDA.Value;
                prod.QTD_MINIMA = (int)updQTD_MINIMA.Value;
                prod.QTD_REAL = (int)updQTD_REAL.Value;
                prod.IPI = (int)updIPI.Value;
            }
            // salvar a inclusão/alteração
            try
            {
                // salvar as alterações do EDM no banco de dados
                FormPrincipal.prods.SaveChanges();
                // colocar o ID_PRODUTO na variável IdProduto do form
                this.IdProduto = prod.ID_PRODUTO;

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // restaura o status deste produto para NÃO MODIFICADO
                FormPrincipal.prods.Entry(prod).State =
                     System.Data.Entity.EntityState.Unchanged;

                ex = FormPrincipal.GetInnerException(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }


    }
}
