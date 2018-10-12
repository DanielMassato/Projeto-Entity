using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        SqlConnection conn = Conexoes.GetSqlConnection();
        DataTable tbClientes = new DataTable();
        BindingSource bsClientes = new BindingSource();

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // 1. definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT CODCLI,NOME,ENDERECO,BAIRRO,CIDADE,ESTADO,CEP, 
                         FONE1,FAX,E_MAIL,CNPJ,INSCRICAO 
                FROM CLIENTES 
                WHERE NOME LIKE @nome AND CIDADE LIKE @cidade
                      AND ESTADO LIKE @uf 
                ORDER BY NOME";
            // 2. Passar os parâmetros (3 nesse caso)
            cmd.Parameters.AddWithValue("@nome",
                                "%" + tbxNome.Text + "%");
            cmd.Parameters.AddWithValue("@cidade",
                                "%" + tbxCidade.Text + "%");
            cmd.Parameters.AddWithValue("@uf",
                                tbxUF.Text + "%");
            // 3. criar DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // 4. limpar as linhas do DataTable
            tbClientes.Clear();
            try
            {
                da.Fill(tbClientes);

                bsClientes.DataSource = tbClientes;
                dgvClientes.DataSource = bsClientes;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();
        }

        private void tbtnPrimeiro_Click(object sender, EventArgs e)
        {
            bsClientes.MoveFirst();
        }

        private void tbtnAnterior_Click(object sender, EventArgs e)
        {
            bsClientes.MovePrevious();
        }

        private void tbtnProximo_Click(object sender, EventArgs e)
        {
            bsClientes.MoveNext();
        }

        private void tbtnUltimo_Click(object sender, EventArgs e)
        {
            bsClientes.MoveLast();
        }

        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o dado foi encontrado dentro
            // do DataTable
            int pos = -1;
            // filtrar o DataTable 
            DataRow[] linhas = tbClientes.Select(
                nomeCampo + " LIKE '" + 
                valor.Replace("'","''") + "%'");

            if (linhas.Length > 0)
            {
                // descobre a posição onde está esse nome
                // dentro do DataTable
                pos = bsClientes.Find(nomeCampo,
                                   linhas[0][nomeCampo]);
                // posicionar na linha correspondente
                bsClientes.Position = pos;
            }

            return pos >= 0;
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            if (! Locate("NOME", tbxProcura.Text))
            {
                Console.Beep(500, 100);
                // FEX
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }
    }
}
