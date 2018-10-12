using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaClientes
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

      /*

      1. Criar App.config definindo o string de conexão

      2. Criar a classe Conexoes contendo
          2.1. propriedade ConnectionString
          2.2. método GetSqlConnection

      3. No form, declarar 3 variáveis para toda o form
          3.1. SqlConnection
          3.2. DataTable
          3.3. BindingSource

      4. Concluir o botão filtra, fazendo o SELECT funcionar e ser exibido no DataGridView
    
      5. Fazer os eventos Click dos botões de movimentação

      6. Criar método Locate para fazer pesquisa incremental

      7. Evento TextChanged de tbxProcura para concluir a pesquisa incremental
 
      */

        private void btnFiltra_Click(object sender, EventArgs e)
        {
//            @"SELECT CODCLI,NOME,ENDERECO,BAIRRO,CIDADE,ESTADO,CEP, 
//                     FONE1,FAX,E_MAIL,CNPJ,INSCRICAO 
//            FROM CLIENTES 
//            WHERE NOME LIKE ? AND CIDADE LIKE ? AND ESTADO LIKE ? 
//            ORDER BY NOME";
        }

      

      

    }
}
