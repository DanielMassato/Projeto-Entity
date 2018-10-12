using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraGraf1_Click(object sender, EventArgs e)
        {
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Titles.Add("Gráficos Trigonometria");
            chart1.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);
            chart1.Titles[0].ForeColor = Color.Blue;
            chart1.Series.Clear();
            chart1.Series.Add("Seno");
            chart1.Series.Add("Coseno");

            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 360;
            chart1.ChartAreas[0].AxisX.Interval = 20;

            chart1.ChartAreas[0].AxisY.Minimum = -1;
            chart1.ChartAreas[0].AxisY.Maximum = 1;

            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[1].ChartType = SeriesChartType.Line;

            chart1.Series[0].Color = Color.Red;
            chart1.Series[1].Color = Color.Blue;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;


            chart1.Legends[0].Docking = Docking.Bottom;

            dgv.Columns.Clear();
            dgv.Rows.Clear();
            dgv.ColumnCount = 3;
            dgv.Columns[0].HeaderText = "Ângulo";
            dgv.Columns[0].Width = 50;
            dgv.Columns[1].HeaderText = "Seno";
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].HeaderText = "Coseno";
            dgv.Columns[2].Width = 50;
            for (int a = 0; a <= 360; a++)
            {
                double seno =  Math.Sin(2 * Math.PI * a / 360);
                double coseno = Math.Cos(2 * Math.PI * a / 360);
                chart1.Series[0].Points.Add(new DataPoint(a,seno));
                chart1.Series[1].Points.Add(new DataPoint(a, coseno));

                dgv.Rows.Add(new object[] { a, seno.ToString("0.00"), coseno.ToString("0.00") });
            }
        }

        private void btnGeraGraficos2_Click(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedIndex < 0) return;
            Random rn = new Random();
            chart2.Legends[0].Docking = Docking.Bottom;
            chart2.Titles.Clear();
            chart2.Titles.Add("Tipos de Gráfico");
            chart2.Titles[0].Font = new Font("Arial", 10, FontStyle.Bold);
            chart2.Titles[0].ForeColor = Color.Blue;
            chart2.Series.Clear();
            chart2.Series.Add("Série 1");
            chart2.Series.Add("Série 2");

            chart2.Series[0].ChartType = (SeriesChartType)cmbTipo.SelectedIndex;
            chart2.Series[1].ChartType = (SeriesChartType)cmbTipo.SelectedIndex;

            chart2.ChartAreas[0].AxisY.Minimum = 0;
            chart2.ChartAreas[0].AxisY.Maximum = 1000;

            dgv2.Columns.Clear();
            dgv2.Rows.Clear();
            dgv2.ColumnCount = 3;
            dgv2.Columns[0].HeaderText = "X";
            dgv2.Columns[0].Width = 50;
            dgv2.Columns[1].HeaderText = "Y1";
            dgv2.Columns[1].Width = 50;
            dgv2.Columns[2].HeaderText = "Y2";
            dgv2.Columns[2].Width = 50;

            for (int i = 0; i <= 10; i++)
            {
                double Y1 = rn.Next(1,1000);
                double Y2 = rn.Next(1, 1000);
                chart2.Series[0].Points.Add(new DataPoint(i, Y1));
                chart2.Series[1].Points.Add(new DataPoint(i, Y2));

                dgv2.Rows.Add(new object[] { i, Y1.ToString("0.00"), Y2.ToString("0.00") });
            }

        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnGeraGraficos2.PerformClick();
        }
    }
}
