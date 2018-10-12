using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;

namespace ConsultaAlteraPedidos
{
    static class Conexoes
    {
        public static SqlConnection ConexaoSql()
        {
            string connSQL = ConfigurationManager.ConnectionStrings["conexaoSQL"].ConnectionString;
            return new SqlConnection(connSQL);
        }

        public static OleDbConnection ConexaoOle()
        {
            string connOleDb = ConfigurationManager.ConnectionStrings["conexaoOleDb"].ConnectionString;
            return new OleDbConnection(connOleDb);
        }

    }
}
