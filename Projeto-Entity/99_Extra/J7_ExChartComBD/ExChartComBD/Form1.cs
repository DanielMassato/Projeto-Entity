using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExChartComBD
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=NOTEDELL2\NOTEDELL2;Initial Catalog=PEDIDOS;Integrated Security=True");
        DataTable tbVendas = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT MONTH(DATA_EMISSAO) AS MES,
                         YEAR(DATA_EMISSAO) AS ANO,
                         SUM(VLR_TOTAL) AS TOT_VENDIDO
                  FROM PEDIDOS
                  WHERE YEAR(DATA_EMISSAO) = @ano
                  GROUP BY  MONTH(DATA_EMISSAO), YEAR(DATA_EMISSAO)
                  ORDER BY MES";

            cmd.Parameters.AddWithValue("@ano", updAno.Value);
            
            tbVendas.Clear();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tbVendas);

            dgvVendas.DataSource = tbVendas;

            MontaGrafico();
        }

        private void MontaGrafico()
        {
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Titles.Clear();
            chart1.Titles.Add("Vendas do Ano de " + updAno.Value);
            chart1.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.Blue;
            chart1.Series.Clear();
            chart1.Series.Add("R$");

            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Minimum = 1;
            chart1.ChartAreas[0].AxisX.Maximum = 12;

            chart1.ChartAreas[0].AxisX.Title = "Mês";
            chart1.ChartAreas[0].AxisY.Title = "Tot. Vendido R$ x 1000";
            chart1.ChartAreas[0].AxisX.LineWidth = 2;

           // chart1.ChartAreas[0].AxisY.Maximum = 500;

            for (int i = 0; i < tbVendas.Rows.Count; i++)
            {
                chart1.Series[0].Points.Add(new DataPoint(i+1, 
                    Convert.ToDouble(tbVendas.Rows[i]["TOT_VENDIDO"])/1000));
            }
        }

        private void updAno_ValueChanged(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();
        }
    }
}
