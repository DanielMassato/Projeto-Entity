using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebServiceServer
{
    public static class Conexoes
    {
        //2.1
        public static string SqlConnectionString = @"Data Source=NOTEDELL2\NOTEDELL2;Initial Catalog=PEDIDOS;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            //ConfigurationManager.ConnectionStrings["connSql"].ConnectionString;
        //2.2
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(SqlConnectionString);
        }
    }
}