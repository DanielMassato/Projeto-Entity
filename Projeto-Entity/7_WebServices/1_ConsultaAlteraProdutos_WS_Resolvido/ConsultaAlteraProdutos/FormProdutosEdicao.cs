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
        // armazena o objeto que gerencia a tabela produtos,
        // será usado em mais de um método porisso foi declarado aqui
        // Produtos prods;
        // ID do produto que está sendo alterado/incluido
        public int IdProduto;

        // o construtor deste form foi alterado de modo a receber
        // o ID do produto e o objeto que gerencia a tabela, já
        // criado em FormProdutos
        public FormProdutosEdicao(int idProduto)
        {
            InitializeComponent();
            // transfere os parâmetros recebidos para as variáveis
            // declaradas fora do método para que sejam visíveis
            // no botão Grava          
            this.IdProduto = idProduto;
            string erro = "";
            // carregar o comboBox de tipos de produto
            cmbTipo.DataSource = FormPrincipal.prods.ListaTipos(ref erro);
            // definir a coluna que será mostrada no comboBox.
            // Para recuperar o texto selecionado no comboBox, use
            // a propriedade SelectedItem
            cmbTipo.DisplayMember = "TIPO";
            // definir o campo retornado pelo comboBox. 
            // Para recuperar este campo do item selecionado use a 
            // propriedade SelectedValue
            cmbTipo.ValueMember = "COD_TIPO";

            cmbUnidades.DataSource = FormPrincipal.prods.ListaUnidades(ref erro);
            cmbUnidades.DisplayMember = "UNIDADE";
            cmbUnidades.ValueMember = "COD_UNIDADE";


            if (FormPrincipal.RecStatus == FormPrincipal.EditStatus.Altera)
            {
                Text = "Alterando dados do Produto";
                // ler todos os campos do produto selecionado no grid
                ServiceProdutos.PRODUTOS pr = FormPrincipal.prods.FichaProduto(idProduto, ref erro);
                // mostrar os dados nos componentes do form
                // mostrar os dados na tela
                tbxCOD_PRODUTO.Text = pr.COD_PRODUTO;
                tbxDESCRICAO.Text = pr.DESCRICAO;
                tbxCOD_TIPO.Text = pr.COD_TIPO.ToString();
                tbxCOD_UNIDADE.Text = pr.COD_UNIDADE.ToString();

                updPRECO_CUSTO.Value = pr.PRECO_CUSTO.Value;
                updPRECO_VENDA.Value = pr.PRECO_VENDA.Value;
                updQTD_MINIMA.Value = pr.QTD_MINIMA.Value;
                updQTD_REAL.Value = pr.QTD_REAL.Value;
                tbxCLAS_FISC.Text = pr.CLAS_FISC;
                updIPI.Value = pr.IPI.Value;

                cmbTipo.SelectedValue = pr.COD_TIPO;
                cmbUnidades.SelectedValue = pr.COD_UNIDADE;
            }
            else
            {
                Text = "Incluindo novo produto";
                // seleciona o item com descrição "NAO CADASTRADO"
                cmbTipo.SelectedValue = (short)0;
                cmbUnidades.SelectedValue = (short)1;
            }

        }
        // EXECUTADO sempre que trocar de item no comboBox
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

        private void btnCancela_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnGrava_Click(object sender, EventArgs e)
        {
            ServiceProdutos.PRODUTOS pr = new ServiceProdutos.PRODUTOS();
            string erro = "";
            try
            {
                // transfere para o objeto Produto os dados digitados nos TextBox
                pr.ID_PRODUTO = this.IdProduto;
                pr.COD_PRODUTO = tbxCOD_PRODUTO.Text;
                pr.DESCRICAO = tbxDESCRICAO.Text;
                pr.COD_TIPO = Convert.ToInt16(cmbTipo.SelectedValue);
                pr.COD_UNIDADE = Convert.ToInt16(cmbUnidades.SelectedValue);
                pr.PRECO_CUSTO = updPRECO_CUSTO.Value;
                pr.PRECO_VENDA = updPRECO_VENDA.Value;

                pr.QTD_MINIMA = Convert.ToInt32(updQTD_MINIMA.Value);
                pr.QTD_REAL = Convert.ToInt32(updQTD_REAL.Value);

                pr.CLAS_FISC = tbxCLAS_FISC.Text;
                pr.IPI = Convert.ToInt32(updIPI.Value);

                // se for alteração
                if (FormPrincipal.RecStatus == FormPrincipal.EditStatus.Altera)
                    FormPrincipal.prods.AlterProduto(pr, ref erro);
                else // é inclusão
                    IdProduto = FormPrincipal.prods.InsereProduto(pr, ref erro);

                if (erro != "")
                    MessageBox.Show(erro);
                else
                    Close();

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

    }
}
