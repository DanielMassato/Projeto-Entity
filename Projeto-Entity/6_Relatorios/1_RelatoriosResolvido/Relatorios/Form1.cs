using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Relatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetRelatorios.VENDEDORES' table. You can move, or remove it, as needed.
            this.vENDEDORESTableAdapter.Fill(this.dataSetRelatorios.VENDEDORES);
            // TODO: This line of code loads data into the 'dataSetRelatorios.CLIENTES' table. You can move, or remove it, as needed.
            this.cLIENTESTableAdapter.Fill(this.dataSetRelatorios.CLIENTES);
            // TODO: This line of code loads data into the 'dataSetRelatorios.PRODUTOS' table. You can move, or remove it, as needed.
            this.pRODUTOSTableAdapter.Fill(this.dataSetRelatorios.PRODUTOS, "%");

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            string report, dataSet;
            DataTable table;
            // se estiver na aba PRODUTOS
            if (tabControl1.SelectedIndex == 0)
            {
                report = "Relatorios\\RelProdutos.rdl";
                dataSet = "dsProdutos";
                table = dataSetRelatorios.PRODUTOS;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                report = "Relatorios\\RelClientes.rdl";
                dataSet = "dsClientes";
                table = dataSetRelatorios.CLIENTES;
            }
            else
            {
                report = "Relatorios\\RelVendedores.rdl";
                dataSet = "dsVendedores";
                table = dataSetRelatorios.VENDEDORES;
            }
            // abrir a tela de preview
            new FormPreview(report, dataSet, table).Show();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            this.pRODUTOSTableAdapter.Fill(
                this.dataSetRelatorios.PRODUTOS, 
                "%" + tbxDescricao.Text + "%");
        }
    }
}
