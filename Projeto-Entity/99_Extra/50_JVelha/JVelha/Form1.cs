using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JVelha
{
    public partial class Form1 : Form
    {
        int[,] jogo = { {0,0,0},
                        {0,0,0},
                        {0,0,0} };
        string[] sinais = { "O", "X" };

        Random RandomNumber = new Random();

        int Jogador, QuemSaiu, PtsJog1 = 0, PtsJog2 = 0;

        bool SomaColunas(int res, ref int LVazia, ref int Coluna)
        {
            int soma = 0;
            int c;
            for (c = 0; c < 3; c++)
            {
                soma = 0;
                for (int l = 0; l < 3; l++)
                {
                    soma += jogo[l, c];
                    if (jogo[l, c] == 0) LVazia = l;
                }
                if (soma == res) break;
            }
            Coluna = c;
            return (soma == res);
        }

        bool SomaLinhas(int res, ref int Linha, ref int CVazia)
        {
            int soma = 0;
            int l;
            for (l = 0; l < 3; l++)
            {
                soma = 0;
                for (int c = 0; c < 3; c++)
                {
                    soma += jogo[l, c];
                    if (jogo[l, c] == 0) CVazia = c;
                }
                if (soma == res) break;
            }
            Linha = l;
            return (soma == res);
        }

        bool SomaDiag1(int res, ref int LVazia, ref int CVazia)
        {
            int soma = 0;
            int i;
            for (i = 0; i < 3; i++)
            {
                soma += jogo[i, i];
                if (jogo[i, i] == 0) CVazia = i;
            }
            LVazia = CVazia;
            return (soma == res);
        }

        bool SomaDiag2(int res, ref int LVazia, ref int CVazia)
        {
            int soma = 0;
            int i;
            for (i = 0; i < 3; i++)
            {
                soma += jogo[i, 2 - i];
                if (jogo[i, 2 - i] == 0) LVazia = i;
            }
            CVazia = 2 - LVazia;
            return (soma == res);
        }

        int JogadaNumero()
        {
            int nj = 0;
            for (int l = 0; l < 3; l++)
                for (int c = 0; c < 3; c++)
                    if (jogo[l, c] != 0) nj++;
            return nj;
        }

        void ClicaBotao(int l, int c)
        {
            string sTag;
            Button btn;
            for (int i = 0; i < gb.Controls.Count; i++)
            {
                btn = (Button)gb.Controls[i];
                sTag = (string)(Convert.ToString(l + 1) + Convert.ToString(c + 1));
                if ((string)btn.Tag == sTag)
                {

                    btn.PerformClick();
                }
            }
        }

        void JogaAleatorio()
        {
            int l, c;
            do
            {
                l = RandomNumber.Next(0, 3);
                c = RandomNumber.Next(0, 3);
                if (jogo[l, c] == 0)
                {
                    ClicaBotao(l, c);
                    break;
                }
            }
            while (true);
        }

        void ComputadorJoga()
        {
            int l = 0, c = 0;
            int ComeBola = RandomNumber.Next(0, 100);

            label1.Text = Convert.ToString(ComeBola);

            if (rbFacil.Checked)
            {
                if (ComeBola < 30)
                {
                    JogaAleatorio();
                    return;
                }
            }
            else if (rbMedio.Checked)
            {
                if (ComeBola < 15)
                {
                    JogaAleatorio();
                    return;
                }
            }
            else
            {
                if (ComeBola < 5)
                {
                    JogaAleatorio();
                    return;
                }

            }

            if (JogadaNumero() == 0)
                ClicaBotao(1, 1);
            // verifica se o computador está prestes a fechar
            else if (SomaColunas(10, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaLinhas(10, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaDiag1(10, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaDiag2(10, ref l, ref c))
                ClicaBotao(l, c);
            // verifica se o adversário está prestes a fechar
            else if (SomaColunas(2, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaLinhas(2, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaDiag1(2, ref l, ref c))
                ClicaBotao(l, c);
            else if (SomaDiag2(2, ref l, ref c))
                ClicaBotao(l, c);
            else
            {
                if ((QuemSaiu == 1) & (JogadaNumero() == 1))
                {
                    if (jogo[0, 1] == 1) ClicaBotao(0, 0);
                    else if (jogo[1, 2] == 1) ClicaBotao(0, 2);
                    else if (jogo[2, 1] == 1) ClicaBotao(2, 0);
                    else if (jogo[1, 0] == 1) ClicaBotao(0, 0);
                    else if (jogo[1, 1] == 0) ClicaBotao(1, 1);
                    else if (jogo[0, 2] == 0) ClicaBotao(0, 2);
                    else if (jogo[2, 0] == 0) ClicaBotao(2, 0);
                    else if (jogo[2, 2] == 0) ClicaBotao(2, 2);
                    else if (jogo[0, 0] == 0) ClicaBotao(0, 0);
                    else JogaAleatorio();
                }
                else if (QuemSaiu == 2)
                {
                    if (JogadaNumero() == 2)
                    {
                        if ((jogo[1, 0] == 1) | (jogo[0, 1] == 1)) ClicaBotao(0, 0);
                        else if ((jogo[1, 2] == 1) | (jogo[2, 1] == 1)) ClicaBotao(2, 2);
                        else JogaAleatorio();
                    }
                    else if (JogadaNumero() == 4)
                    {
                        if ((jogo[0, 0] == 5) & (jogo[1, 1] == 5) &
                             (jogo[2, 2] == 1 & (jogo[1, 0] == 1)) & (jogo[0, 2] == 0))
                            ClicaBotao(0, 2);
                        else if ((jogo[0, 0] == 5) & (jogo[1, 1] == 5) &
                                  (jogo[2, 2] == 1) & (jogo[0, 1] == 1) & (jogo[2, 0] == 0))
                            ClicaBotao(2, 0);
                        else if ((jogo[2, 2] == 5) & (jogo[1, 1] == 5) &
                                  (jogo[0, 0] == 1) & (jogo[1, 2] == 1) & (jogo[2, 0] == 0))
                            ClicaBotao(2, 0);
                        else if ((jogo[2, 2] == 5) & (jogo[1, 1] == 5) &
                                  (jogo[0, 0] == 1) & (jogo[2, 1] == 1) & (jogo[0, 2] == 0))
                            ClicaBotao(0, 2);
                        else JogaAleatorio();
                    }
                    else JogaAleatorio();
                }
                else JogaAleatorio();
            }

        }

        void CorrigePlacar()
        {
            lblPtsO.Text = PtsJog1.ToString("0000");// Convert.ToString(PtsJog1);
            lblPtsX.Text = PtsJog2.ToString("0000"); //Convert.ToString(PtsJog2);
        }

        void FinalizaJogo(byte status)
        {
            gb.Enabled = false;
            btnInicia.Enabled = true;
            if (status == 0)
            {
                lblMsg.Text = "Jogador '" + Jogador + "' Ganhou...";
                lblMsg.ImageIndex = Jogador - 1;
                if (Jogador == 1)
                {
                    PtsJog1++;
                    System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"r2d2.wav");
                    Sound.Play();
                }
                else
                {
                    System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"jaba.wav");
                    Sound.Play();
                    PtsJog2++;
                }
                CorrigePlacar();
            }
            else
            {
                lblMsg.Text = "Jogo empatado...";
                lblMsg.ImageIndex = -1;
                System.Media.SoundPlayer Sound = new System.Media.SoundPlayer(@"ringout.wav");
                Sound.Play();
            }

            lblMsg.Update();
        }

        bool FechouLinha()
        {
            int l, c, soma;
            bool result = false;
            for (l = 0; l < 3; l++)
            {
                soma = 0;
                for (c = 0; c < 3; c++)
                {
                    soma += jogo[l, c];
                    if ((soma == 3) | (soma == 15))
                    {
                        result = true;
                        FinalizaJogo(0);
                        break;
                    }
                }
                if (result) break;
            }
            return result;
        }

        bool FechouColuna()
        {
            int l, c, soma;
            bool result = false;
            for (c = 0; c < 3; c++)
            {
                soma = 0;
                for (l = 0; l < 3; l++)
                {
                    soma += jogo[l, c];
                    if ((soma == 3) | (soma == 15))
                    {
                        result = true;
                        FinalizaJogo(0);
                        break;
                    }
                }
                if (result) break;
            }
            return result;
        }

        bool FechouDiagonal()
        {
            int i, soma1 = 0, soma2 = 0;
            bool result = false;
            for (i = 0; i < 3; i++)
            {
                soma1 += jogo[i, i];
                soma2 += jogo[2 - i, i];
            }
            if ((soma1 == 3) | (soma1 == 15) | (soma2 == 3) | (soma2 == 15))
            {
                result = true;
                FinalizaJogo(0);

            }
            return result;
        }

        bool JogoEmpatado()
        {
            int l, c;
            bool result = true;
            for (c = 0; c < 3; c++)
            {
                for (l = 0; l < 3; l++)
                {
                    if (jogo[l, c] == 0)
                    {
                        result = false;
                    }
                }
            }
            if (result) FinalizaJogo(1);
            return result;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int linha = Convert.ToInt32(btn.Tag) / 10 - 1;
            int coluna = Convert.ToInt32(btn.Tag) % 10 - 1;
            lblMsg.Text = "";
            lblMsg.ImageIndex = -1;
            if (jogo[linha, coluna] != 0)
            {
                lblMsg.Text = "Posição Ocupada...";
                lblMsg.ImageIndex = -1;
                return;
            }
            //btn.Text = sinais[Jogador-1];

            btn.ImageIndex = Jogador - 1;

            if (Jogador == 1)
                jogo[linha, coluna] = 1;
            else
                jogo[linha, coluna] = 5;

            btn.Enabled = false;

            if (FechouLinha()) return;
            if (FechouColuna()) return;
            if (FechouDiagonal()) return;

            if (JogoEmpatado()) return;

            if (Jogador == 1)
                Jogador = 2;
            else
                Jogador = 1;

            lblMsg.Text = "Jogador '" + Jogador + "' Joga";
            lblMsg.ImageIndex = Jogador - 1;

            if ((Jogador == 2) & (rbComputador.Checked))
                ComputadorJoga();

        }

        private void btnInicia_Click(object sender, EventArgs e)
        {
            gb.Enabled = true;
            btnInicia.Enabled = false;

            for (int l = 0; l < 3; l++)
                for (int c = 0; c < 3; c++)
                {
                    jogo[l, c] = 0;
                }

            for (int i = 0; i < gb.Controls.Count; i++)
            {
                Button btn = (Button)gb.Controls[i];
                btn.Enabled = true;
                btn.ImageIndex = -1;
            }

            if (Jogador == 1)
                Jogador = 2;
            else
                Jogador = 1;

            QuemSaiu = Jogador;

            if ((Jogador == 2) & (rbComputador.Checked))
            {
                ComputadorJoga();
            }
            lblMsg.Text = "VOCÊ JOGA";
            lblMsg.ImageIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Jogador = RandomNumber.Next(10) % 2 + 1;
        }

        private void rbComputador_Click(object sender, EventArgs e)
        {
            gbNivel.Enabled = rbComputador.Checked;
        }
    }
}