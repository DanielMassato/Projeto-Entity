using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LinqEdicao
{
    public partial class Form1 : Form
    {

        // PEDIDOSEntities pedidos = new PEDIDOSEntities();

        enum EditStatus  {Consulta, Altera, Inclui};
        EditStatus recStatus;
   

        int codcli = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnFiltra_Click(object sender, EventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();

        //    tbxCODCLI.DataBindings.Add("Text", bsClientes, "CODCLI");
        //    tbxNOME.DataBindings.Add("Text", bsClientes, "NOME");
        //    tbxFANTASIA.DataBindings.Add("Text", bsClientes, "FANTASIA");
        //    tbxENDERECO.DataBindings.Add("Text", bsClientes, "ENDERECO");
        //    tbxBAIRRO.DataBindings.Add("Text", bsClientes, "BAIRRO");
        //    tbxCIDADE.DataBindings.Add("Text", bsClientes, "CIDADE");
        //    tbxESTADO.DataBindings.Add("Text", bsClientes, "ESTADO");
        //    tbxCEP.DataBindings.Add("Text", bsClientes, "CEP");
        //    tbxCNPJ.DataBindings.Add("Text", bsClientes, "CNPJ");
        //    tbxINSCRICAO.DataBindings.Add("Text", bsClientes, "INSCRICAO");
        //    tbxFONE1.DataBindings.Add("Text", bsClientes, "FONE1");
        //    tbxE_MAIL.DataBindings.Add("Text", bsClientes, "E_MAIL");
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            dgvClientes.Enabled = false;

            groupBox2.Enabled = true;

            tbxNOME.Focus();
            recStatus = EditStatus.Altera;
        }

       

        private void btnInclui_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            dgvClientes.Enabled = false;

            groupBox2.Enabled = true;

            tbxNOME.Focus();

            foreach (Control ctl in groupBox2.Controls)
            {
                if (ctl is TextBox) (ctl as TextBox).Clear();
            }

            recStatus = EditStatus.Inclui;

        }

        private void btnGrava_Click(object sender, EventArgs e)
        {

           
            if (recStatus == EditStatus.Altera)
            {
                altera();
            }
            else
            {
                inclui();
                
            }
           

            groupBox2.Enabled = false;
            groupBox1.Enabled = true;
            dgvClientes.Enabled = true;

            btnFiltra.PerformClick();
            recStatus = EditStatus.Consulta;

            Text = codcli.ToString();

           // bsClientes.Position = bsClientes.Find("CODCLI", codcli);
        }

        void altera()
        {


        }

        void inclui()
        {

        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão?", "Cuidado",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                
            }
        }




    }
}
