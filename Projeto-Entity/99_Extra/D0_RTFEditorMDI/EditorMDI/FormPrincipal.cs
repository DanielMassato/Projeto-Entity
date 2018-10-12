using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Text;
using LibComponentes;

namespace EditorMDI
{
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Thread para sinalizar font, estilo, status do teclado etc...
        /// </summary>
        Thread p;
        bool candelaThread = false;
        int checkPrint;

        public FormPrincipal()
        {
            InitializeComponent();
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        //---------------------------------------------- Métodos auxiliares ----------------        
        /// <summary>
        /// sinaliza o status da tecla CapsLock
        /// </summary>
        private void verificaCapsLock()
        {
            if (Console.CapsLock)
                slblCaps.ForeColor = Color.Blue;
            else
                slblCaps.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Sinaliza o status da tecla NumLock
        /// </summary>
        private void verificaNumLock()
        {
            if (Console.NumberLock)
                slblNum.ForeColor = Color.Blue;
            else
                slblNum.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Sinaliza o status da tecla Insert
        /// </summary>
        private void verificaInsert()
        {
            if (((FormEditor)ActiveMdiChild).InsertStatus)
                slblIns.ForeColor = Color.Blue;
            else
                slblIns.ForeColor = Color.Gray;
        }

        /// <summary>
        /// Método que verifica se o texto foi salvo. Se não foi salvo, pergunta se deseja salvar
        /// </summary>
        /// <returns>Resposta à pergunta, que pode ser Yes, No ou Cancel</returns>
        public DialogResult perderAlteracoes()
        {
            //if (this.MdiChildren.Length == 0) return DialogResult.No;
            // se o texto não foi alterado, não precisa perguntar nada
            if (!((FormEditor)ActiveMdiChild).rtfEditor.Modified) return System.Windows.Forms.DialogResult.No;

            // se chegar aqui é porque o texto foi alterado (perguntar)
            DialogResult r = MessageBox.Show(
                  "Texto não foi salvo. Salvar alterações?", // texto interno
                  "Cuidado !!!", // título da janela
                  MessageBoxButtons.YesNoCancel, // conjunto de botões
                  MessageBoxIcon.Warning
                                );
            if (r == DialogResult.Yes) salvarToolStripMenuItem.PerformClick();
            return r;
        }

        public void visualizaOpcoes(int n)
        {
            foreach (ToolStripMenuItem m in menuStrip1.Items)
            {
                if (m.Tag != null)
                    if (m.Tag.ToString() == "1")
                        m.Visible =  this.MdiChildren.Length > n;
            }
            foreach (ToolStripItem i in toolStrip2.Items)
            {
                if (i.Tag != null)
                    if (i.Tag.ToString() == "1")
                        i.Visible = this.MdiChildren.Length > n;
            }
        }

        /// <summary>
        /// Delegate utilizado pelo Thread para que ele possa acessar os controles do formulário
        /// </summary>
        delegate void AtualizaTelaHandler();

        /// <summary>
        /// Método usado pelo Thread para atualizar a tela
        /// </summary>
        void atualizaTela()
        {
            if (this.MdiChildren.Length == 0) return;
            try
            {
                FormEditor frm = (FormEditor)ActiveMdiChild;
                if (!tscmbFontName.Focused)
                    tscmbFontName.SelectedItem = frm.rtfEditor.SelectionFont.Name;
                if (!tscmbFontSize.Focused)
                    tscmbFontSize.SelectedItem = frm.rtfEditor.SelectionFont.Size.ToString();

                negritoToolStripMenuItem.Checked = ((FontStyle.Bold & frm.rtfEditor.SelectionFont.Style) == FontStyle.Bold);
                itálicoToolStripMenuItem.Checked = ((FontStyle.Italic & frm.rtfEditor.SelectionFont.Style) == FontStyle.Italic);
                sublinhadoToolStripMenuItem.Checked = ((FontStyle.Underline & frm.rtfEditor.SelectionFont.Style) == FontStyle.Underline);
                marcadorToolStripMenuItem.Checked = frm.rtfEditor.SelectionBullet;

                tsbtnNegrito.Checked = negritoToolStripMenuItem.Checked;
                tsbtnItalico.Checked = itálicoToolStripMenuItem.Checked;
                tsbtnSublinhado.Checked = sublinhadoToolStripMenuItem.Checked;
                verificaCapsLock();
                verificaInsert();
                verificaNumLock();
                slblStatus.Text = frm.rtfEditor.Modified ? "Modificado" : "Gravado";                

                //marcaTexto();
            }
            catch
            {
                tscmbFontName.SelectedItem = null;
                tscmbFontSize.SelectedItem = null;
            }

        }

        /// <summary>
        /// Método de partida do Thread
        /// </summary>
        void threadAtualizaTela()
        {
            AtualizaTelaHandler d = atualizaTela;

            while (!candelaThread)
            {
                Invoke(d, new object[] { });
            }
        }

        /// <summary>
        /// Método que salva o texto da janela atual
        /// </summary>
        void salvarTexto()
        {
            FormEditor frm = (FormEditor)ActiveMdiChild;
            frm.rtfEditor.SaveFile(frm.FileName);
            slblStatus.Text = "Gravado";
            frm.rtfEditor.Modified = false;
            frm.Saved = true;
            frm.Text = "Editor de Textos - " + frm.FileName;
        }

        //---------------------------------------------------------- fim 

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            // lê a lista do fontes instladas no Windows
            InstalledFontCollection fonts = new InstalledFontCollection();
            // Carrega o comboBox com os nomes das fontes
            for (int i = 0; i < fonts.Families.Length; i++)
                tscmbFontName.Items.Add(fonts.Families[i].Name);
            // inicializa os comboBox
            tscmbFontName.SelectedItem = null;
            tscmbFontSize.SelectedItem = null;
            tscmbZoom.SelectedIndex = 2;
            // cria e dá partida no Thread de atualização de tela
            p = new Thread(new ThreadStart(threadAtualizaTela));
            p.Priority = ThreadPriority.Normal;
            p.Start();
            visualizaOpcoes(0);
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // finaliza o Thread
            candelaThread = true;
            p.Abort();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor frm = new FormEditor();
            frm.MdiParent = this;
            frm.FileName = "Documento" + (this.MdiChildren.Length + 1) + ".rtf";
            frm.Text = "Editor de Textos - " + frm.FileName;
            frm.Show();
            visualizaOpcoes(0);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void cascataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ActiveMdiChild.Close();
        }

        private void fecharTodasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            while (this.MdiChildren.Length > 0)
                this.MdiChildren[0].Close();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!((FormEditor)ActiveMdiChild).Saved)
            {
                saveFileDialog1.FileName = ((FormEditor)ActiveMdiChild).FileName;
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    ((FormEditor)ActiveMdiChild).FileName = saveFileDialog1.FileName;
                else
                    return;
            }

            salvarTexto();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = ((FormEditor)ActiveMdiChild).FileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ((FormEditor)ActiveMdiChild).FileName = saveFileDialog1.FileName;
                salvarTexto();
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FormEditor frm = new FormEditor();
                frm.MdiParent = this;
                frm.FileName = openFileDialog1.FileName;
                frm.rtfEditor.LoadFile(frm.FileName);
                saveFileDialog1.FileName = frm.FileName;

                frm.rtfEditor.Modified = false;
                frm.Saved = true;
                frm.Text = "Editor de Textos - " + frm.FileName;
                frm.Show();
                visualizaOpcoes(0);
            }
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = ((FormEditor)ActiveMdiChild).rtfEditor.SelectionFont;

