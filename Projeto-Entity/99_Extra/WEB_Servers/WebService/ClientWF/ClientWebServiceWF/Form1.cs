using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ClientWebServiceWF
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=NOTEDELL2\NOTEDELL2;Initial Catalog=PEDIDOS;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient servico = new ServiceReference1.Service1SoapClient();
            
            lblResultado.Text = servico.TiraAcento(tbxTexto.Text);

            servico.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1SoapClient servico = new ServiceReference1.Service1SoapClient();

            DataSet tb = new DataSet();
            XmlNode doc = servico.ListaProdutos1("", "");

            XmlReader rd = new XmlNodeReader(doc);

            tb.ReadXml(rd);

            //lblResultado.Text = ;
            dataGridView1.DataSource = tb.Tables[0];
            
            servico.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =

            @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
                                       T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
                                       PR.QTD_MINIMA  
                                FROM PRODUTOS PR 
                                JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
                                JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
                                WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
                                ORDER BY DESCRICAO ";

            cmd.Parameters.AddWithValue("@descricao", "%");
            cmd.Parameters.AddWithValue("@tipo", "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);

                lblResultado.Text = ds.GetXml();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
