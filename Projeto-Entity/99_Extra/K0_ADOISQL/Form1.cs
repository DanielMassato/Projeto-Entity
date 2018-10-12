using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using Curso.Classes;

namespace ADOISQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct TableCols
        {

            public string HeaderText;
            public string VisibleCol;
            public int Width;

            public TableCols(string _header, string _field, int _width)
            {
                HeaderText = _header;
                VisibleCol = _field;
                Width = _width;
            }
        }

        private List<TableCols> tc = new List<TableCols>();

        private int BuscaColuna(string field, List<TableCols> tc)
        {
            int result = -1;
            for (int i = 0; i < tc.Count; i++)
                if (field == tc[i].VisibleCol)
                {
                    result = i;
                    break;
                }
            return result;
        }

        private void brnCSDialog_Click(object sender, EventArgs e)
        {
            MSDASC.DataLinks csDlg = new MSDASC.DataLinks();
            ADODB._Connection ADOCon;
            ADOCon = (ADODB._Connection)csDlg.PromptNew();
            tbxCS.Text = (string)ADOCon.ConnectionString;
            if (ADOCon.State == 1)
                ADOCon.Close();
        }

        private void FiltraLinhas()
        {
            string filter = "";

            if (ckbTableUsers.Checked) filter = "'TABLE'";
            if (ckbTableSys.Checked)
            {
                if (filter != "") filter = filter + ",";
                filter = filter + "'SYSTEM TABLE'";
            }
            if (filter == "") filter = "''";
            ((DataTable)dgvTables.DataSource).DefaultView.RowFilter = "TABLE_TYPE IN (" + filter + ")";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            oleDbConnection1.ConnectionString = tbxCS.Text;

            oleDbConnection1.Open();

            DataTable dt = oleDbConnection1.GetSchema("Tables");

            tc.Add(new TableCols("Tabela", "TABLE_NAME", 150));
            tc.Add(new TableCols("Tipo", "TABLE_TYPE", 120));
            tc.Add(new TableCols("Data Criação", "DATE_CREATED", 120));
            tc.Add(new TableCols("Data Alteração", "DATE_MODIFIED", 120));
            dgvTables.DataSource = dt;

            for (int i = 0; i < dgvTables.Columns.Count; i++)
            {
                int p = BuscaColuna(dgvTables.Columns[i].HeaderText, tc);
                if (p >= 0)
                {
                    dgvTables.Columns[i].Visible = true;
                    dgvTables.Columns[i].HeaderText = tc[p].HeaderText;
                    dgvTables.Columns[i].Width = dgvTables.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true); ;
                }
                else
                {
                    dgvTables.Columns[i].Visible = false;
                }
                

            }

            DataTable ind = oleDbConnection1.GetSchema("Indexes");
            dgvIndices.DataSource = ind;

            tc.Clear();
            tc.Add(new TableCols("Tabela", "TABLE_NAME", 200));
            tc.Add(new TableCols("Índice", "INDEX_NAME", 200));
            tc.Add(new TableCols("PK?", "PRIMARY_KEY", 60));
            tc.Add(new TableCols("Unq?", "UNIQUE", 60));
            tc.Add(new TableCols("Campo Chave", "COLUMN_NAME", 250));
            for (int i = 0; i < dgvIndices.Columns.Count; i++)
            {
                int p = BuscaColuna(dgvIndices.Columns[i].HeaderText, tc);
                if (p >= 0)
                {
                    dgvIndices.Columns[i].Visible = true;
                    dgvIndices.Columns[i].HeaderText = tc[p].HeaderText;
                    dgvIndices.Columns[i].Width = tc[p].Width;
                }
                else
                {
                    dgvIndices.Columns[i].Visible = false;
                }
            }
            dgvIndices.Columns[0].Visible = false;
            FiltraLinhas();
            FiltraColunasGrids();
            
            btnConnect.Enabled = false;
            btnCSDialog.Enabled = false;
            btnDesconecta.Enabled = true;
            tbxCS.ReadOnly = true;
            for (int i = 0; i < dgvCampos.Columns.Count; i++)
            {
                dgvCampos.Columns[i].Width = dgvCampos.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
            for (int i = 0; i < dgvIndices.Columns.Count; i++)
            {
                dgvIndices.Columns[i].Width = dgvIndices.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
        }

        void FiltraColunasGrids()
        {
            if (dgvTables.SelectedCells.Count == 0) return;
            if (dgvTables.SelectedCells[0].RowIndex > dgvTables.Rows.Count - 1) return;
            if (dgvTables.Rows[dgvTables.SelectedCells[0].RowIndex].Cells[2].Value == null) return;
            string tableName = dgvTables.Rows[dgvTables.SelectedCells[0].RowIndex].Cells[2].Value.ToString();

            ((DataTable)dgvIndices.DataSource).DefaultView.RowFilter = "TABLE_NAME = '" + tableName + "'";
            dgvIndices.Columns[0].Visible = false;

            oleDbCommand1.CommandText = "SELECT * FROM [" + tableName + "] WHERE 0=1";
            try
            {
                OleDbDataReader reader = oleDbCommand1.ExecuteReader(CommandBehavior.KeyInfo);
                DataTable schema = reader.GetSchemaTable();
                dgvCampos.DataSource = schema;
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void dgvTables_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            FiltraColunasGrids();
        }

        private void ckbTableSys_Click(object sender, EventArgs e)
        {
            FiltraLinhas();
        }

        private void btnDesconecta_Click(object sender, EventArgs e)
        {
            btnConnect.Enabled = true;
            btnCSDialog.Enabled = true;
            btnDesconecta.Enabled = false;
            tbxCS.ReadOnly = false;
            ((DataTable)dgvTables.DataSource).DefaultView.RowFilter = "";
            oleDbConnection1.Close();
            dgvTables.DataSource = null;
            dgvCampos.DataSource = null;
            dgvIndices.DataSource = null;
            dgvSelect.DataSource = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void executarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql;
            if (tbxSQL.SelectionLength == 0)
                sql = tbxSQL.Text;
            else
                sql = tbxSQL.SelectedText;

            if (sql.Substring(0, 6).ToUpper() == "SELECT")
            {
                OleDbDataAdapter da = new OleDbDataAdapter(sql, oleDbConnection1);
                DataSet ds = new DataSet("tabela");

                da.Fill(ds, "tabela");
                dgvSelect.DataSource = ds;
                dgvSelect.DataMember = "tabela";
                tbcComando.SelectedIndex = 1;
                for (int i = 0; i < dgvSelect.Columns.Count; i++)
                {
                    dgvSelect.Columns[i].Width = dgvSelect.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
                }
            }
        }

        private void mudaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                if (tbcComando.SelectedIndex == 0)
                    tbxSQL.Font = fontDialog1.Font;
                else
                {
                    dgvSelect.ColumnHeadersDefaultCellStyle.Font = fontDialog1.Font;
                    dgvSelect.RowsDefaultCellStyle.Font = fontDialog1.Font;

                }
        }

        private void mudaCorDaFonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbcComando.SelectedIndex == 0)
                    tbxSQL.ForeColor = colorDialog1.Color;
                else
                {
                    dgvSelect.ColumnHeadersDefaultCellStyle.ForeColor = colorDialog1.Color;
                    dgvSelect.RowsDefaultCellStyle.ForeColor = colorDialog1.Color;
                }
            }
        }

        private void mudaCorDeFundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (tbcComando.SelectedIndex == 0)
                    tbxSQL.BackColor = colorDialog1.Color;
                else
                {
                    dgvSelect.ColumnHeadersDefaultCellStyle.BackColor = colorDialog1.Color;
                    dgvSelect.RowsDefaultCellStyle.BackColor = colorDialog1.Color;
                }
            }
        }

        private void tbcComando_SelectedIndexChanged(object sender, EventArgs e)
        {
            executarToolStripMenuItem.Visible = tbcComando.SelectedIndex == 0;
            configuraColunasToolStripMenuItem.Visible = tbcComando.SelectedIndex == 1;
            imprimeToolStripMenuItem.Visible = tbcComando.SelectedIndex == 1;
            larguraDasColunasToolStripMenuItem.Visible = tbcComando.SelectedIndex == 1;
        }

        private void configuraColunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfigCol frm = new FrmConfigCol(dgvSelect);
            frm.ShowDialog();


        }

        private void ExpParaXML()
        {
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "Arquivos XML (*.xml)|*.xml|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string xml = ((DataSet)dgvSelect.DataSource).GetXml();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(xml);
                sw.Close();
                process1.StartInfo.FileName = saveFileDialog1.FileName;
                process1.Start();
            }
        }

        private void ExpParaInsert()
        {
            string fileName;
            saveFileDialog1.DefaultExt = "sql";
            saveFileDialog1.Filter = "Script SQL (*.sql)|*.sql|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                fileName = saveFileDialog1.FileName;
            else
                return;

            DataSet ds = (DataSet)dgvSelect.DataSource;
            DataTable table = ds.Tables[0];
            DataRowCollection rows = table.Rows;
            DataColumnCollection cols = table.Columns;
            StringList sl = new StringList();
            string fields = "", insert = "", tabela = "teste", values;
            for (int i = 0; i < cols.Count; i++)
            {
                TypeCode tipo = Type.GetTypeCode(cols[i].DataType);
                if (tipo == TypeCode.Byte || tipo == TypeCode.Decimal ||
                    tipo == TypeCode.Double || tipo == TypeCode.Int16 ||
                    tipo == TypeCode.Int32 || tipo == TypeCode.Int64 ||
                    tipo == TypeCode.String || tipo == TypeCode.DateTime)
                {
                    fields += cols[i].Caption + ",";
                }

            }
            fields = fields.Substring(0, fields.Length - 1);

            try
            {
                for (int i = 0; i < rows.Count; i++)
                {
                    DataRow dr = rows[i];
                    insert = "INSERT INTO " + tabela + " (" + fields + ")";
                    sl.Add(insert);
                    insert = "";
                    values = "";
                    for (int c = 0; c < cols.Count; c++)
                    {
                        TypeCode tipo = Type.GetTypeCode(cols[c].DataType);
                        if (tipo == TypeCode.Byte || tipo == TypeCode.Decimal ||
                            tipo == TypeCode.Double || tipo == TypeCode.Int16 ||
                            tipo == TypeCode.Int32 || tipo == TypeCode.Int64 ||
                            tipo == TypeCode.String || tipo == TypeCode.DateTime)
                        {
                            if (dr[c] == Convert.DBNull)
                                values = values + "NULL,";
                            else
                            {

                                if (tipo == TypeCode.String)
                                {
                                    values = values + "'" + dr[c].ToString() + "',";
                                }
                                else if (tipo == TypeCode.DateTime)
                                {
                                    values = values + "'" + Convert.ToDateTime(dr[c]).ToString("yyyy.MM.dd") + "',";
                                }
                                else if (tipo == TypeCode.Byte || tipo == TypeCode.Decimal ||
                                     tipo == TypeCode.Double || tipo == TypeCode.Int16 ||
                                     tipo == TypeCode.Int32 || tipo == TypeCode.Int64)
                                {
                                    values = values + "" + dr[c].ToString() + ",";
                                }
                            }
                        }
                    }
                    values = values.Substring(0, values.Length - 1);
                    insert = "VALUES (" + values + ")";
                    sl.Add(insert);
                    sl.Add("--");
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                sl.SaveToFile(fileName);
                process1.StartInfo.FileName = fileName;
                process1.Start();
            }
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            if (rbXML.Checked) ExpParaXML();
            else ExpParaInsert();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            process1.StartInfo.FileName = "mailto:magnocsharp@uol.com.br";
            process1.Start();
        }

        private void imprimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlImprime.Visible = true;
            
            for (int i = 0; pnlImprime.Height <= 125; i += 1)
            {                
                pnlImprime.Height += 1;
                pnlImprime.Update();
                this.Update();
            }         
        }

        private void larguraDasColunasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvSelect.Columns.Count; i++)
            {
                dgvSelect.Columns[i].Width = dgvSelect.Columns[i].GetPreferredWidth(DataGridViewAutoSizeColumnMode.AllCells, true);
            }
        }

        private void btnMainFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = tbxMain.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                tbxMain.Font = fontDialog1.Font;
        }

        private void btnSubFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = tbxSub.Font;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                tbxSub.Font = fontDialog1.Font;
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void pnlImprime_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlImprime.Visible = false;
            pnlImprime.Height = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


    }
}
