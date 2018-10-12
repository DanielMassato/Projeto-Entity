using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetodosExtensao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTesta_Click(object sender, EventArgs e)
        {
            if (tbxNumero.Text.EhDecimal())
                lblTesta.Text = "É numérico";
            else
                lblTesta.Text = "NÃO É numérico";
        }

        private void btnConvDec_Click(object sender, EventArgs e)
        {
            try
            {
                decimal n = tbxNumero.Text.ToDecimal() * 2;
                lblConvDec.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConvInt_Click(object sender, EventArgs e)
        {
            try
            {
                int n = tbxNumero.Text.ToInt32() * 2;
                lblConvInt.Text = n.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnContaPal_Click(object sender, EventArgs e)
        {
            lblContaPal.Text = tbxTexto.Text.ContaPalavras().ToString();
        }

        private void btnPegaPal_Click(object sender, EventArgs e)
        {
            uint pos = Convert.ToUInt32(updPos.Value);
            lblPegaPal.Text = tbxTexto.Text.PegaPalavra(pos);
        }

        private void btnNomeProprio_Click(object sender, EventArgs e)
        {
            lblNomeProprio.Text = tbxTexto.Text.NomeProprio();
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            byte n = Convert.ToByte(updFat.Value);
            ulong fat = n.Fatorial();
            lblFat.Text = fat.ToString("#,##0");
        }
    }
}
