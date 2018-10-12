using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace VendedoresPedidos
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = Conexoes.ConexaoOle();
        DataTable tbVend = new DataTable();

        public Form1()
        {
            InitializeComponent();
            
        }
        //============================================ MESTRE(VENDEDORES)
        private void btnFiltra_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT V.CODVEN, V.NOME, V.FONE, 
                       SUM(P.VLR_TOTAL) AS TOT_VENDIDO, 
                       SUM(P.VLR_TOTAL * V.PORC_COMISSAO/100) AS COMISSAO,
                       COUNT(*) AS QTD_PEDIDOS 
                FROM VENDEDORES V JOIN PEDIDOS P ON V.CODVEN = P.CODVEN 
                WHERE MONTH(P.DATA_EMISSAO) = ? AND YEAR(P.DATA_EMISSAO) = ? 
                GROUP BY " + (ckbNC.Checked ? " ALL " : "" ) + 
                    " V.CODVEN, V.NOME, V.FONE";

            cmd.Parameters.AddWithValue("mes", updMes.Value);
            cmd.Parameters.AddWithValue("ano", updAno.Value);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            tbVend.Clear();
            da.Fill(tbVend);
            bsVendedores.DataSource = tbVend;
            dgvVendedores.DataSource = bsVendedores;
            chart1.Series[0].Points.Clear();
            chart1.DataSource = tbVend;
            chart1.Series[0].XValueMember = "CODVEN";
            chart1.Series[0].YValueMembers = "TOT_VENDIDO";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();
        }

        private void tbtnPrimeiro_Click(object sender, EventArgs e)
        {
            bsVendedores.MoveFirst();
        }

        private void tbtnAnterior_Click(object sender, EventArgs e)
        {
            bsVendedores.MovePrevious();
        }

        private void tbtnProximo_Click(object sender, EventArgs e)
        {
            bsVendedores.MoveNext();
        }

        private void tbtnUltimo_Click(object sender, EventArgs e)
        {
            bsVendedores.MoveLast();
        }

        private void updMes_ValueChanged(object sender, EventArgs e)
        {
            btnFiltra.PerformClick();
        }


        //====================================== DETELHE (PEDIDOS)
        void mostraPedidos(int codven)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText =
            @"SELECT 
                P.NUM_PEDIDO, P.DATA_EMISSAO, P.VLR_TOTAL, C.NOME AS CLIENTE
              FROM PEDIDOS P 
              JOIN CLIENTES C ON P.CODCLI = C.CODCLI 
              WHERE MONTH(P.DATA_EMISSAO) = ? AND
              YEAR(P.DATA_EMISSAO) = ? AND
              P.CODVEN = ?
              ORDER BY P.NUM_PEDIDO";

            cmd.Parameters.AddWithValue("mes", updMes.Value);
            cmd.Parameters.AddWithValue("ano", updAno.Value);
            cmd.Parameters.AddWithValue("codven", codven);

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            DataTable tbPed = new DataTable();
            da.Fill(tbPed);
            dgvPed.DataSource = tbPed;
        }

        private void bsVendedores_CurrentChanged(object sender, EventArgs e)
        {
            int pos = bsVendedores.Position;
            int codven = 0;
            if (pos >= 0 && pos < tbVend.Rows.Count)
                codven = Convert.ToInt32(tbVend.Rows[pos]["CODVEN"]);

            mostraPedidos(codven);

            lblRecNo.Text = (1 + bsVendedores.Position) + " / " +
                             bsVendedores.Count;
        }

    }
}
