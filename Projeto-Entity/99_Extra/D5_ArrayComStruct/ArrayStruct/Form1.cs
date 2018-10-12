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
        ArrayList lista = new ArrayList();
        // declara um ponteiro para apontar para um elemento 
        // da lista
        int arrPointer = -1;

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
            lblCod.Text = ((Pessoas)lista[ptr]).Codigo.ToString();
            tbxNome.Text = ((Pessoas)lista[ptr]).Nome;
            tbxMail.Text = ((Pessoas)lista[ptr]).EMail;
            tbxFone.Text = ((Pessoas)lista[ptr]).Fone;
            dtpData.Value = ((Pessoas)lista[ptr]).DataNasc;
        }

        private void btnInclui_Click(object sender, EventArgs e)
        {
            lista.Add(new Pessoas(lista.Count + 1,
                                    tbxNome.Text,
                                    tbxMail.Text,
                                    tbxFone.Text,
                                    dtpData.Value));
            arrPointer = lista.Count - 1;
            mostraFicha(arrPointer);
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (arrPointer < 0) return;
            arrPointer = 0;
            mostraFicha(arrPointer);
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (arrPointer < 0) return;
            arrPointer = lista.Count - 1;
            mostraFicha(arrPointer);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (arrPointer < 0) return;
            if (arrPointer > 0) --arrPointer;
            mostraFicha(arrPointer);
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            if (arrPointer < 0) return;
            if (arrPointer < lista.Count-1) ++arrPointer;
            mostraFicha(arrPointer);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(
                                     saveFileDialog1.FileName);
                for (int i = 0; i < lista.Count; i++)
                {
                    sw.WriteLine(((Pessoas)lista[i]).Codigo.ToString() +
                                  "|" + ((Pessoas)lista[i]).Nome + "|" +
                                  ((Pessoas)lista[i]).EMail + "|" +
                                  ((Pessoas)lista[i]).Fone + "|" +
                                  ((Pessoas)lista[i]).DataNasc.ToString());
 
                }
                sw.Close();
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lista.Clear(); // limpa a lista da memória
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                try
                {
                    // enquanto não for final do arqivo
                    while (!sr.EndOfStream)
                    {
                        // lê a linha atual do arquivo texto
                        string linha = sr.ReadLine();
                        // separa os campos da linha pelo caractere "pipe" 
                        string[] dados = linha.Split('|');
                        // insere os dados na lista na memória
                        lista.Add(new Pessoas(int.Parse(dados[0]),
                                                dados[1], dados[2], dados[3],
                                                Convert.ToDateTime(dados[4])));
                    }
                    arrPointer = 0;
                    mostraFicha(arrPointer);
                }
                catch
                {
                    MessageBox.Show("Arquivo inválido...");
                }
                finally
                {
                    sr.Close();
                    sr.Dispose();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            if (arrPointer < 0)
            {
                MessageBox.Show("Lista está vazia...");
                return;
            }
            Pessoas p = new Pessoas(int.Parse(lblCod.Text),
                                     tbxNome.Text,
                                     tbxMail.Text,
                                     tbxFone.Text,
                                     dtpData.Value);
            lista[arrPointer] = p;            
        }

        private void btnExclui_Click(object sender, EventArgs e)
        {
            // verifica se a lista está vazia
            if (arrPointer < 0)
            {
                MessageBox.Show("Lista está vazia...");
                return;
            }
            // pede confirmação para excluir
            if (MessageBox.Show("Confirma Exclusão?", "Cuidado!!!",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2) == DialogResult.No) return;

            // define a posição do ponteiro após a exclusão
            int newPointer;
            if (arrPointer == lista.Count - 1) newPointer = arrPointer - 1;
            else newPointer = arrPointer;
            // apaga o elemento atual
            lista.RemoveAt(arrPointer);
            // reposiciona o ponteiro e mostra o elemento
            if (lista.Count == 0) // excluiu o último elemento
            {
                arrPointer = -1;
                limpaTela();
            }
            else
            {
                arrPointer = newPointer;
                mostraFicha(arrPointer);
            }
        }
        

    }
    struct Pessoas
    {
        public int Codigo;
        public string Nome;
        public string EMail;
        public string Fone;
        public DateTime DataNasc;

        public Pessoas(int codigo, string nome,
                       string email, string fone,
                       DateTime dataNasc)
        {
            Codigo = codigo;
            Nome = nome;
            EMail = email;
            Fone = fone;
            DataNasc = dataNasc;
        }
    }

} // fim do NameSpace
