using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace ConsultaAlteraPedidos
{
    public partial class Form1 : Form
    {
        OleDbConnection conn = Conexoes.ConexaoOle();
        DataTable tbPedidosConsulta = new DataTable();
        DataTable tbPedidosAltera = new DataTable();
        OleDbDataAdapter daPedidosAltera = new OleDbDataAdapter();

        DataTable tbItensConsulta = new DataTable();
        DataTable tbItensAltera = new DataTable();
        OleDbDataAdapter daItensAltera = new OleDbDataAdapter();

        int numPedido, numItem;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText =
                @"SELECT P.NUM_PEDIDO, P.DATA_EMISSAO, P.VLR_TOTAL, C.NOME AS CLIENTE, 
                         V.NOME AS VENDEDOR, CASE P.SITUACAO
                                                WHEN 'E' THEN 'Entregue'
                                                WHEN 'P' THEN 'Pendente'
                                                WHEN 'C' THEN 'Cancelado'
                                             END AS DESCR_SIT, OBSERVACOES  
                  FROM PEDIDOS P 
                  JOIN CLIENTES C ON P.CODCLI = C.CODCLI 
                  JOIN VENDEDORES V ON P.CODVEN = V.CODVEN 
                  WHERE P.DATA_EMISSAO BETWEEN ? AND ? AND 
                        C.NOME LIKE ? AND V.NOME LIKE ? 
                  ORDER BY P.DATA_EMISSAO DESC";

            cmd.Parameters.AddWithValue("data1", dtp1.Value);
            cmd.Parameters.AddWithValue("data2", dtp2.Value);
            cmd.Parameters.AddWithValue("cli", "%" + tbxCli.Text + "%");
            cmd.Parameters.AddWithValue("ven", "%" + tbxVend.Text + "%");

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            tbPedidosConsulta.Clear();
            lblRegs.Text = da.Fill(tbPedidosConsulta).ToString("000000");

            dgvPed.Columns[dgvPed.Columns.Count - 1].Visible = false;

            bsPedidosConsulta.DataSource = tbPedidosConsulta;
            dgvPed.DataSource = bsPedidosConsulta;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtp1.Value = DateTime.Now.AddDays(-30);
            dtp2.Value = DateTime.Now;
            conn.Open();
            btnFiltra.PerformClick();
            bsPedidosAltera.DataSource = tbPedidosAltera;
            tbxObsConsulta.DataBindings.Add("Text", bsPedidosConsulta, "OBSERVACOES");
            //Thread.CurrentThread.
            //tbxCLIENTE.BackColor = Color.White;
        }

        private void tbtnPrimeiro_Click(object sender, EventArgs e)
        {
            bsPedidosConsulta.MoveFirst();
        }

        private void tbtnAnterior_Click(object sender, EventArgs e)
        {
            bsPedidosConsulta.MovePrevious();
        }

        private void tbtnProximo_Click(object sender, EventArgs e)
        {
            bsPedidosConsulta.MoveNext();
        }

        private void tbtnUltimo_Click(object sender, EventArgs e)
        {
            bsPedidosConsulta.MoveLast();
        }

        private void bsPedidosConsulta_CurrentChanged(object sender, EventArgs e)
        {
            int pos = bsPedidosConsulta.Position;
            numPedido = 0;
            if (pos >= 0 && pos < tbPedidosConsulta.Rows.Count)
            {
                DataRowView drv = (DataRowView)bsPedidosConsulta.Current;
                numPedido = Convert.ToInt32(drv["NUM_PEDIDO"]);
            }
            mostraFicha();
            mostraItensPedido();
        }

        void mostraFicha()
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM PEDIDOS WHERE NUM_PEDIDO = " + numPedido;
            daPedidosAltera.SelectCommand = cmd;
            tbPedidosAltera.Clear();
            daPedidosAltera.Fill(tbPedidosAltera);

            if (tbPedidosAltera.Rows.Count == 0) return;

            tbxCLIENTE.Text = DBUtils.GetStringFieldFromTable("CLIENTES","NOME","CODCLI",
                              Convert.ToInt32(tbPedidosAltera.Rows[0]["CODCLI"]), conn);
            tbxVENDEDOR.Text = DBUtils.GetStringFieldFromTable("VENDEDORES", "NOME", "CODVEN",
                             Convert.ToInt32(tbPedidosAltera.Rows[0]["CODVEN"]), conn);

            string sit = tbPedidosAltera.Rows[0]["SITUACAO"].ToString();
            if (sit == "P") rbPendente.Checked = true;
            else if (sit == "C") rbCancelado.Checked = true;
            else rbEntregue.Checked = true;
        }

        void mostraItensPedido()
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText =
               @"SELECT I.NUM_ITEM, I.ID_PRODUTO, PR.DESCRICAO, 
                        I.PR_UNITARIO, I.QUANTIDADE, I.DESCONTO, 
                        I.PR_UNITARIO * I.QUANTIDADE * (1-I.DESCONTO/100) AS VALOR, I.NUM_PEDIDO 
                 FROM ITENSPEDIDO I JOIN PRODUTOS PR ON I.ID_PRODUTO = PR.ID_PRODUTO 
                 WHERE NUM_PEDIDO = ?
                 ORDER BY I.NUM_ITEM";
         
            cmd.Parameters.AddWithValue("ped", numPedido);
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            tbItensConsulta.Clear();
            da.Fill(tbItensConsulta);
            bsItensConsulta.DataSource = tbItensConsulta;
            dgvItens.DataSource = bsItensConsulta;
        }

        void mostraFichaItem()
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM ITENSPEDIDO 
                                WHERE NUM_PEDIDO = " + numPedido + " AND NUM_ITEM = " + numItem;
            daItensAltera.SelectCommand = cmd;
            tbItensAltera.Clear();
            daItensAltera.Fill(tbItensAltera);
            bsItensAltera.DataSource = tbItensAltera;
            if (tbItensAltera.Rows.Count == 0) return;

            tbxProduto.Text = DBUtils.GetStringFieldFromTable("PRODUTOS", "DESCRICAO", "ID_PRODUTO",
                              Convert.ToInt32(tbItensAltera.Rows[0]["ID_PRODUTO"]), conn);
            
            int qtd = Convert.ToInt32(tbItensAltera.Rows[0]["QUANTIDADE"]);
            decimal preco = Convert.ToDecimal(tbItensAltera.Rows[0]["PR_UNITARIO"]);
            decimal desconto = Convert.ToDecimal(tbItensAltera.Rows[0]["DESCONTO"]);
            tbxValor.Text = (qtd * preco * (1 - desconto / 100)).ToString("#,##0.00");
        }

        private void bsItensConsulta_CurrentChanged(object sender, EventArgs e)
        {
            int pos = bsItensConsulta.Position;
            numItem = 0;
            if (pos >= 0 && pos < tbItensConsulta.Rows.Count)
            {
                DataRowView drv = (DataRowView)bsItensConsulta.Current;
                numItem = Convert.ToInt32(drv["NUM_ITEM"]);
            }
            mostraFichaItem();
        }

        private void tbtnItensPrimeiro_Click(object sender, EventArgs e)
        {
            bsItensConsulta.MoveFirst();
        }

        private void tbtnItensAnterior_Click(object sender, EventArgs e)
        {
            bsItensConsulta.MovePrevious();
        }

        private void tbtnItensProximo_Click(object sender, EventArgs e)
        {
            bsItensConsulta.MoveNext();
        }

        private void tbtnItensUltimo_Click(object sender, EventArgs e)
        {
            bsItensConsulta.MoveLast();
        }
    }
}
