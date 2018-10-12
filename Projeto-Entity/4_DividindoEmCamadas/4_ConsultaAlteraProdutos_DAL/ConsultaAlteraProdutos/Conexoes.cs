using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// adicione os seguintes namespaces
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ConsultaAlteraProdutos
{
    static class Conexoes
    {
        /*
         * quando for usar:
         * 
         *  SqlConnection con = new SqlConnection(Conexoes.SqlConnectionString);
         */
        /// <summary>
        /// String de conexão Sql
        /// </summary>
        public static string SqlConnectionString =
            ConfigurationManager.ConnectionStrings["conSql"].ConnectionString;
        /*
         * quando for usar:
         * 
         * Sqlconnection con = Conexoes.GetSqlConnection();
         */
        /// <summary>
        /// Retorna com um objeto SqlConnection
        /// </summary>
        /// <returns>Objeto SqlConnection</returns>
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(SqlConnectionString);
        }

    
    }
}
