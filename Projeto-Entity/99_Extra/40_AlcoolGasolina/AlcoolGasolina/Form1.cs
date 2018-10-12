using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlcoolGasolina
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void atualizaTela()
        {
            lblKmTotal.Text = alcoolOuGasolina1.KmTotal.ToString();
            lblQtdAlcool.Text = alcoolOuGasolina1.QtdAlcool.ToString();
            lblQtdGasol.Text = alcoolOuGasolina1.QtdGasol.ToString();
            lblValorTotal.Text = alcoolOuGasolina1.ValorTotal.ToString();
            lblValorPorKm.Text = alcoolOuGasolina1.ValorPorKm.ToString("0.000");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void tkbBalGasol_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.BalancoGasolonaAlcool = tkbBalGasol.Value;
            atualizaTela();
        }

        private void updLitrosTanque_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.LitrosTanque = updLitrosTanque.Value;
            atualizaTela();
        }

        private void updConsumoAlcool_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.ConsumoAlcool = updConsumoAlcool.Value;
            atualizaTela();
        }

        private void updConsumoGasolina_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.ConsumoGasolina = updConsumoGasolina.Value;
            atualizaTela();
        }

        private void updPrecoAlcool_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.PrecoAlcool = updPrecoAlcool.Value;
            atualizaTela();
        }

        private void updPrecoGasolina_ValueChanged(object sender, EventArgs e)
        {
            alcoolOuGasolina1.PrecoGasolina = updPrecoGasolina.Value;
            atualizaTela();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaTela();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:" + linkLabel1.Text);
        }
    }
}
