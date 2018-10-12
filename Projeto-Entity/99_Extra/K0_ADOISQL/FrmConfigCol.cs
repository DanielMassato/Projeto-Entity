using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ADOISQL
{
    public partial class FrmConfigCol : Form
    {
        DataSet ds;

        public FrmConfigCol()
        {
            InitializeComponent();
        }

        DataGridView dtgv;

        public FrmConfigCol(DataGridView dgv)
        {
            InitializeComponent();
            dtgv = dgv;
            ds = new DataSet();
            LeColunas();
        }

        void LeColunas()
        {
            ds.Clear();
            ds = new DataSet();

            DataTable dt = new DataTable("COLUNAS");

            dt.Columns.Add("VISIVEL", typeof(System.Boolean));
            dt.Columns.Add("CAMPO", typeof(System.String));
            dt.Columns.Add("TITULO", typeof(System.String));
            dt.Columns.Add("FORMATO", typeof(System.String));
            dt.Columns.Add("ALINHAMENTO", typeof(System.String));
            dt.Columns.Add("LARGURA", typeof(System.Int16));

            dt.Columns[0].Caption = "Visível";

            ds.Tables.Add(dt);

            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                DataRow dr = dt.NewRow();
                dr["VISIVEL"] = dtgv.Columns[i].Visible;
                dr["CAMPO"] = dtgv.Columns[i].DataPropertyName;
                dr["TITULO"] = dtgv.Columns[i].HeaderText;
                dr["FORMATO"] = dtgv.Columns[i].DefaultCellStyle.Format;

                dr["ALINHAMENTO"] = "Esquerda";

                if (dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleRight ||
                            dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.BottomRight ||
                            dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.TopRight)

                    dr["ALINHAMENTO"] = "Direita";

                if (dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.MiddleCenter ||
                                            dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.BottomCenter ||
                                            dtgv.Columns[i].DefaultCellStyle.Alignment == DataGridViewContentAlignment.TopCenter)

                    dr["ALINHAMENTO"] = "Centro";
                                  

                dr["LARGURA"] = dtgv.Columns[i].Width;
                dt.Rows.Add(dr);

            }
            dgvColunas.DataSource = ds.Tables[0];

            dgvColunas.Columns[0].DataPropertyName = "VISIVEL";
            dgvColunas.Columns[1].DataPropertyName = "CAMPO";
            dgvColunas.Columns[1].ReadOnly = true;
            dgvColunas.Columns[2].DataPropertyName = "TITULO";
            dgvColunas.Columns[3].DataPropertyName = "FORMATO";
            dgvColunas.Columns[4].DataPropertyName = "ALINHAMENTO";
            dgvColunas.Columns[5].DataPropertyName = "LARGURA";
            for (int i = 6; i < dgvColunas.Columns.Count; i++)
                dgvColunas.Columns[i].Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dr["VISIVEL"] = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                dr["VISIVEL"] = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = ds.Tables[0];
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                this.dtgv.Columns[i].Visible = Convert.ToBoolean( dr["VISIVEL"] );
                this.dtgv.Columns[i].HeaderText = Convert.ToString(dr["TITULO"]);
                this.dtgv.Columns[i].DefaultCellStyle.Format = Convert.ToString(dr["FORMATO"]);
                if (dr["Alinhamento"].ToString() == "Esquerda")
                    this.dtgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                else if (dr["Alinhamento"].ToString() == "Centro")
                    this.dtgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;                    
                else
                    this.dtgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    
                this.dtgv.Columns[i].Width = Convert.ToInt32(dr["LARGURA"]);
            }
 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}