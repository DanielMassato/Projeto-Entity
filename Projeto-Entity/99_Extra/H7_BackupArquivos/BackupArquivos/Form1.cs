using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackupArquivos
{
    public partial class Form1 : Form
    {
        List<Arquivos> lstArquivos = new List<Arquivos>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpDe.Value = DateTime.Now.Date.AddDays(-60);
            dtpAte.Value = DateTime.Now.Date;
        }

        private void btnSelDir_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = tbxDir.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tbxDir.Text = folderBrowserDialog1.SelectedPath; ;
            }
        }

        private void btnProcessa_Click(object sender, EventArgs e)
        {
            string[] filtros = tbxFiltro.Text.Split(';');

            lstArquivos.Clear();
            for (int j = 0; j < filtros.Length; j++)
            {
                // using System.IO
                string[] files = Directory.GetFiles(tbxDir.Text, filtros[j].Trim(), ckbIncluiSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                
                for (int i = 0; i < files.Length; i++)
                {
                    DateTime data = File.GetCreationTime(files[i]);
                    if (data >= dtpDe.Value && data <= dtpAte.Value)
                    {
                        lstArquivos.Add(new Arquivos { DataCriacao = data, NomeArquivo = files[i]});
                        dgvArquivos.RowCount++;
                        dgvArquivos[0, i].Value = data.ToString("dd/MM/yyyy");
                        dgvArquivos[1, i].Value = files[i];
                    }
                }
            }

            //dgvArquivos.DataSource = lstArquivos;
        }

        class Arquivos
        {
            public DateTime DataCriacao;
            public string NomeArquivo;
        }

       
    }
}
