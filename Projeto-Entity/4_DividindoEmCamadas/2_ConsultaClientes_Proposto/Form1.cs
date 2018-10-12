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
        /*
         *  1. Em LibPedidosDAL, criar classe Clientes
         *     1.1. Criar os dois construtores
         *     1.2. Criar método ConsultaGrid() que recebe os 3 parâmetros de filtro
         *     
         *  2. Substituir SqlConnection e DataTable por um objeto da classe Clientes
         */
        SqlConnection conn = Conexoes.GetSqlConnection();
        DataTable tbClientes = new DataTable();
        BindingSource bsClientes = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // 3. Substituir esse código por uma chamada ao método ConsultaGrid

            // definir o comando que será executado
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                    @"SELECT CODCLI,NOME,ENDERECO,BAIRRO,CIDADE,ESTADO,CEP, 
                             FONE1,FAX,E_MAIL,CNPJ,INSCRICAO 
                    FROM CLIENTES 
                    WHERE NOME LIKE @nome AND CIDADE LIKE @cidade 
                          AND ESTADO LIKE @estado 
                    ORDER BY NOME";
            // passar os parâmetros
            cmd.Parameters.AddWithValue("@nome", "%" + tbxNome.Text + "%");
            cmd.Parameters.AddWithValue("@cidade", "%" + tbxCidade.Text + "%");
            cmd.Parameters.AddWithValue("@estado", tbxUF.Text + "%");
            // criar DataAdapter para executar o SELECT
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                // limpar as linhas do DataTable
                tbClientes.Clear();
                // executar o SELECT e colocar os dados no DataTable
                da.Fill(tbClientes);
                // Transferir os dados do DataTable para o BindingSource
                bsClientes.DataSource = tbClientes;
                // Transferir os dados do BindingSource para o grid (dgvClientes)
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

        // 4. Eliminar este método Locate
        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o valor foi encontrado 
            int pos = -1;
            // filtrar os dados contidos no DataTable
            // NOME LIKE 'MO%'
            DataRow[] linhas = tbClientes.Select(nomeCampo +
                " LIKE '" + valor.Replace("'","''") + "%'");
            // se encontrol algum dado
            if (linhas.Length > 0)
            {
                // descobrir a posição onde ele está
                pos = bsClientes.Find(nomeCampo, linhas[0][nomeCampo]);
                // deslocar o ponteiro para esta posição
                bsClientes.Position = pos;
            }
            // retornar true se encontrou (pos >= 0) ou false
            // se não encontrou (pos < 0)
            return pos >= 0;
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            // 5. Substituir este método Locate (antigo) pelo que está dentro da classe Clientes
            if (!Locate("NOME", tbxProcura.Text))
            {
                Console.Beep(200, 100);
                // MOX
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }


      

    }
}