            if (fontDialog1.ShowDialog() == DialogResult.OK)
                ((FormEditor)ActiveMdiChild).rtfEditor.SelectionFont = fontDialog1.Font;
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            rtf.SelectionFont = new Font(rtf.SelectionFont, FontStyle.Bold | rtf.SelectionFont.Style);
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            rtf.SelectionFont = new Font(rtf.SelectionFont, FontStyle.Underline | rtf.SelectionFont.Style);
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            rtf.SelectionFont = new Font(rtf.SelectionFont, FontStyle.Italic | rtf.SelectionFont.Style);
        }

        private void fonteCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            colorDialog1.Color = rtf.SelectionColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                rtf.SelectionColor = colorDialog1.Color;
        }

        private void avançoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormEditor)ActiveMdiChild).rtfEditor.SelectionIndent += 20;
        }

        private void recuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            if (rtf.SelectionIndent > 0)
                rtf.SelectionIndent -= 20;
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormEditor)ActiveMdiChild).rtfEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormEditor)ActiveMdiChild).rtfEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormEditor)ActiveMdiChild).rtfEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void marcadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((FormEditor)ActiveMdiChild).rtfEditor.SelectionBullet = !((FormEditor)ActiveMdiChild).rtfEditor.SelectionBullet;
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            checkPrint = 0;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            RichTextBoxPrintCtrl rtf = ((FormEditor)ActiveMdiChild).rtfEditor;

            checkPrint = rtf.Print(checkPrint, rtf.TextLength, e);

            if (checkPrint < rtf.TextLength)
                e.HasMorePages = true;
            else
                e.HasMorePages = false;
        }

        private void visualizarImpressãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (printDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tscmbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0) return;
            if (tscmbFontName.SelectedItem != null)
                try
                {
                    RichTextBoxPrintCtrl rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
                    rtf.SelectionFont = new Font(tscmbFontName.SelectedItem.ToString(), rtf.SelectionFont.Size);
                }
                catch
                {
                }
        }

        private void tscmbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0) return;
            if (tscmbFontSize.SelectedItem != null)
            {
                float f;
                float.TryParse(tscmbFontSize.SelectedItem.ToString(), out f);
                try
                {
                    RichTextBoxPrintCtrl rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
                    rtf.SelectionFont = new Font(rtf.SelectionFont.Name, f);
                }
                catch
                {
                }
            }
        }


        private void tscmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length == 0) return;
            RichTextBoxPrintCtrl rtf = ((FormEditor)ActiveMdiChild).rtfEditor;
            switch (tscmbZoom.SelectedIndex)
            {
                case 0: rtf.ZoomFactor = (float)0.50;
                    break;
                case 1: rtf.ZoomFactor = (float)0.75;
                    break;
                case 2: rtf.ZoomFactor = (float)1;
                    break;
                case 3: rtf.ZoomFactor = (float)1.25;
                    break;
                case 4: rtf.ZoomFactor = (float)1.5;
                    break;

            }
        }
    }
}
