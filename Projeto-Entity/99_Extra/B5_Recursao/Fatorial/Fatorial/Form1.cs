using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*
         * O fatorial de 5 ou 5! se calcula fazendo 
         * 5 x 4 x 3 x 2 x 1 = 120
         * Por definição o fatorial de zero é 1
         */
        int fatorial(int n)
        {
            if (n <= 1) return 1;
            // aqui o método chama a ele próprio,
            // gerando a recursão
            else return n * fatorial(n - 1);
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            lblFatorial.Text = fatorial((int)updNum.Value).ToString();
        }
    }
}
