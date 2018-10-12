using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace ConsultaAlteraPedidos
{
    public static class DBUtils
    {
        public static string GetStringFieldFromTable(string tableName, string fieldName, string keyField, int keyValue, OleDbConnection conn)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT " + fieldName + " FROM " + tableName +
                              " WHERE " + keyField + " = " + keyValue;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return dr[0].ToString();
            else
                return "";

        }

        public static decimal GetDecimalFieldFromTable(string tableName, string fieldName, string keyField, int keyValue, OleDbConnection conn)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT " + fieldName + " FROM " + tableName +
                              " WHERE " + keyField + " = " + keyValue;
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                return Convert.ToDecimal(dr[0]);
            else
                return -999999999;

        }
    }
}
