
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lambda1
{
    public partial class Lambda : Form
    {
        public Lambda()
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
        /// <param name="x1">X inicial</param>
        /// <param name="x2">X final</param>
        /// <param name="incr">incremento de X</param>
        void Calcula(FuncDeX f, double x1 , double x2, double incr )
        {
            lbx.Items.Clear();
            double x = x1;
            // loop para gerar os valores de Y
            // faz apenas contagem progressiva, o método Calcula2 resolve o problema
            // podendo contar tanto progressivo quanto regressivo
            while (x <= x2)
            {
                // calcula Y de acordo com o método apontado
                // pela variável f
                double y = f( x );
                // mostra os valores de X e Y no listBox
                lbx.Items.Add ( "f( " + x + ") = " + y.ToString("0.0000"));
                x += incr;
            }
        }

        // Executa o método calcula utilizando divide ou multiplica
        // dependendo do RadioButton selecionado
        private void btnMultDiv1_Click(object sender, EventArgs e)
        {
            // declara variável para armazenar o método que será executado
            FuncDeX f;
            // coloca na variável o método que será executado dependendo
            // do RadioButton selecionado
            if (rbDivide.Checked) f = divide;
            else f = multiplica;
            // Executa o método calcula, passando para ele a variável f
            // que contem o cálculo que será executado
            Calcula2(f, 1, 100, 1, "y = 2 * x");
        }

        // em vez de declarar um método para divide ou mutiplica
        // utiliza expressão lambda e a armazena em variável
        // (parâmetros) => retorno
        private void btnMultDiv2_Click(object sender, EventArgs e)
        {
            FuncDeX f;
            // neste caso, no lugar de chamarmos métodos formais
            // estamos utilizando expressões lambda
            // (parâmetros) => retorno
            if (rbDivide.Checked) f = (x) => x / 2;
            else f = (x) => x * 2;

            Calcula2(f, 1, 100, 1, "y = x / 2");
        }
       
        // passa a expressão lambda diretamente como parâmetro
        // para o método calcula
        private void btnQuadrado_Click(object sender, EventArgs e)
        {
            Calcula2((x) => x * x, 1, 100, 1, "y = x * x");
        }

        // passa a expressão lambda diretamente como parâmetro
        // para o método calcula
        private void btnSeno_Click(object sender, EventArgs e)
        {
            // calcula o seno do ângulo que vai variar de 0 até
            // 2.PI (ou 360 graus)
            Calcula2((a) => Math.Sin(2 * Math.PI * a / 360), 0, 360, 1, "y = sin( x )");
        }

        private void btnCoseno_Click(object sender, EventArgs e)
        {
            Calcula2((a) => Math.Cos(2 * Math.PI * a / 360), 0, 360, 1, "y = sin( x )");
        }

        private void btnParabola_Click(object sender, EventArgs e)
        {
            Calcula2((x) => x * x + x + 1, -100, 100, 1, "y = x*x + x + 1");
        }

        // testando com contagem progressiva
        private void btn1X_1_Click(object sender, EventArgs e)
        {
            // calcula 1 / x fazendo x variar de 1 até 100
            Calcula2((x) => 1 / x, 1, 100, 1, "y = 1 / x");
        }

        // testando com contagem regressiva
        private void btn1X_2_Click(object sender, EventArgs e)
        {
            // calcula 1 / x fazendo x variar de 100 até 1
            // descoobrir o motivo pelo qual não está funcionando
            // o motivo de não funcionar é que no método Calcula, a 
            // condição do loop é:
            // while (x <= x2) // x é 100 e x2 é 1
            Calcula2((x) => 1 / x, 100, 1, -1, "y = 1 / x");
        }


        //------------------------------------------------------ 
        //   Nova versão do médodo Calcula permite contagem
        //   progressiva ou regressiva
        //------------------------------------------------------ 

        // declara delegate para condição do loop while
        // métodos declarados do tipo CondWhile irão receber
        // 2 parâmetros double, compará-los e retornar true ou false
        delegate bool CondWhile(double cont, double limite);

        void Calcula2(FuncDeX f, double x1, double x2, double incr, string serie)
        {
            lbx.Items.Clear();
            // declara variável para armazenar a expressão
            // que resulta na condição do While
            CondWhile cond;
            // se x1 menor que x2 a contagem deverá ser progressiva
            // e o loop deve prosseguir enquanto x1 <= x2
            if (x1 < x2) cond = (cont, limite) => cont <= limite;
            // caso contrário a contagem será regressiva
            // e o loop deve prosseguir enquanto x1 >= x2
            else cond = (cont, limite) => cont >= limite;
            double x = x1;

            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series[0].Points.Clear();
            chart1.Series[0].Name = serie;
            chart1.Titles.Clear();
            chart1.Titles.Add("Título Principal");
            chart1.Titles.Add("Sub-Título");

            chart1.Titles[0].Font = new Font("Arial", 12);

            chart1.Legends[0].Docking = Docking.Bottom;

            chart1.ChartAreas[0].AxisY.Title = "Tit. eixo Y";
            chart1.ChartAreas[0].AxisX.Title = "Tit. eixo X";

            // executa o loop while utilizando como condição
            // a expressão atribuída à variável cond. Passamos
            // para a expressão o valor de x (contador em a)
            // e x2 (limite de contagem em b)
            while (cond(x, x2))
            {
                double y = f(x);
                chart1.Series[0].Points.Add(new DataPoint(x,y));
                lbx.Items.Add("f( " + x.ToString("0.0000") + ") = " + y.ToString("0.0000"));
                x += incr;
            }
        }

   

  

      

    }
}
