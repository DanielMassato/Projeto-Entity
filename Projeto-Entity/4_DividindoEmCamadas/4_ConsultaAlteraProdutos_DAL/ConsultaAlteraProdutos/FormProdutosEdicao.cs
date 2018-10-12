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



        }
        

    }
}
