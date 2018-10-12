using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace ArrayStruct
{
    public partial class Form1 : Form
    {


        // declara a variável para armazenar uma lista de pessoas
        Pessoas p = new Pessoas();
        // declara um ponteiro para apontar para um elemento 
        // da lista
        //int arrPointer = -1;

        public Form1()
        {
            InitializeComponent();
        }

        // limpar os dados da tela
        void limpaTela()
        {
            lblCod.Text = "0";
            tbxNome.Clear();
            tbxMail.Clear();
            tbxFone.Clear();
            dtpData.Value = DateTime.Now;
        }

        // mostrar na tela um elemento da lista
        
        void mostraFicha(int ptr)
        {
            lblCod.Text = p.Codigo.ToString();
            tbxNome.Text = p.Nome;
            tbxMail.Text = p.EMail;
            tbxFone.Text = p.Fone;
            dtpData.Value = p.DataNasc;
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            p.Add( tbxNome.Text, tbxMail.Text, tbxFone.Text, dtpData.Value);
            mostraFicha(p.Position);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            p.MoveFirt();
            mostraFicha(p.Position);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            p.MoveLast();
            mostraFicha(p.Position);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (p.MovePrevious()) mostraFicha(p.Position);
            else MessageBox.Show("Início do Arquivo...");
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (p.MoveNext()) mostraFicha(p.Position);
            else MessageBox.Show("Fim do Arquivo...");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.SaveToFile(saveFileDialog1.FileName);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                p.LoadFromFile(openFileDialog1.FileName);
                mostraFicha(p.Position);
            }
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            if (p.Position >= 0)
            {
                p.Nome = tbxNome.Text;
                p.EMail = tbxMail.Text;
                p.Fone = tbxFone.Text;
                p.DataNasc = dtpData.Value;                        
            }
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            if (p.Position >= 0)
            {
                if (p.RemoveAt(p.Position))
                {
                    if (p.Position>=0) mostraFicha(p.Position);
                }
            }
        }
        

    }
    
} // fim do NameSpace
