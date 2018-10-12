using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Piada
{
    public partial class Form1 : Form
    {
        bool podeFechar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!podeFechar)
                e.Cancel = true;
        }

        private void btnNao_Enter(object sender, EventArgs e)
        {
            btnSim.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End && e.Alt && e.Control && e.Shift)
            {
                podeFechar = true;
                Close();
            }

            
        }

        private void btnNao_MouseEnter(object sender, EventArgs e)
        {
            if (btnNao.Left == 183) btnNao.Left = 20;
            else btnNao.Left = 183;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pb.Value > 0) pb.Value--;
            lblSec.Text = pb.Value.ToString("00");
            if (pb.Value <= 0)
            {
                timer1.Enabled = false;
                podeFechar = true;
                //MessageBox.Show("Brincadeirinha...");
                //Close();
                (new FormTelazul()).ShowDialog();
                Close();
            }
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            pb.Value = 0;
        }
    }
}
