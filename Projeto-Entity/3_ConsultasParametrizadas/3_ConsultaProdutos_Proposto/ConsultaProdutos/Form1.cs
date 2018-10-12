using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsultaProdutos
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {


//            @"SELECT PR.ID_PRODUTO, PR.COD_PRODUTO, PR.DESCRICAO, 
//                                       T.TIPO, U.UNIDADE, PR.PRECO_VENDA, PR.QTD_REAL,
//                                       PR.QTD_MINIMA  
//                                FROM PRODUTOS PR 
//                                JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
//                                JOIN UNIDADES U ON PR.COD_UNIDADE = U.COD_UNIDADE 
//                                WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo 
//                                ORDER BY DESCRICAO ";

           

        }

        private void btnReajusta_Click(object sender, EventArgs e)
        {


//                    @"UPDATE PRODUTOS SET PRECO_VENDA = PRECO_VENDA * @fator
//                  FROM PRODUTOS PR 
//                  JOIN TIPOPRODUTO T ON PR.COD_TIPO = T.COD_TIPO 
//                  WHERE DESCRICAO LIKE @descricao AND TIPO LIKE @tipo ";

               
            

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
           
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
           
        }

     

        private void tbxProcura_Click(object sender, EventArgs e)
        {
   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();

          
        }

        private void tbxProcura_TextChanged(object sender, EventArgs e)
        {
            //if (!Locate("DESCRICAO", tbxProcura.Text))
            //{
            //    Console.Beep(800, 100);
            //    tbxProcura.SelectionStart--;
            //    tbxProcura.SelectionLength = 1;
            //}
        }

         

    }
}


