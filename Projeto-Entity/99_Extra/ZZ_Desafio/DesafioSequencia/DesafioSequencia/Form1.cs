using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesafioSequencia
{
    public partial class Form1 : Form
    {
        const uint tMatriz = 1000000;
        uint[] numeros = new uint[tMatriz];
        
        
        public Form1()
        {
            InitializeComponent();
        }

        int proxNumSeq(int n)
        {
            if (n % 2 == 0)
                return n / 2;
            else
                return 3 * n + 1;
        }

        private void btnGeraSeq_Click(object sender, EventArgs e)
        {
            int n = (int)updN.Value, cont = 0;
            DateTime tIni = DateTime.Now;
            dgv.RowCount = 1;
            dgv.Columns[0].HeaderText = "Seq. " + n;
            dgv.Rows[0].Cells[0].Value = n;
            do
            {
                cont++;
                n = proxNumSeq(n);
                dgv.Rows.Add();
                dgv.Rows[cont].Cells[0].Value = n;                
            } while (n != 1);
            DateTime tFim = DateTime.Now;
            lblTotEltos.Text = dgv.RowCount.ToString("#,##0");
            lblT.Text = tFim.Subtract(tIni).TotalSeconds.ToString("0.000") + " segundos";
        }

        uint calcSeq(uint n)
        {
          
                if (n == 1) return 1;
                else if (n < tMatriz && numeros[n] != 0) return numeros[n];
                else if (n % 2 == 0)
                {
                    uint q = calcSeq(n / 2) + 1;
                    if (n < tMatriz) numeros[n] = q;
                    return q;
                }
                else
                {
                    uint q = calcSeq(3 * n + 1) + 1;
                    if (n < tMatriz) numeros[n] = q;
                    return q;
                }
            
    
        }

        private void btnCalcSeq_Click(object sender, EventArgs e)
        {
            uint qMaior = 0, nMaior = 0;
            int inicio = Convert.ToInt32(updIni.Value);
            int limite = Convert.ToInt32(updFim.Value);
            
            DateTime tIni = DateTime.Now;
            for (uint i = (uint)inicio; i <= limite; i++)
            {
                //listBox1.Items.Add(i);
                uint q = calcSeq(i);
                if (q > qMaior)
                {
                    qMaior = q;
                    nMaior = i;
                }
                
            }

            lblNMaior.Text = nMaior.ToString();
            lblQMaior.Text = qMaior.ToString();
            DateTime tFim = DateTime.Now;
            lblTempo.Text = tFim.Subtract(tIni).TotalSeconds.ToString("0.000") + " segundos";
        }

        private void btnLimpaMatriz_Click(object sender, EventArgs e)
        {
            Array.Clear(numeros, 0, numeros.Length - 1);
        }

    
    }
}
