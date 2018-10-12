using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace ExecutaSQL
{
    public partial class Form1 : Form
    {
        // estabelece a conexão com o banco de dados
        SqlConnection conn = Conexoes.GetSqlConnection();

            // new SqlConnection(@"Data Source=2P32_INSTRUTOR\SQLEXPRESS;Initial Catalog=PEDIDOS;Integrated Security=True");
        
        // armazena os dados da consulta
        DataTable tbSelect = new DataTable();
        // controla posição de registro e navegação
        BindingSource bsSelect = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecSQL_Click(object sender, EventArgs e)
        {
            // cria um objeto Command já associado ao Connection
            SqlCommand cmd = conn.CreateCommand();
            // OU
            /*
             * SqlCommand cmd = new SqlCommand();
             * cmd.Connection = conn;
             * 
             */
            // se tiver texto selecionado no TextBox
            if (tbxSQL.SelectionLength > 0)
                // o comando será o texto selecionado
                cmd.CommandText = tbxSQL.SelectedText;
            else
                // o comando será todo o texto
                cmd.CommandText = tbxSQL.Text;
            try
            {
                int linhas;
                // se for comando SELECT
                if (cmd.CommandText.Trim().ToUpper().StartsWith("SELECT"))
                {
                    // DataAdapter para executar o SELECT
                    // ele precisa de um comando SELECT para poder funcionar
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    // apagar as linhas e colunas do DataTable
                    tbSelect.Rows.Clear();
                    tbSelect.Columns.Clear();
                    // executar o SELECT  e colocar os dados no DataTable
                    linhas = da.Fill(tbSelect);
                    // BindingSource recebe os dados do DataTable
                    bsSelect.DataSource = tbSelect;
                    // controles na tela recebem os dados do BindingSource
                    dgvSelect.DataSource = bsSelect;
                    // selecionar a segunda página do TabControl
                    tabControl1.SelectedIndex = 1;
                }
                else // não é SELECT
                {
                    // abrir a conexão
                    conn.Open();
                    // executar comando que não retorna DataSet
                    linhas = cmd.ExecuteNonQuery();
                }
                // mostrar a quantidade de linhas afetadas
                lblStatus.Text = linhas.ToString() + " linhas afetadas";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void tsbPrimeiro_Click(object sender, EventArgs e)
        {
            bsSelect.MoveFirst();
        }

        private void tsbAnterior_Click(object sender, EventArgs e)
        {
            bsSelect.MovePrevious();
        }

        private void tsbProximo_Click(object sender, EventArgs e)
        {
            bsSelect.MoveNext();
        }

        private void tsbUltimo_Click(object sender, EventArgs e)
        {
            bsSelect.MoveLast();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // seleciona o primeiro item do comboBox
            cmbOrdem.SelectedIndex = 0;

            // definir o comando que será executado
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT NAME  FROM SYSOBJECTS 
                                WHERE XTYPE = 'U' AND name NOT LIKE 'SYS%'
                                ORDER BY NAME";
            try
            {
                // abrir a conexão
                conn.Open();
                // executar o SELECT e recuperar objeto para
                // fazer a leitura dos dados
                SqlDataReader dr = cmd.ExecuteReader();
                // loop para ler as linhas do SELECT
                // o método Read() lê a linha atual, avança para
                // a próxima e devolve true se avançou ou
                // false se não existirem mais linhas
                while (dr.Read())
                {
                    lbxTabelas.Items.Add(dr[0]);
                    // OU
                    // lbxTabelas.Items.Add(dr["NAME"]);
                }
                //fechar o DataReader
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void lbxTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tableName = lbxTabelas.SelectedItem.ToString();

            mostraCampos(tableName);
            mostraIndices(tableName);
            mostraDados(tableName);
        }

        void mostraCampos(string tableName)
        {
            // 1. definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT C.COLID, C.NAME AS COLUNAS, 
                                DT.NAME AS TIPO, C.length AS BYTES, C.xprec AS PRECISAO, 
                                C.xscale AS DECIMAIS 
                                FROM SYSOBJECTS T JOIN SYSCOLUMNS C ON T.id = C.id 
                                JOIN SYSTYPES DT ON C.xtype = DT.xtype
                                WHERE T.XTYPE = 'U' AND T.name = @tabela 
                                ORDER BY C.COLID;";
            // 2. passar o parâmetro
            cmd.Parameters.AddWithValue("@tabela", tableName);
            // 3. Criar DataTable para armazenar o resultado
            DataTable tb = new DataTable();
            // 4. Criar DataAdapter para executar o SELECT
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                // executar o SELECT
                da.Fill(tb);
                // mostrar na tela
                dgvCampos.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        void mostraIndices(string tableName)
        {
            // 1. definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT IX.NAME AS NOME_INDICE, C.name AS CAMPO, IX.type_desc
                                FROM SYS.INDEXES IX
	                            JOIN SYSOBJECTS TABELA ON IX.OBJECT_ID = TABELA.ID 
	                            JOIN sys.index_columns IC ON IC.object_id = IX.object_id AND IC.index_id = IX.index_id
	                            JOIN SYSCOLUMNS C ON C.id = IC.object_id AND IC.column_id = C.colid
                                WHERE TABELA.name = @tabela";
            // 2. passar o parâmetro
            cmd.Parameters.AddWithValue("@tabela", tableName);
            // 3. Criar DataTable para armazenar o resultado
            DataTable tb = new DataTable();
            // 4. Criar DataAdapter para executar o SELECT
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                // executar o SELECT
                da.Fill(tb);
                // mostrar na tela
                dgvIndices.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void mostraDados(string tableName)
        {
            // 1. definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM " + tableName;
            // 2. Criar DataTable para armazenar o resultado
            DataTable tb = new DataTable();
            // 3. Criar DataAdapter para executar o SELECT
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                // executar o SELECT
                da.Fill(tb);
                // mostrar na tela
                dgvDados.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPelaAplicacao_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = conn.CreateCommand();
            SqlCommand cmd2 = conn.CreateCommand();
            SqlCommand cmd3 = conn.CreateCommand();

            // copia o cabeçalho do pedido
            cmd1.CommandText = @"INSERT INTO PEDIDOS (CODCLI, CODVEN, DATA_EMISSAO, VLR_TOTAL, SITUACAO, OBSERVACOES)
	                     SELECT CODCLI, CODVEN, GETDATE(), VLR_TOTAL, 'P', OBSERVACOES
	                     FROM PEDIDOS
	                     WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE;
                         SELECT SCOPE_IDENTITY()";

            // descobrir o NUM_PEDIDO gerado para o novo pedido
            // cmd2.CommandText = "SELECT @@IDENTITY";

            // copia os itens do pedido
            cmd3.CommandText = @"INSERT INTO ITENSPEDIDO (NUM_PEDIDO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, DATA_ENTREGA, SITUACAO, DESCONTO)
	                     SELECT @NUM_PEDIDO_NOVO, NUM_ITEM, ID_PRODUTO, COD_PRODUTO, CODCOR, QUANTIDADE, PR_UNITARIO, GETDATE()+10, SITUACAO, DESCONTO 
	                     FROM ITENSPEDIDO
	                     WHERE NUM_PEDIDO = @NUM_PEDIDO_FONTE;";

            SqlTransaction tran = null;
            try
            {
                conn.Open();
                // abrir processo de transação
                tran = conn.BeginTransaction();
                // associar os Commands à transação
                cmd1.Transaction = tran;
                cmd2.Transaction = tran;
                cmd3.Transaction = tran;

                // executar a cópia do cabeçalho do pedido
                cmd1.Parameters.AddWithValue("@NUM_PEDIDO_FONTE",
                                              updNumPed.Value);
                //cmd1.ExecuteNonQuery();

                int novoPed = Convert.ToInt32(cmd1.ExecuteScalar());

                // descobrir o NUM_PEDIDO gerado
                // ExecuteScalar() devolve o conteúdo da primeira
                // coluna da primeira linha do SELECT
                // int novoPed = Convert.ToInt32(cmd2.ExecuteScalar());
                // copiar os itens do pedido
                cmd3.Parameters.AddWithValue("@NUM_PEDIDO_FONTE",
                                              updNumPed.Value);
                cmd3.Parameters.AddWithValue("@NUM_PEDIDO_NOVO",
                                              novoPed);
                cmd3.ExecuteNonQuery();
                // finalizar transação gravando
                tran.Commit();
                // exibir resultado na tela
                lblResposta.Text = "Gerado pedido número " + novoPed;
            }
            catch (Exception ex)
            {
                // finalizar transação descartando alterações
                tran.Rollback();
                // exibir resultado na tela
                lblResposta.Text = "ERRO: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExecReader_Click(object sender, EventArgs e)
        {
            // definir o comando
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "EXEC STP_COPIA_PEDIDO " +
                                            updNumPed.Value;
            try
            {
                // abrir a conexão
                conn.Open();
                // executar o comando e recuperar o leitor de dados
                SqlDataReader dr = cmd.ExecuteReader();
                // como retorna apenas 1 linha de dados,
                // não precisa loop
                dr.Read();
                // ler os dados desta linha
                int numPed = Convert.ToInt32(dr[0]);
                string msg = dr[1].ToString();

                if (numPed < 0)
                    lblResposta.Text = "ERRO: " + msg;
                else
                    lblResposta.Text = "Gerado pedido num " +
                                                numPed;

                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnExecParam_Click(object sender, EventArgs e)
        {
            // definir o comando
            SqlCommand cmd = conn.CreateCommand();
            // quando a procedure retorna parâmetros de OUTPUT, não
            // podemos colocar o comando EXEC em commandText...
            cmd.CommandType = CommandType. StoredProcedure;
            cmd.CommandText = "STP_COPIA_PEDIDO_P";
            // os parâmetros de input e output são passados separadamente
            // parâmetro de INPUT vai ser passado com o seu valor
            cmd.Parameters.AddWithValue("@NUM_PEDIDO_FONTE", updNumPed.Value);
            // parâmetros de output só terão valor após a execução da procedure
            cmd.Parameters.Add("@NUM_PEDIDO_NOVO", SqlDbType.Int);
            cmd.Parameters["@NUM_PEDIDO_NOVO"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@MSG", SqlDbType.VarChar, 1000);
            cmd.Parameters["@MSG"].Direction = ParameterDirection.Output;

            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
            cmd.Parameters["@RETURN_VALUE"].Direction = ParameterDirection.ReturnValue;
            try
            {
                // abrir a conexão
                conn.Open();
                // executar o comando (não devolve registros)
                cmd.ExecuteNonQuery();
                // ler os parâmetros de output
                int numPed = (int)cmd.Parameters["@NUM_PEDIDO_NOVO"].Value;
                string msg = cmd.Parameters["@MSG"].Value.ToString();
                int ret = (int)cmd.Parameters["@RETURN_VALUE"].Value;

                if (ret != 0) lblResposta.Text = "Erro: " + msg;
                else lblResposta.Text = "Gerado pedido " + numPed;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnExecView_Click(object sender, EventArgs e)
        {
            // VIEW é executada com SELECT. Podemos incluir 
            // ORDER BY, WHERE etc... mas não podemos passar
            // parâmetro
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM VIE_TOTAL_VENDIDO 
                                ORDER BY " + cmbOrdem.Text;

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(tb);
                dgvProc.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                
        }

        private void btnExecProc_Click(object sender, EventArgs e)
        {
            // PROCEDURE é executada com EXEC. NÃO Podemos incluir 
            // ORDER BY, WHERE etc... mas PODEMOS passar
            // parâmetro
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"EXEC STP_TOTAL_VENDIDO " +
                                updAno.Value;

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(tb);
                dgvProc.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFuncTabular_Click(object sender, EventArgs e)
        {
            // FUNÇÃO TABULAR é executada com SELECT. 
            // Podemos incluir ORDER BY, WHERE etc... 
            // E PODEMOS passar parâmetro
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = 
                @"SELECT * FROM FN_TOTAL_VENDIDO(@ano)
                  ORDER BY " + cmbOrdem.Text;

            cmd.Parameters.AddWithValue("@ano", updAno.Value);

            DataTable tb = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(tb);
                dgvProc.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
