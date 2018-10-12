using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calendario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            process1.Start();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.SelectionStart = DateTime.Now.AddMonths(-1);
            monthCalendar1.SelectionEnd = DateTime.Now.AddMonths(-1);

            monthCalendar3.SelectionStart = DateTime.Now.AddMonths(1);
            monthCalendar3.SelectionEnd = DateTime.Now.AddMonths(1);

            Text = Text + " Versão " + Application.ProductVersion;
        }

        private void btnSomaDias_Click(object sender, EventArgs e)
        {
            if (!ckbDiasUteis.Checked)
                lblDt1.Text = monthCalendar1.SelectionStart.AddDays(tbxfDias.Value).ToString("dd/MM/yyyy");
            else
            {
                DateTime dt = monthCalendar1.SelectionStart;
                int i = 1;
                while ( i <= tbxfDias.Value )
                {
                    dt = dt.AddDays(1);
                    if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                        continue;
                    i++;
                }
                lblDt1.Text = dt.ToString("dd/MM/yyyy");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!ckbDiasUteis.Checked)
                lblDt1.Text = monthCalendar1.SelectionStart.AddDays(-tbxfDias.Value).ToString("dd/MM/yyyy");
            else
            {
                DateTime dt = monthCalendar1.SelectionStart;
                int i = 1;
                while (i <= tbxfDias.Value)
                {
                    dt = dt.AddDays(-1);
                    if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                        continue;
                    i++;
                }
                lblDt1.Text = dt.ToString("dd/MM/yyyy");
            }
        }

        private void ckbManterAFrente_Click(object sender, EventArgs e)
        {
            this.TopMost = ckbManterAFrente.Checked;
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ckbDU2.Checked)
                lblDias.Text = (monthCalendar3.SelectionStart.Subtract(dtp.Value).Days + 1).ToString();
            else
            {
                int i = 0;
                DateTime dt = monthCalendar3.SelectionStart.Date;
                while (dt > dtp.Value.Date)
                {
                    if (dt.DayOfWeek != DayOfWeek.Sunday && dt.DayOfWeek != DayOfWeek.Saturday)
                        i++;
                    dt = dt.AddDays(-1);
                }
                lblDias.Text = i.ToString();
            }
        }

        private void adicionaCompromissoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            ContextMenuStrip m = (ContextMenuStrip)(mi.Owner);
            DateTime dt = ((MonthCalendar)(m.SourceControl)).SelectionStart;

            FrmAddComp frm = new FrmAddComp(dt);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void consultaCompromissosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVerComp frm = new FrmVerComp();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}