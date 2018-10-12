using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace WebServiceServer
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string TiraAcento(string texto)
        {
            string result = "";
            string acentos = "ÁÀÂÃáàâãÉÈÊËéèêëÍÌÎÏíìîïÓÒÔÕÖóòôõöÚÙÛÜúùûüçÇ";
            string semAcentos = "AAAAaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUUuuuucC";
            for (int i = 0; i < texto.Length; i++)
            {
                int pos = acentos.IndexOf(texto[i]);
                if (pos >= 0) result += semAcentos[pos];
                else result += texto[i];
            }
            return result;
        }

        [WebMethod]
        public XmlDocument ListaProdutos1(string descr, string tipo)
        {
            SqlCommand cmd = Conexoes.GetSqlConnection().CreateCommand();
            cmd.CommandText = @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
                                       T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
                                       PR.QTD_MINIMA  
                                FROM PRODUTOS PR 
                                JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                                JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
                                WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
                                ORDER BY DESCRICAO ";

            cmd.Parameters.AddWithValue("@descricao", "%" + descr + "%");
            cmd.Parameters.AddWithValue("@tipo", tipo + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(ds.GetXml());
                return doc;
            }
            catch (Exception ex)
            {
               throw new Exception(ex.Message);               
            }
        }

        [WebMethod]
        public int ListaProdutos2(string descr, string tipo, DataTable tb)
        {
            SqlCommand cmd = Conexoes.GetSqlConnection().CreateCommand();
            cmd.CommandText =

            @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
                                       T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
                                       PR.QTD_MINIMA  
                                FROM PRODUTOS PR 
                                JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                                JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
                                WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
                                ORDER BY DESCRICAO ";

            cmd.Parameters.AddWithValue("@descricao", "%" + descr + "%");
            cmd.Parameters.AddWithValue("@tipo", tipo + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            try
            {
                da.Fill(tb);

                return tb.Rows.Count;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}