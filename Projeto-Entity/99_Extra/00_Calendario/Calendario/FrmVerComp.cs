using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calendario
{
    public partial class FrmVerComp : Form
    {
        private struct Agenda
        {
            //private string _obs;
            public DateTime Data;
            public DateTime Hora;
            public string Titulo;
            public string Observacoes;
//            {
//                get { return _obs; }
//                set { _obs = value; }
//            }

            public Agenda(DateTime dt, DateTime hs, string tit, string obs)
            {
                Data = dt;
                Hora = hs;
                Titulo = tit;
                Observacoes = obs;
            }
        }

        List<Agenda> lstAgenda = new List<Agenda>();

        public class OrdAscG : System.Collections.Generic.IComparer<Agenda>
        {
            int System.Collections.Generic.IComparer<Agenda>.Compare(Agenda x, Agenda y)
            {
                //return ((new CaseInsensitiveComparer()).Compare(y, x));
                if (x.Data < y.Data) return -1;
                else if (x.Data > y.Data) return 1;
                else return 0;
            }
        }

        public class OrdDescG : System.Collections.Generic.IComparer<Agenda>
        {
            int System.Collections.Generic.IComparer<Agenda>.Compare(Agenda x, Agenda y)
            {
                //return ((new CaseInsensitiveComparer()).Compare(y, x));
                if (x.Data < y.Data) return 1;
                else if (x.Data > y.Data) return -1;
                else return 0;
            }
        }


        private void LeAgenda()
        {
            StreamReader sr = new StreamReader("Calendario.data");
            Char inicio = '\x0011';
            int ano = 0, mes = 0, dia = 0, hora = 0, min = 0;
            string titulo = "";
            string obs = "";
            lstAgenda.Clear();
            try
            {
                while (!sr.EndOfStream)
                {
                    string linha = sr.ReadLine();

                    if (linha == inicio.ToString())
                    {
                        if (obs != "")
                        {
                            lstAgenda.Add(new Agenda(new DateTime(ano, mes, dia),
                                 new DateTime(1900, 1, 1, hora, min, 0),
                                 titulo, obs));
                            obs = "";
                        }
                        linha = sr.ReadLine();
                        if (!sr.EndOfStream && linha != inicio.ToString())
                        {
                            ano = Convert.ToInt16(linha.Substring(0, 4));
                            mes = Convert.ToInt16(linha.Substring(5, 2));
                            dia = Convert.ToInt16(linha.Substring(8, 2));
                            hora = Convert.ToInt16(linha.Substring(10, 2));
                            min = Convert.ToInt16(linha.Substring(13, 2));
                            titulo = linha.Substring(15, 100);
                        }
                    }
                    else
                        obs = obs + linha + '\r'+'\n';
                }
                lstAgenda.Add(new Agenda(new DateTime(ano, mes, dia),
                              new DateTime(1900, 1, 1, hora, min, 0),
                              titulo, obs));
                lstAgenda.Sort(new OrdAscG());
            }
            catch
            {
                MessageBox.Show("Arquivo corrompido...");
            }
            finally
            {
                sr.Close();
                sr.Dispose();
            }
        }

        void PreencheGrid()
        {
            dgv.Rows.Clear();
            //dgv.RowCount = lstAgenda.Count;
            for (int i = 0; i < lstAgenda.Count; i++)
            {
                if ((lstAgenda[i].Data >= dtp1.Value.Date &&
                     lstAgenda[i].Data <= dtp2.Value.Date) &&
                    (lstAgenda[i].Titulo.IndexOf(tbxAssunto.Text) >= 0 ||
                     tbxAssunto.Text == ""))
                {
                    dgv.Rows.Add();
                    dgv.Rows[dgv.Rows.Count - 2].Cells[0].Value = lstAgenda[i].Data.ToString("dddd - dd/MM/yyyy");
                    dgv.Rows[dgv.Rows.Count - 2].Cells[1].Value = lstAgenda[i].Hora.ToString("HH:mm");
                    dgv.Rows[dgv.Rows.Count - 2].Cells[2].Value = lstAgenda[i].Titulo;
                }
            }           
        }

        public FrmVerComp()
        {
            InitializeComponent();
        }

        private void FrmVerComp_Load(object sender, EventArgs e)
        {
            LeAgenda();
            PreencheGrid();
            
            
        }

        private void dgv_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex<lstAgenda.Count)
                tbxObs.Text = lstAgenda[e.RowIndex].Observacoes;
        }

        private void btnFiltra_Click(object sender, EventArgs e)
        {
            PreencheGrid();
        }

        private void dgv_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {

        }

        private void dgv_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgv.Columns[0].HeaderCell.SortGlyphDirection == SortOrder.Descending ||
                    dgv.Columns[0].HeaderCell.SortGlyphDirection == SortOrder.None)
                {
                    lstAgenda.Sort(new OrdAscG());
                    dgv.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                }
                else
                {
                    lstAgenda.Sort(new OrdDescG());
                    dgv.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                }
                PreencheGrid();
                
                for (int i=1;i<dgv.Columns.Count;i++)
                    dgv.Columns[i].HeaderCell.SortGlyphDirection = SortOrder.None;
            }
            else
                dgv.Columns[0].HeaderCell.SortGlyphDirection = SortOrder.None;
        }
    }
}