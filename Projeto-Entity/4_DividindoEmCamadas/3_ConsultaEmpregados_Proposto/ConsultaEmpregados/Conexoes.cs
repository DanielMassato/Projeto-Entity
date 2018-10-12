using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace ConsultaEmpregados
{
    class Conexoes
    {
       

        public static string SqlConnectionString =
            ConfigurationManager.ConnectionStrings["conSql"].ConnectionString;

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(SqlConnectionString);
        }



    }
}
