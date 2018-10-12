using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ProcessaArquivos
{
    public partial class Form1 : Form
    {
        string filename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 16; i++)
            {
                dgvBytes.Columns.Add("col" + i,(i+1).ToString("00"));
                dgvBytes.Columns[i].Width = 30;
                dgvBytes.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgvBytes.RowHeadersWidth = 60;
            dgvBytes.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
            // using System.IO
            string[] files = Directory.GetFiles(tbxDir.Text, tbxFiltro.Text, ckbIncluiSub.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
            for (int i = 0; i < files.Length; i++)
            {
                lbxArquivos.Items.Add(files[i]);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                abreTexto();
            if (tabControl1.SelectedIndex == 2)
                abreBinario();
        }

        void abreTexto()
        {
            //if (filename == lbxArquivos.SelectedItem.ToString()) return;
            filename = lbxArquivos.SelectedItem.ToString();
            StreamReader sr = new StreamReader(lbxArquivos.SelectedItem.ToString());
            tbxTexto.Text = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();
        }

        void abreBinario()
        {
            //if (filename == lbxArquivos.SelectedItem.ToString()) return;
            filename = lbxArquivos.SelectedItem.ToString();

            FileStream fileStream = new FileStream(lbxArquivos.SelectedItem.ToString(), FileMode.Open);
            int length = (int)fileStream.Length;  
            //byte[] buffer = new byte[length]; 
            int linha = 0;
            dgvBytes.RowCount = 1;
            for (int i = 0; i<length;i++)
            {
                int b = 0;
               
                dgvBytes.RowCount++;
                for (int j = 0; j < 16 && i < length; j++)
                {
                    b = fileStream.ReadByte();
                    if (b < 0) break;

                    if (rbHex.Checked)
                        dgvBytes.Rows[linha].Cells[j].Value = Convert.ToString(b, 16).ToUpper();
                    else
                        dgvBytes.Rows[linha].Cells[j].Value = b;

                }
                linha++;
                if (b < 0) break;
            }
            fileStream.Dispose();
        }

        private void rbInt_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                filename = "";
                abreBinario();
            }
        }


        private void dgvBytes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (rbHex.Checked)
                dgvBytes.Rows[e.RowIndex].HeaderCell.Value = Convert.ToString(e.RowIndex,16).ToUpper().PadLeft(4,'0');
            else
                dgvBytes.Rows[e.RowIndex].HeaderCell.Value = e.RowIndex.ToString("0000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbxTexto.Text = tbxTexto.Text.Replace("\xA", "\xD\xA");
            StreamWriter sw = new StreamWriter(@"C:\Magno\ConversaComRegiane.txt");
            sw.Write(tbxTexto.Text);
            sw.Close();
        }

    
    }
}
