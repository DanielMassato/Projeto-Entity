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
            2.1. SqlConnection
            2.2. DataTable
            2.3. BindingSource

        4. Concluir o botão filtra, fazendo o SELECT funcionar
           e ser exibido no DataGridView
            4.1. Os componentes NumericUpDown (filtro por salario) possuem
                 propriedade Value para recuperarmos o valor contido neles
 
            4.2. Os componentes DateTimePicker (filtro por Data) possuem
                 propriedade Value para recuperarmos o valor contido neles
         
            4.3. Só concatenamos o parâmetro com "%" quando o campo é
                 string (char, varchar) e o SELECT utiliza o operador
                 LIKE na condição

        5. Fazer os eventos Click dos botões de movimentação

        6. Criar método Locate para fazer pesquisa incremental

        7. Evento TextChanged de tbxProcura para concluir
           a pesquisa incremental
 
        */

        SqlConnection conn = Conexoes.GetSqlConnection();
        DataTable tbEmp = new DataTable();
        BindingSource bsEmp = new BindingSource();

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            // definir o comando
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

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            tbEmp.Clear();
            try
            {
                da.Fill(tbEmp);

                bsEmp.DataSource = tbEmp;
                dgvEmpregados.DataSource = bsEmp;
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
            // dtpData1.Value = DateTime.Now.AddDays(-30);
            dtpData2.Value = DateTime.Now;

            btnFiltra.PerformClick();

          
        }

        

        private void tbtnPrimeiro_Click(object sender, EventArgs e)
        {
            bsEmp.MoveFirst();
        }

        private void tbtnAnterior_Click(object sender, EventArgs e)
        {
            bsEmp.MovePrevious();
        }

        private void tbtnProximo_Click(object sender, EventArgs e)
        {
            bsEmp.MoveNext();
        }

        private void tbtnUltimo_Click(object sender, EventArgs e)
        {
            bsEmp.MoveLast();
        }

        bool Locate(string nomeCampo, string valor)
        {
            // posição onde o dado foi encontrado dentro
            // do DataTable
            int pos = -1;
            // filtrar o DataTable 
            DataRow[] linhas = tbEmp.Select(
                nomeCampo + " LIKE '" +
                valor.Replace("'", "''") + "%'");

            if (linhas.Length > 0)
            {
                // descobre a posição onde está esse nome
                // dentro do DataTable
                pos = bsEmp.Find(nomeCampo,
                                   linhas[0][nomeCampo]);
                // posicionar na linha correspondente
                bsEmp.Position = pos;
            }

            return pos >= 0;
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            if (!Locate("NOME", tbxProcura.Text))
            {
                Console.Beep(500, 100);
                // FEX
                tbxProcura.SelectionStart--;
                tbxProcura.SelectionLength = 1;
            }
        }
    }
}
