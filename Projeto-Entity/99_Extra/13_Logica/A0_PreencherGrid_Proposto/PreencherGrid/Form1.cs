using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PreencherGrid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeraGrid_Click(object sender, EventArgs e)
        {
            // limpa as colunas do Grid
            dgv.Columns.Clear();
            // loop para criar 32 colunas no grid
            for (int i = 0; i < 32; i++)
            {
                // cria uma nova coluna, passando para ela o seu nome (nome da coluna) e o seu título
                dgv.Columns.Add("A" + i, "");
                dgv.Columns[i].Width = 15;
                dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgv.RowCount = 32;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnGeraGrid.PerformClick();
        }

        private void btnMoldura_Click(object sender, EventArgs e)
        {
            string value = "#";
            for (int i = 0; i < dgv.Columns.Count; i++)
            {
                dgv.Rows[0].Cells[i].Value = value;
                dgv.Rows[dgv.RowCount-1].Cells[i].Value = value;
                dgv.Rows[i].Cells[0].Value = value;
                dgv.Rows[i].Cells[dgv.Columns.Count - 1].Value = value;
            }
        }

        private void btnDiagonais_Click(object sender, EventArgs e)
        {
            string value = "X";
            for (int i = 1; i < dgv.Columns.Count - 1; i++)
            {
                dgv.Rows[i].Cells[i].Value = value;
                dgv.Rows[i].Cells[dgv.Columns.Count - 1 - i].Value = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "X";
            for (int i = 1; i < dgv.Columns.Count - 1; i++)
            {
                dgv.Rows[i].Cells[dgv.Columns.Count/2].Value = value;
                dgv.Rows[dgv.Columns.Count / 2].Cells[i].Value = value;
            }
        }

        private void btnLosango_Click(object sender, EventArgs e)
        {
            string value = "X";
            int incr = 1, centro = 15, col = 0;
            for (int i = 0; i < dgv.Columns.Count-1 ; i++)
            {
                dgv.Rows[i].Cells[centro - col].Value = value;
                dgv.Rows[i].Cells[centro + col].Value = value;

                if (i < centro) col++;
                else col--;
            }
        }

      


    }
}
