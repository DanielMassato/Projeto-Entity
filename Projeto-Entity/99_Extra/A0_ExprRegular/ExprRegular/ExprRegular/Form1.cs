using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace ExprRegular
{
    public partial class FormPrincipal : Form
    {
        string appPath;

        public FormPrincipal()
        {
            InitializeComponent();
            appPath = Application.ExecutablePath;
            appPath = Path.GetDirectoryName(appPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(appPath + "\\EXEMPLOS.txt");
            int lin = 0;
            while (!sr.EndOfStream)
            {
                string linha = sr.ReadLine();
                string[] cols = linha.Split(';');
                dgvExemplos.RowCount += 1;
                dgvExemplos.Rows[lin].Cells[0].Value = cols[0];
                dgvExemplos.Rows[lin++].Cells[1].Value = cols[1];
            }
            sr.Close();
            sr.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter(appPath + "\\EXEMPLOS.txt");
            for (int lin = 0; lin < dgvExemplos.Rows.Count; lin++)
            {
                if (dgvExemplos.Rows[lin].Cells[0].Value != null &&
                    dgvExemplos.Rows[lin].Cells[1].Value != null)
                {
                sw.WriteLine(dgvExemplos.Rows[lin].Cells[0].Value.ToString() + ";" +
                             dgvExemplos.Rows[lin].Cells[1].Value.ToString());
                }
            }
            sw.Close();
            sw.Dispose();
        }

        private void btnContem_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(tbxExprReg.Text);
            if (regex.IsMatch(tbxTeste.Text))
                lblResutado.Text = "Ok";
            else
                lblResutado.Text = "Falha";
        }

        private void btnExtrai_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(tbxExprReg.Text);
            Match m = regex.Match(tbxTeste.Text);
            int ini = m.Index;
            int tam = m.Length;
            if (regex.IsMatch(tbxTeste.Text))
                lblResutado.Text = tbxTeste.Text.Substring(ini,tam);
            else
                lblResutado.Text = "Falha";
        }

        private void btnExato_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(tbxExprReg.Text);
            
            Match m = regex.Match(tbxTeste.Text);
            int ini = m.Index;
            int tam = m.Length;
            if (regex.IsMatch(tbxTeste.Text))
            {
                if (tbxTeste.Text.Length == tam)
                    lblResutado.Text = "Exato";
                else
                    lblResutado.Text = "Contem";
            }
            else
                lblResutado.Text = "Falha";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dgvExemplos.RowCount++;
            dgvExemplos.Rows[dgvExemplos.RowCount-1].Cells[0].Value = tbxExprReg.Text;
            dgvExemplos.Rows[dgvExemplos.RowCount-1].Cells[1].Value = "DESCRIÇÃO";
        }

  
    }
}
