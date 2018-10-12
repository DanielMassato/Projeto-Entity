using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaEmpregados
{
    class Conexoes
    {
        /*
         * SqlConnection conn = new SqlConnection(Conexoes.SqlConnectionString)
         */
        public static string SqlConnectionString =
            ConfigurationManager.ConnectionStrings["conSql"].ConnectionString;

        /*
         * SqlConnection conn = Conexoes.GetSqlConnection()
         */
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(SqlConnectionString);
        }

    }
}
