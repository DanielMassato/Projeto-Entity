using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double km;
            double litros;
            double consumo;
            km = Convert.ToDouble( tbxKm.Text );
            litros = Convert.ToDouble(tbxLitros.Text);

            if (litros <= 0)
            {
                MessageBox.Show("Seu bundão!");
                return;
            }

            consumo = km / litros;
            lblConsumo.Text = consumo.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Random rn = new Random();


        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int n =rn.Next(1000, 15000);
            Console.Beep(n,100);
            lbx.Items.Add(n);
            lbx.SelectedIndex = lbx.Items.Count - 1;
            //panel1.BackColor.ToArgb(n);

        }

        private void button6_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            int tag = Convert.ToInt32(   btn.Tag.ToString().Trim() );
            Console.Beep(tag, 100);
        }
    }
}
