
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lambda1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // declara a sintaxe (ou assinatura) de um método
        delegate double FuncDeX(double x);

        // cria métodos que atendem ao delegate FuncDeX
        double divide(double n)
        {
            return n / 2;
        }

        double multiplica(double n)
        {
            return n * 2;
        }

        // rotina auxiliar que recebe a variável f que é do tipo FuncDeX
        // esta variável aponta para um método que respeite a 
        // assinatura criada pelo delegate. Pode apontar para o método
        // divide, multiplica ou qualquer outro que receba como parâmetro
        // um dado do tipo double e retorne com double
        /// <summary>
        /// rotina auxiliar que gera valores x e y de uma função linear
        /// </summary>
        /// <param name="f">Ponteiro para o método que calcula Y dado X</param>
        /// <param name="inicio">X inicial</param>
        /// <param name="fim">X final</param>
        /// <param name="incr">incremento de X</param>
        void Calcula(FuncDeX f, double inicio , double fim, double incr )
        {
            lbx.Items.Clear();
            double ctdr = inicio;
            // loop para gerar os valores de Y
            while (ctdr <= fim)
            {
                // calcula Y de acordo com o método apontado
                // pela variável f
                double y = f( ctdr );
                // mostra os valores de X e Y no listBox
                lbx.Items.Add ( "f( " + ctdr + ") = " + y.ToString("0.0000"));
                ctdr += incr;
            }
        }

        // Executa o método calcula utilizando divide ou multiplica
        // dependendo do RadioButton selecionado
        private void btnDivMult1_Click(object sender, EventArgs e)
        {
            FuncDeX f;

            if (rbDivide.Checked) f = divide;
            else f = multiplica;

            Calcula(f, 1, 100, 1);
        }

        // em vez de declarar um método para divide ou mutiplica
        // utiliza expressão lambda e a armazena em variável
        // (parâmetros) => retorno
        /*
        double divide(double n)
        {
            return n / 2;
        }
         */
        private void btnDivMult2_Click(object sender, EventArgs e)
        {
            FuncDeX f;

            if (rbDivide.Checked) f = (x) => x / 2;
            else f = (y) => y * 2;

            Calcula(f, 1, 100, 1);
        }
       
        // passa a expressão lambda diretamente como parâmetro
        // para o método calcula
        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            Calcula((n) => n * n, 0, 100, 1);
        }

        // passa a expressão lambda diretamente como parâmetro
        // para o método calcula
        private void btnSeno_Click(object sender, EventArgs e)
        {
            Calcula((a) => Math.Sin(a), 0, 2 * Math.PI, 0.1);
        }

      
        private void btnDivX1_Click(object sender, EventArgs e)
        {
            Calcula((x) => 1 / x, 1, 100, 1);
        }

     


    }
}
