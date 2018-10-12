using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibPedidosDAL;



namespace ConsultaAlteraProdutos
{
    public partial class FormProdutosEdicao : Form
    {
        // armazena o objeto que gerencia a tabela produtos,
        // será usado em mais de um método porisso foi declarado aqui
        Produtos prods;
        // ID do produto que está sendo alterado/incluido
        public int IdProduto;

        // o construtor deste form foi alterado de modo a receber
        // o ID do produto e o objeto que gerencia a tabela, já
        // criado em FormProdutos
        public FormProdutosEdicao(int idProduto, Produtos prods)
        {
            InitializeComponent();
            // transfere os parâmetros recebidos para as variáveis
            // declaradas fora do método para que sejam visíveis
            // no botão Grava
            this.prods = prods;
            this.IdProduto = idProduto;

            // Carregar o combo box de tipos de produto
            cmbTipo.DataSource = prods.TiposProduto();
            // campo que será exibido no comboBox
            // o tipo selecionado pelo usuário no comboBox pode ser
            // recuperado na propriedade SelectedItem
            cmbTipo.DisplayMember = "TIPO";
            // definir o campo que o comboBox vai retornar
            // para recuperar o COD_TIPO correspondente ao item selecionado
            // pelo usuário usaremos a propriedade SelectedValue
            cmbTipo.ValueMember = "COD_TIPO";

            cmbUnidades.DataSource = prods.UnidadesMedida();
            cmbUnidades.DisplayMember = "UNIDADE";
            cmbUnidades.ValueMember = "COD_UNIDADE";


            if (prods.RecStatus == LibFWGeral.SqlQuery.EditStatus.Altera)
            {
                Text = "Alterando os dados do produto";

                CamposProduto pr = prods.FichaProduto(idProduto);

                // mostrar os dados na tela
                tbxCOD_PRODUTO.Text = pr.COD_PRODUTO;
                tbxDESCRICAO.Text = pr.DESCRICAO;
                tbxCOD_TIPO.Text = pr.COD_TIPO.ToString();
                tbxCOD_UNIDADE.Text = pr.COD_UNIDADE.ToString();

                updPRECO_CUSTO.Value = pr.PRECO_CUSTO;
                updPRECO_VENDA.Value = pr.PRECO_VENDA;
                updQTD_MINIMA.Value = pr.QTD_MINIMA;
                updQTD_REAL.Value = pr.QTD_REAL;
                tbxCLAS_FISC.Text = pr.CLAS_FISC;
                updIPI.Value = pr.IPI;

                // mostrar nos comboBox, a unidade e o tipo do produto atual
                cmbTipo.SelectedValue = pr.COD_TIPO;
                cmbUnidades.SelectedValue = pr.COD_UNIDADE;
            }
            else // inclusão
            {
                Text = "Incluindo um novo produto";
                // na tabela TIPOPRODUTO, o código zero corresponde ao 
                // TIPO = "NÃO CADASTRADO"
                cmbTipo.SelectedValue = 0;
                // na tabela UNIDADES, o código 1 corresponde ao 
                // UNIDADE = "NÃO CADASTRADO"
                cmbUnidades.SelectedValue = 1;
            }


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCOD_TIPO.Text = cmbTipo.SelectedValue.ToString();
        }

        private void cmbUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxCOD_UNIDADE.Text = cmbUnidades.SelectedValue.ToString();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            prods.RecStatus = LibFWGeral.SqlQuery.EditStatus.Consulta;
            DialogResult = DialogResult.Cancel;
            // fecha o form
            this.Close();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            CamposProduto pr = new CamposProduto();
            try
            {
                // transfere para o objeto CamposProduto os dados digitados nos TextBox
                pr.ID_PRODUTO = this.IdProduto;
                pr.COD_PRODUTO = tbxCOD_PRODUTO.Text;
                pr.DESCRICAO = tbxDESCRICAO.Text;
                pr.COD_TIPO = (short)cmbTipo.SelectedValue;
                pr.COD_UNIDADE = (short)cmbUnidades.SelectedValue;
                pr.PRECO_CUSTO = updPRECO_CUSTO.Value;
                pr.PRECO_VENDA = updPRECO_VENDA.Value;

                pr.QTD_MINIMA = (int)updQTD_MINIMA.Value;
                pr.QTD_REAL = (int)updQTD_REAL.Value;

                pr.CLAS_FISC = tbxCLAS_FISC.Text;
                pr.IPI = (int)updIPI.Value;

                // se for alteração
                if (prods.RecStatus == LibFWGeral.SqlQuery.EditStatus.Altera)
                    prods.ExecUpdate(pr);
                else // inclusão
                    this.IdProduto = prods.ExecInsert(pr);

                if (prods.Error == null)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show(prods.Error.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
