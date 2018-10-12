using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Relatorios
{
    public partial class FormPreview : Form
    {
        public FormPreview(string report, string dataSet, DataTable table)
        {
            InitializeComponent();

            // caminho e nome do relatório que será mostrado
            reportViewer1.LocalReport.ReportPath = report;
            // fonte de dados para o relatorio
            ReportDataSource rpds = new ReportDataSource(dataSet, table);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rpds);
            // gerar o relatorio
            reportViewer1.RefreshReport();
        }

        private void FormPreview_Load(object sender, EventArgs e)
        {

        }
    }
}
