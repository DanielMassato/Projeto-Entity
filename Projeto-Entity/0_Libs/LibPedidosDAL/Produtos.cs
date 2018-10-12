using LibFWGeral;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPedidosDAL
{

    public class CamposProduto
    {
        private int _ID_PRODUTO;

        public int ID_PRODUTO
        {
            get { return _ID_PRODUTO; }
            set { _ID_PRODUTO = value; }
        }

        private string _COD_PRODUTO;

        public string COD_PRODUTO
        {
            get { return _COD_PRODUTO; }
            set
            {
                if (value != "") _COD_PRODUTO = value;
                else throw new Exception("Código não pode ficar vazio");
            }
        }

        private string _DESCRICAO;

        public string DESCRICAO
        {
            get { return _DESCRICAO; }
            set
            {
                if (value != "") _DESCRICAO = value;
                else throw new Exception("Descrição não pode ficar vazia");
            }
        }

        private short _COD_UNIDADE;

        public short COD_UNIDADE
        {
            get { return _COD_UNIDADE; }
            set
            {
                if (value >= 0) _COD_UNIDADE = value;
                else throw new Exception("Código de unidade não pode ser negativo");
            }
        }

        private short _COD_TIPO;

        public short COD_TIPO
        {
            get { return _COD_TIPO; }
            set
            {
                if (value >= 0) _COD_TIPO = value;
                else throw new Exception("Código do tipo não pode ser negativo");
            }
        }

        private decimal _PRECO_CUSTO;

        public decimal PRECO_CUSTO
        {
            get { return _PRECO_CUSTO; }
            set
            {
                if (value >= 0) _PRECO_CUSTO = value;
                else throw new Exception("Preço não pode ser negativo");
            }
        }

        private decimal _PRECO_VENDA;

        public decimal PRECO_VENDA
        {
            get { return _PRECO_VENDA; }
            set
            {
                if (value >= 0) _PRECO_VENDA = value;
                else throw new Exception("Preço não pode ser negativo");
            }
        }

        private int _QTD_REAL;

        public int QTD_REAL
        {
            get { return _QTD_REAL; }
            set { _QTD_REAL = value; }
        }

        private int _QTD_MINIMA;

        public int QTD_MINIMA
        {
            get { return _QTD_MINIMA; }
            set { _QTD_MINIMA = value; }
        }

        private string _CLAS_FISC;

        public string CLAS_FISC
        {
            get { return _CLAS_FISC; }
            set { _CLAS_FISC = value; }
        }

        private int _IPI;

        public int IPI
        {
            get { return _IPI; }
            set { _IPI = value; }
        }

        private decimal _PESO_LIQ;

        public decimal PESO_LIQ
        {
            get { return _PESO_LIQ; }
            set { _PESO_LIQ = value; }
        }
    }


    public class Produtos: SqlQuery
    {
        #region Construtores
        // Padrão: sem parâmetros
        public Produtos () { }
        // alternativo: recebe a conexão como parâmetro
        public Produtos(SqlConnection conn):base(conn)
        { }
        #endregion

        #region Métodos

        public int ConsultaGrid(string descricao, string tipo)
        {
            Command.CommandText =
                 @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
                                 T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
                                 PR.QTD_MINIMA  
                          FROM PRODUTOS PR 
                               JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                               JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
                          WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
                          ORDER BY DESCRICAO ";

            Command.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
            Command.Parameters.AddWithValue("@tipo", tipo + "%");

            return Fill();
        }

        public int ReajustaPrecos(string descricao, string tipo,
                                  decimal porc)
        {
            Command.CommandText =
                 @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                      FROM PRODUTOS PR 
                           JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                      WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo ";

            Command.Parameters.AddWithValue("@fator", 1 + porc / 100);
            Command.Parameters.AddWithValue("@descricao", "%" + descricao + "%");
            Command.Parameters.AddWithValue("@tipo", tipo + "%");

            return ExecSql();
        }

        public int ReajustaPrecos(string ids, decimal porc)
        {
            Command.CommandText = 
                @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
                  WHERE ID_PRODUTO IN (" + ids + ")";

            Command.Parameters.AddWithValue("@fator", 1 + porc / 100);

            return ExecSql();
        }

        public DataTable TiposProduto()
        {
            SqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM TIPOPRODUTO
                                ORDER BY TIPO";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataTable UnidadesMedida()
        {
            SqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM UNIDADES
                                ORDER BY UNIDADE";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public CamposProduto FichaProduto(int idProduto)
        {
            SqlCommand cmd = Connection.CreateCommand();
            cmd.CommandText = @"SELECT * FROM PRODUTOS
                                WHERE ID_PRODUTO = " + idProduto;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            int linhas = da.Fill(tb);
            decimal peso = 0;
            // testar se o conteúdo do campo na tabela 
            // não é nulo
            if (! tb.Rows[0].IsNull("PESO_LIQ"))
                peso = (decimal)tb.Rows[0]["PESO_LIQ"];

            if (linhas == 0) return null;
            else
                return new CamposProduto
                {
                    ID_PRODUTO = (int)tb.Rows[0]["ID_PRODUTO"],
                    COD_PRODUTO = tb.Rows[0]["COD_PRODUTO"].ToString(),
                    DESCRICAO = tb.Rows[0]["DESCRICAO"].ToString(),
                    COD_TIPO = (short)tb.Rows[0]["COD_TIPO"],
                    COD_UNIDADE = (short)tb.Rows[0]["COD_UNIDADE"],
                    PRECO_CUSTO = (decimal)tb.Rows[0]["PRECO_CUSTO"],
                    PRECO_VENDA = (decimal)tb.Rows[0]["PRECO_VENDA"],
                    QTD_MINIMA = (int)tb.Rows[0]["QTD_MINIMA"],
                    QTD_REAL = (int)tb.Rows[0]["QTD_REAL"],
                    CLAS_FISC = tb.Rows[0]["CLAS_FISC"].ToString(),
                    IPI = (int)tb.Rows[0]["IPI"],
                    PESO_LIQ = peso
                };
        }

        /// <summary>
        /// Insere um novo produto na tabela PRODUTOS
        /// </summary>
        /// <param name="pr">Conteúdo dos campos</param>
        /// <returns>Novo ID_PRODUTO gerado</returns>
        public int ExecInsert(CamposProduto pr)
        {
            SqlCommand cmd = Connection.CreateCommand();
            // são 12 parâmetros
            cmd.CommandText = @"EXEC SP_PRODUTOS_INSERT @COD_PRODUTO, @DESCRICAO, @COD_UNIDADE, @COD_TIPO, 
                      @PRECO_CUSTO, @PRECO_VENDA, @QTD_ESTIMADA, @QTD_REAL, @QTD_MINIMA, @CLAS_FISC, @IPI, @PESO_LIQ";
            cmd.Parameters.AddWithValue("@COD_PRODUTO", pr.COD_PRODUTO);
            cmd.Parameters.AddWithValue("@DESCRICAO", pr.DESCRICAO);
            cmd.Parameters.AddWithValue("@COD_UNIDADE", pr.COD_UNIDADE);
            cmd.Parameters.AddWithValue("@COD_TIPO", pr.COD_TIPO);
            cmd.Parameters.AddWithValue("@PRECO_CUSTO", pr.PRECO_CUSTO);
            cmd.Parameters.AddWithValue("@PRECO_VENDA", pr.PRECO_VENDA);
            cmd.Parameters.AddWithValue("@QTD_ESTIMADA", 0);
            cmd.Parameters.AddWithValue("@QTD_REAL", pr.QTD_REAL);
            cmd.Parameters.AddWithValue("@QTD_MINIMA", pr.QTD_MINIMA);
            cmd.Parameters.AddWithValue("@CLAS_FISC", pr.CLAS_FISC);
            cmd.Parameters.AddWithValue("@IPI", pr.IPI);
            cmd.Parameters.AddWithValue("@PESO_LIQ", pr.PESO_LIQ);

            bool connected = Connection.State == ConnectionState.Open;
            try
            {
                if (!connected) Connection.Open();
                // lê o retorno da linha
                int id = Convert.ToInt32(cmd.ExecuteScalar());
                // propriedade Error herdada de OleDbQuery
                Error = null;
                return id;
            }
            catch (Exception ex)
            {
                // propriedade Error herdade de OleDbQuery
                Error = ex;
                return -1;
            }
            finally
            {
                if (!connected) Connection.Close();
            }
        }


        public void ExecUpdate(CamposProduto pr)
        {
            SqlCommand cmd = Connection.CreateCommand();
            // são 12 parâmetros
            cmd.CommandText = @"EXEC SP_PRODUTOS_UPDATE @ID_PRODUTO, @COD_PRODUTO, @DESCRICAO, @COD_UNIDADE, @COD_TIPO, 
                      @PRECO_CUSTO, @PRECO_VENDA, @QTD_ESTIMADA, @QTD_REAL, @QTD_MINIMA, @CLAS_FISC, @IPI, @PESO_LIQ";

            cmd.Parameters.AddWithValue("@ID_PRODUTO", pr.ID_PRODUTO);

            cmd.Parameters.AddWithValue("@COD_PRODUTO", pr.COD_PRODUTO);
            cmd.Parameters.AddWithValue("@DESCRICAO", pr.DESCRICAO);
            cmd.Parameters.AddWithValue("@COD_UNIDADE", pr.COD_UNIDADE);
            cmd.Parameters.AddWithValue("@COD_TIPO", pr.COD_TIPO);
            cmd.Parameters.AddWithValue("@PRECO_CUSTO", pr.PRECO_CUSTO);
            cmd.Parameters.AddWithValue("@PRECO_VENDA", pr.PRECO_VENDA);
            cmd.Parameters.AddWithValue("@QTD_ESTIMADA", 0);
            cmd.Parameters.AddWithValue("@QTD_REAL", pr.QTD_REAL);
            cmd.Parameters.AddWithValue("@QTD_MINIMA", pr.QTD_MINIMA);
            cmd.Parameters.AddWithValue("@CLAS_FISC", pr.CLAS_FISC);
            cmd.Parameters.AddWithValue("@IPI", pr.IPI);
            cmd.Parameters.AddWithValue("@PESO_LIQ", pr.PESO_LIQ);

            bool connected = Connection.State == ConnectionState.Open;
            try
            {
                if (!connected) Connection.Open();
                // lê o retorno da linha
                cmd.ExecuteNonQuery();
                // propriedade Error herdada de OleDbQuery
                Error = null;
            }
            catch (Exception ex)
            {
                // propriedade Error herdade de OleDbQuery
                Error = ex;
            }
            finally
            {
                if (!connected) Connection.Close();
            }
        }

        public void ExecDelete(int idProduto)
        {
            SqlCommand cmd = Connection.CreateCommand();
            // são 12 parâmetros
            cmd.CommandText = @"EXEC SP_PRODUTOS_DELETE " + idProduto;

            bool connected = Connection.State == ConnectionState.Open;
            try
            {
                if (!connected) Connection.Open();
                // lê o retorno da linha
                cmd.ExecuteNonQuery();
                // propriedade Error herdada de OleDbQuery
                Error = null;
            }
            catch (Exception ex)
            {
                // propriedade Error herdade de OleDbQuery
                Error = ex;
            }
            finally
            {
                if (!connected) Connection.Close();
            }
        }


        #endregion

    }
}
