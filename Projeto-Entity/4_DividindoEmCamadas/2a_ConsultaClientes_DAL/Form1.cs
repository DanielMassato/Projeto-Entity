using LibPedidosDAL;
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
        //SqlConnection conn = Conexoes.GetSqlConnection();
        //DataTable tbClientes = new DataTable();

        Clientes cli = new Clientes(Conexoes.GetSqlConnection());

        BindingSource bsClientes = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

     
        private void btnFiltra_Click(object sender, EventArgs e)
        {
            if (cli.ConsultaGrid(tbxNome.Text, tbxCidade.Text,
                  tbxUF.Text) >= 0)
            {
                bsClientes.DataSource = cli.Table;
                dgvClientes.DataSource = bsClientes;
            }
            else MessageBox.Show(cli.Error.Message);

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

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            // 5. Substituir este método Locate (antigo) pelo que está dentro da classe Clientes
            if (! cli.Locate("NOME", tbxProcura.Text, bsClientes))
            {
                Console.Beep(200, 100);
                // MOX
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }


      

    }
}
