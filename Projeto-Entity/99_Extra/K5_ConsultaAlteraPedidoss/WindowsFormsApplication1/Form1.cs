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

        Pessoas p = new Pessoas();

        private void button1_Click(object sender, EventArgs e)
        {
            p.Add(new Pessoa(1, "Magno"));
            p[0].VeiculosPessoa.Add(new Veiculo(1,"Ford","Fiesta","AAA-1234",2003));
            p[0].VeiculosPessoa.Add(new Veiculo(2, "Fiat", "Palio", "BBB-1234", 2003));    
        }
    }
}
