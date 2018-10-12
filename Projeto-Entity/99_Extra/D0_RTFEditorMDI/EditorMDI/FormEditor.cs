using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EditorMDI
{
    public partial class FormEditor : Form
    {
        public bool InsertStatus = true;
        public bool Saved = false;
        public string FileName = "Documento1.rtf";

        public FormEditor()
        {
            InitializeComponent();
        }

        

        private void rtfEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // se o Insert estiver desligado E
            if (!InsertStatus &&
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

        private void rtfEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                InsertStatus = !InsertStatus;
        }

        private void FormEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            ((FormPrincipal)this.MdiParent).visualizaOpcoes(1);
            this.Dispose();
        }

        private void FormEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (((FormPrincipal)this.MdiParent).perderAlteracoes() == DialogResult.Cancel)
                e.Cancel = true;
        }
    }
}
