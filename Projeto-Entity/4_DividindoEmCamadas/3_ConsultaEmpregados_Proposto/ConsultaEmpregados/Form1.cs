using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaEmpregados
{
    public partial class Form1 : Form
    {
        SqlConnection conn = Conexoes.GetSqlConnection();
        DataTable tbEmpregados = new DataTable();
        BindingSource bsEmpregados = new BindingSource();

        
        public Form1()
        {
            InitializeComponent();

        }
        
        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // definir o comando que será executado
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT E.CODFUN, E.NOME, E.DATA_ADMISSAO, 
                         E.SALARIO, D.DEPTO, C.CARGO, E.OBS 
                  FROM EMPREGADOS E 
                       JOIN TABELADEP D ON E.COD_DEPTO = D.COD_DEPTO 
                       JOIN TABELACAR C ON E.COD_CARGO = C.COD_CARGO 
                  WHERE E.NOME LIKE @nome AND D.DEPTO LIKE @departamento  
                  AND C.CARGO LIKE @cargo AND E.SALARIO BETWEEN @salario1 AND @salario2
                  AND E.DATA_ADMISSAO BETWEEN @admissao1 AND @admissao2
                  ORDER BY E.NOME";
            // passar os parâmetros
            cmd.Parameters.AddWithValue("@nome", "%" + tbxNome.Text + "%");
            cmd.Parameters.AddWithValue("@departamento", tbxDepto.Text + "%");
            cmd.Parameters.AddWithValue("@cargo", tbxCargo.Text + "%");
            cmd.Parameters.AddWithValue("@salario1", updSal1.Value);
            cmd.Parameters.AddWithValue("@salario2", updSal2.Value);
            cmd.Parameters.AddWithValue("@admissao1", dtpData1.Value);
            cmd.Parameters.AddWithValue("@admissao2", dtpData2.Value);
            // criar DataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                tbEmpregados.Clear();
                // executar o comando select e armazenar o resultado
                // no DataTable
                da.Fill(tbEmpregados);
                // exibir os dados na tela usando o BindingSource
                bsEmpregados.DataSource = tbEmpregados;
                dgvEmpregados.DataSource = bsEmpregados;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // evento Load do formulário
        private void Form1_Load(object sender, EventArgs e)
        {
            dtpData1.Value = new DateTime(1980,1,1);
            // dtpData1.Value = DateTime.Now.AddDays(-15);
            dtpData2.Value = DateTime.Now;

            btnFiltra.PerformClick();
        }

        private void tbtnPrimeiro_Click(object sender, EventArgs e)
        {
            bsEmpregados.MoveFirst();
        }

        private void tbtnAnterior_Click(object sender, EventArgs e)
        {
            bsEmpregados.MovePrevious();
        }

        private void tbtnProximo_Click(object sender, EventArgs e)
        {
            bsEmpregados.MoveNext();
        }

        private void tbtnUltimo_Click(object sender, EventArgs e)
        {
            bsEmpregados.MoveLast();
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            if (!Locate("NOME", tbxProcura.Text))
            {
                Console.Beep(300, 100);
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }

        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o valor foi encontrado 
            int pos = -1;
            // filtrar os dados contidos no DataTable
            // NOME LIKE 'MO%'
            DataRow[] linhas = tbEmpregados.Select(nomeCampo +
                " LIKE '" + valor.Replace("'","''") + "%'");
            // se encontrol algum dado
            if (linhas.Length > 0)
            {
                // descobrir a posição onde ele está
                pos = bsEmpregados.Find(nomeCampo, linhas[0][nomeCampo]);
                // deslocar o ponteiro para esta posição
                bsEmpregados.Position = pos;
            }
            // retornar true se encontrou (pos >= 0) ou false
            // se não encontrou (pos < 0)
            return pos >= 0;
        }




    }
}
