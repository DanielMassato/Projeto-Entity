using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace RTFEditor
{
    public partial class Form1 : Form
    {
        // variável para armazenar o status da tecla insert
        bool insertStatus = true;
        bool saved = false;
        string fileName = "Documento1.rtf";
        private int checkPrint;

        Thread p;

        public Form1()
        {
            InitializeComponent();
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
           
        }

        // método auxiliar para sinalizar o status da tecla CapsLock
        private void verificaCapsLock()
        {
            if (Console.CapsLock)
                slblCaps.ForeColor = Color.Blue;
            else
                slblCaps.ForeColor = Color.Gray;
        }
        // método auxiliar para sinalizar o status da tecla NumLock
        private void verificaNumLock()
        {
            if (Console.NumberLock)
                slblNum.ForeColor = Color.Blue;
            else
                slblNum.ForeColor = Color.Gray;
        }
        // método auxiliar para sinalizar status da tecla Insert
        private void verificaInsert()
        {
            if (insertStatus)
                slblIns.ForeColor = Color.Blue;
            else
                slblIns.ForeColor = Color.Gray;
        }
        // método auxiliar para avisar que texto não foi salvo
        private DialogResult perderAlteracoes()
        {
            // se o texto não foi alterado, não precisa perguntar nada
            if (!rtfEditor.Modified) return System.Windows.Forms.DialogResult.No;

            // se chegar aqui é porque o texto foi alterado (perguntar)
            DialogResult r = MessageBox.Show(
                  "Texto não foi salvo. Salvar alterações?", // texto interno
                  "Cuidado !!!", // título da janela
                  MessageBoxButtons.YesNoCancel, // conjunto de botões
                  MessageBoxIcon.Warning
                                );
            if (r == DialogResult.Yes) salvarMenuItem1.PerformClick();
            return r;
        }

        delegate void AtualizaTelaHandler();

        void atualizaTela()
        {
            try
            {
                if (!tscmbFontName.Focused)
                    tscmbFontName.SelectedItem = rtfEditor.SelectionFont.Name;
                if (!tscmbFontSize.Focused)
                    tscmbFontSize.SelectedItem = rtfEditor.SelectionFont.Size.ToString();

                negritoToolStripMenuItem.Checked = ((FontStyle.Bold & rtfEditor.SelectionFont.Style) == FontStyle.Bold);
                itálicoToolStripMenuItem.Checked = ((FontStyle.Italic & rtfEditor.SelectionFont.Style) == FontStyle.Italic);
                sublinhadoToolStripMenuItem.Checked = ((FontStyle.Underline & rtfEditor.SelectionFont.Style) == FontStyle.Underline);

                tsbtnNegrito.Checked = negritoToolStripMenuItem.Checked;
                tsbtnItalico.Checked = itálicoToolStripMenuItem.Checked;
                tsbtnSublinhado.Checked = sublinhadoToolStripMenuItem.Checked;
                //marcaTexto();
            }
            catch
            {
                tscmbFontName.SelectedItem = null;
                tscmbFontSize.SelectedItem = null;
            }

        }

        void threadAtualizaTela()
        {
            AtualizaTelaHandler d = atualizaTela;

            while (true)
            {
                Invoke(d, new object[] { });
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
                tscmbFontName.Items.Add(fonts.Families[i].Name);

            tscmbFontName.SelectedItem = rtfEditor.SelectionFont.Name; ;
            tscmbFontSize.SelectedItem = rtfEditor.SelectionFont.Size;
            tscmbZoom.SelectedIndex = 2;

            p = new Thread(new ThreadStart(threadAtualizaTela));
            p.Priority = ThreadPriority.Normal;
            p.Start();

            Text = "Editor de Textos - " + fileName;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
                verificaCapsLock();
            if (e.KeyCode == Keys.NumLock)
                verificaNumLock();
            if (e.KeyCode == Keys.Insert)
            {
                insertStatus = !insertStatus;
                verificaInsert();
            }
        }

        private void rtfEditor_TextChanged(object sender, EventArgs e)
        {
            slblStatus.Text = "Modificado";
        }

        private void rtfEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // se o Insert estiver desligado E
            if (!insertStatus &&
                // não existirem caracteres selecionados E
                rtfEditor.SelectionLength == 0 &&
                // a tecla pressionada não for BackSpace
                e.KeyChar != '\x8' &&
                // a tecla não for ENTER
                e.KeyChar != '\xD')
            {
                // selecionar o caractere seguinte a posição atual do cursor
                rtfEditor.SelectionLength = 1;
            }
        }

        void salvarTexto()
        {
            rtfEditor.SaveFile(fileName);
            slblStatus.Text = "Gravado";
            rtfEditor.Modified = false;
            saved = true;
            Text = "Editor de Textos - " + fileName;
        }

        private void salvarMenuItem1_Click(object sender, EventArgs e)
        {
            // abrir a janela de salvar
            if (!saved)
            {
                if (dls.ShowDialog() == DialogResult.OK)
                    fileName = dls.FileName;
                else
                    return;
            }
            
            salvarTexto();            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dls.ShowDialog() == DialogResult.OK)
            {
                fileName = dls.FileName;
                salvarTexto();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se não quiser perder as alterações, sair do método
            if (perderAlteracoes()== DialogResult.Cancel) return;

            rtfEditor.Clear();
            // OU
            // tbxEditor.Text = "";
            dls.FileName = "Documento1.rtf";
            fileName = "Documento1.rtf";
            slblStatus.Text = "Gravado";
            rtfEditor.Modified = false;
            saved = false;
            Text = "Editor de Textos - " + fileName;
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // se não quiser perder as alterações, sair do método
            if (perderAlteracoes() == DialogResult.Cancel) return;

            if (dlo.ShowDialog() == DialogResult.OK)
            {
                rtfEditor.LoadFile(dlo.FileName);
                dls.FileName = dlo.FileName;                     
                fileName  = dlo.FileName;
                // sinalizar que não foi alterado
                slblStatus.Text = "Gravado";
                rtfEditor.Modified = false;
                saved = true;
                Text = "Editor de Textos - " + fileName;
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (perderAlteracoes() == DialogResult.Cancel)
                // cancela o fechamento do form
                e.Cancel = true;
            else
                p.Abort();
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlf.Font = rtfEditor.SelectionFont;

            if (dlf.ShowDialog() == DialogResult.OK)
                rtfEditor.SelectionFont = dlf.Font;
        }

        private void tscmbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscmbFontName.SelectedItem != null)
                try
                {
                    rtfEditor.SelectionFont = new Font(tscmbFontName.SelectedItem.ToString(), rtfEditor.SelectionFont.Size);
                }
                catch
                {
                }
        }

        private void tscmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tscmbFontSize.SelectedItem != null)
            {
                float f;
                float.TryParse(tscmbFontSize.SelectedItem.ToString(), out f);
                try
                {
                    rtfEditor.SelectionFont = new Font(rtfEditor.SelectionFont.Name, f);
                }
                catch
                {
                }
            }
        }

        private void fonteCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dlcor.Color = rtfEditor.SelectionColor;
            if (dlcor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtfEditor.SelectionColor = dlcor.Color;
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionFont = new Font(rtfEditor.SelectionFont, FontStyle.Bold | rtfEditor.SelectionFont.Style);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionFont = new Font(rtfEditor.SelectionFont, FontStyle.Underline | rtfEditor.SelectionFont.Style);
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionFont = new Font(rtfEditor.SelectionFont, FontStyle.Italic | rtfEditor.SelectionFont.Style);
        }

        private void avançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionIndent += 20;
        }

        private void recuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rtfEditor.SelectionIndent > 0)
            rtfEditor.SelectionIndent -= 20;
        }

        private void tscmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tscmbZoom.SelectedIndex)
            {
                case 0: rtfEditor.ZoomFactor = (float)0.50;
                    break;
                case 1: rtfEditor.ZoomFactor = (float)0.75;
                    break;
                case 2: rtfEditor.ZoomFactor = (float)1;
                    break;
                case 3: rtfEditor.ZoomFactor = (float)1.25;
                    break;
                case 4: rtfEditor.ZoomFactor = (float)1.5;
                    break;

            }
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void marcadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtfEditor.SelectionBullet = !rtfEditor.SelectionBullet;
            marcadorToolStripMenuItem.Checked = rtfEditor.SelectionBullet;
        }

        private void numeraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Print the content of RichTextBox. Store the last character printed.
            checkPrint = rtfEditor.Print(checkPrint, rtfEditor.TextLength, e);

            // Check for more pages
            if (checkPrint < rtfEditor.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //rtfEditor.Selected = "magno";
        }

        private void marcaTexto()
        {
            // Calculate the starting position of the current line.
            int start = 0, end = 0;
            for (start = rtfEditor.SelectionStart - 1; start > 0; start--)
            {
                if (rtfEditor.Text[start] == '\n') { start++; break; }
            }
            // Calculate the end position of the current line.
            for (end = rtfEditor.SelectionStart; end < rtfEditor.Text.Length; end++)
            {
                if (rtfEditor.Text[end] == '\n') break;
            }
            // Extract the current line that is being edited.
            String line = rtfEditor.Text.Substring(start, end - start);
            // Backup the users current selection point.
            int selectionStart = rtfEditor.SelectionStart;
            int selectionLength = rtfEditor.SelectionLength;
            // Split the line into tokens.
            Regex r = new Regex("([ \\t{}();])");
            string[] tokens = r.Split(line);
            int index = start;
            foreach (string token in tokens)
            {
                // Set the token's default color and font.
                rtfEditor.SelectionStart = index;
                rtfEditor.SelectionLength = token.Length;
                rtfEditor.SelectionColor = Color.Black;
                //rtfEditor.SelectionFont = new Font("Courier New", 10,
                //FontStyle.Regular);
                // Check whether the token is a keyword.
                String[] keywords = { "public", "void", "using", "static", "class" };
                for (int i = 0; i < keywords.Length; i++)
                {
                    if (keywords[i] == token)
                    {
                        // Apply alternative color and font to highlight keyword.                        
                        rtfEditor.SelectionColor = Color.Blue;
                        rtfEditor.SelectionFont = new Font(rtfEditor.SelectionFont.Name,
                            rtfEditor.SelectionFont.Size, FontStyle.Bold);
                        //break;
                    }

                    index += token.Length;
                }
                // Restore the users current selection point.
                rtfEditor.SelectionStart = selectionStart;
                rtfEditor.SelectionLength = selectionLength;
            }
        }
    }
}