using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JogoNumeroSecreto;

namespace NumeroSecreto
{
    public partial class Form1 : Form
    {
        ClasseNumeroSecreto jogo = new ClasseNumeroSecreto();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            jogo.Inicia(Convert.ToInt32(tbxLimite.Text));
            btnInicia.Enabled = false;
            gbJogo.Enabled = true;
            tbxTentativa.Focus();
        }

        private void btnJoga_Click(object sender, EventArgs e)
        {
            int ret = jogo.FazTentativa(Convert.ToInt32(tbxTentativa.Text));
            lbl.Text = "Sua " + jogo.CtdTentativas.ToString() + "a. Tentativa:";
            if (ret == -1) lblMsg.Text = "TENTE UM NÚMERO MENOR";
            else if (ret == 1) lblMsg.Text = "TENTE UM NÚMERO MAIOR";
            else
            {
                lblMsg.Text = "MATOU COM " + jogo.CtdTentativas.ToString() + " TENTATIVAS...";
                gbJogo.Enabled = false;
                btnInicia.Enabled = true;
                System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"r2d2.wav");
            }
            if (tbxTentativa.Enabled)
            {
                tbxTentativa.Focus();
                tbxTentativa.SelectAll();
            }
        }

        private void tbxLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x000D') btnInicia.PerformClick();
        }

        private void tbxTentativa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\x000D') btnJoga.PerformClick();
        }


    }
}
