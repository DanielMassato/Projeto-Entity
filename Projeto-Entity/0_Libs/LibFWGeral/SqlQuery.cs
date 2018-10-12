using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibFWGeral
{
    public class SqlQuery
    {
        #region Propriedades

        public enum EditStatus { Consulta, Altera, Inclui, Exclui };

        private EditStatus _recStatus; // Ctrl R + E

        public EditStatus RecStatus
        {
            get { return _recStatus; }
            set { _recStatus = value; }
        }

        private SqlConnection _connection;

        /// <summary>
        /// Estabelece a conexão com o banco de dados
        /// </summary>
        public SqlConnection Connection
        {
            get { return _connection;}
            set
            {
                _connection = value;
                // cria o objeto Command sempre que atribuirmos valor
                // à propriedade Connection
                _command = _connection.CreateCommand();
            }
        }

        private SqlCommand _command;
        /// <summary>
        /// Define e executa instruções SQL
        /// </summary>
        public SqlCommand Command
        {
            get { return _command; }
            set { _command = value;}
        }

        private DataTable _table;
        /// <summary>
        /// Armazena os dados de uma consulta, quando Command armazenar
        /// uma instrução SELECT
        /// </summary>
        public DataTable Table
        {
            get { return _table; }
            set { _table = value; }
        }

        private Exception _error;
        public Exception Error
        {
            get { return _error; }
            set { _error = value; }
        }


        #endregion

        #region Métodos

        /// <summary>
        /// Executa uma instrução SELECT  e armazena os dados
        /// na propriedade Table
        /// </summary>
        /// <param name="clearParams">
        /// Indica se os parâmetros do objeto Command devem
        /// ser apagados após a execução
        /// </param>
        /// <returns>
        /// Quantidade de linhas retornadas pelo SELECT
        /// </returns>
        public int Fill(bool clearParams = true)
        {
            SqlDataAdapter da = new SqlDataAdapter(_command);
            _table.Clear();
            try
            {
                int linhas = da.Fill(_table);
                if (clearParams) _command.Parameters.Clear();
                _error = null;
                return linhas;
            }
            catch (Exception ex)
            {
                _error = ex;
                return -1;
            }
        }

        /// <summary>
        /// Executa instrução que não retorna consulta
        /// </summary>
        /// <param name="clearParams">
        /// Indica se os parâmetros do objeto Command devem
        /// ser apagados após a execução
        /// </param>
        /// <returns>
        /// Quantidade de linhas afetadas pelo comando
        /// </returns>
        public int ExecSql(bool clearParams = true)
        {
            // descobrir o status atual da conexão
            bool connected =
                _connection.State == ConnectionState.Open;
            try
            {
                // se não estiver conectado, conectar
                if (!connected) _connection.Open();
                // executar o comando
                int linhas = _command.ExecuteNonQuery();

                if (clearParams) _command.Parameters.Clear();

                _error = null;
                return linhas;
            }
            catch (Exception ex)
            {
                _error = ex;
                return -1;
            }
            finally
            {
                // se não estava conectado, fechar a conexão
                if (!connected) _connection.Close();
            }
        }

        public bool Locate(string nomeCampo, string valor, BindingSource bs)
        {
            // posição onde o valor foi encontrado 
            int pos = -1;
            // filtrar os dados contidos no DataTable
            // NOME LIKE 'MO%'
            DataRow[] linhas = _table.Select(nomeCampo +
                " LIKE '" + valor.Replace("'", "''") + "%'");
            // se encontrol algum dado
            if (linhas.Length > 0)
            {
                // descobrir a posição onde ele está
                pos = bs.Find(nomeCampo, linhas[0][nomeCampo]);
                // deslocar o ponteiro para esta posição
                bs.Position = pos;
            }
            // retornar true se encontrou (pos >= 0) ou false
            // se não encontrou (pos < 0)
            return pos >= 0;
        }

        #endregion

        #region Construtores

        // padrão: sem parâmetros
        /*
         * SqlQuery qry = new SqlQuery();
         * qry.Connection = Conexoes.GetSqlConnection();
         */
        public SqlQuery()
        {
            _table = new DataTable();
        }

        // alternativo: recebe a conexão como parâmetro
        /*
         * SqlQuery qry = new SqlQuery(Conexoes.GetSqlConnection());         
         */
        public SqlQuery(SqlConnection conn)
        {
            Connection = conn;
            _table = new DataTable();
        }

        #endregion

    }
}
