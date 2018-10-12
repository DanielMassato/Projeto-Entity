using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        enum TipoDesenho
        {
            Nenhum, Retangulo, Elipse,
            LinhasHV, LinhasDiag, Poligono, Bitmap,
            Bandeira
        };

        TipoDesenho tipoDesenho;

        public Form1()
        {
            InitializeComponent();
        }

        private void lblLinha_Click(object sender, EventArgs e)
        {
            if (dlgCor.ShowDialog() == DialogResult.OK)
                lblLinha.BackColor = dlgCor.Color;
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {
            if (dlgCor.ShowDialog() == DialogResult.OK)
                lblFundo.BackColor = dlgCor.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int tag = Convert.ToInt32(btn.Tag);
            tipoDesenho = (TipoDesenho)tag;
            // força o Panel a se redesenhar
            pnl.Invalidate();
        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            // definir variável de preenchimento
            Brush fundo = new SolidBrush(lblFundo.BackColor);
            // definir variável de "caneta" par desenho de linha
            Pen p = new Pen(lblLinha.BackColor, 2);
            // denhar o retângulo
            if (tipoDesenho == TipoDesenho.Retangulo)
            {
                // preencher o fundo
                e.Graphics.FillRectangle(fundo,
                    0, 0, pnl.Width, pnl.Height);
                // desenhar a borda
                e.Graphics.DrawRectangle(p,
                    0, 0, pnl.Width, pnl.Height);
            }
            // desenhar a Elipse
            if (tipoDesenho == TipoDesenho.Elipse)
            {
                // preencher o fundo
                e.Graphics.FillEllipse(fundo,
                    0, 0, pnl.Width, pnl.Height);
                // desenhar a borda
                e.Graphics.DrawEllipse(p,
                    0, 0, pnl.Width, pnl.Height);
            }
            // linhas horiz e verticais
            if (tipoDesenho == TipoDesenho.LinhasHV)
            {
                // linha horizontal
                e.Graphics.DrawLine(p,
                    0, pnl.Height / 2,
                    pnl.Width, pnl.Height / 2);
                // linha vertical
                e.Graphics.DrawLine(p,
                    pnl.Width / 2, 0,
                    pnl.Width / 2, pnl.Height);
            }
            // linhas horiz e verticais
            if (tipoDesenho == TipoDesenho.LinhasDiag)
            {
                // linha horizontal
                e.Graphics.DrawLine(p,
                    0, 0, pnl.Width, pnl.Height );
                // linha vertical
                e.Graphics.DrawLine(p,
                    0, pnl.Height , pnl.Width , 0 );
            }
            // polígono
            if (tipoDesenho == TipoDesenho.Poligono)
            {
                Point[] pts = {
                               new Point(0,pnl.Height/2),
                               new Point(pnl.Width/2,0),
                               new Point(pnl.Width,pnl.Height/2),
                               new Point(pnl.Width/2,pnl.Height)
                              };
                // fundo
                e.Graphics.FillPolygon(fundo, pts);
                // borda
                e.Graphics.DrawPolygon(p, pts);
            }
            // bandeira
            if (tipoDesenho == TipoDesenho.Bandeira)
            {
                double h, hip, r, b, area, w;
                Point[] ptPoly = {new Point(pnl.Width/2,0),
                            new Point(pnl.Width, pnl.Height/2),
                            new Point(pnl.Width/2,pnl.Height),
                            new Point(0,pnl.Height/2)};

                System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 7);
                // base do triângulo
                b = pnl.Width / 2;
                // altura do triângulo
                h = pnl.Height / 2;
                // área do triângulo
                area = h * b / 2;
                // hipotenusa do retângulo
                hip = Math.Sqrt(h * h + b * b);
                // virando o triângulo com a hipotenhsa para baixo, calculamos a nova altura
                // do triângulo que corresponde ao raio do círculo
                r = 2 * area / hip - 2;
                fundo = new System.Drawing.SolidBrush(Color.Green);

                e.Graphics.FillRectangle(fundo, 1, 1,
                            pnl.ClientSize.Width - 1, pnl.ClientSize.Height - 1);
                e.Graphics.DrawRectangle(new Pen(Color.Black, 2), 0, 0,
                                      pnl.ClientSize.Width - 1, pnl.ClientSize.Height - 1);
                fundo = new System.Drawing.SolidBrush(Color.Yellow);
                e.Graphics.FillPolygon(fundo, ptPoly);

                e.Graphics.DrawPolygon(new Pen(Color.Black, 1), ptPoly);

                fundo = new System.Drawing.SolidBrush(Color.Blue);
                e.Graphics.FillEllipse(fundo, (float)(pnl.Width / 2 - r), (float)(pnl.Height / 2 - r), (float)(2 * r), (float)(2 * r));
                e.Graphics.DrawEllipse(new Pen(Color.Black, 1), (float)(pnl.Width / 2 - r), (float)(pnl.Height / 2 - r), (float)(2 * r), (float)(2 * r));

                fundo = new System.Drawing.SolidBrush(Color.White);
                e.Graphics.FillRectangle(fundo, (float)(pnl.Width / 2 - r), (float)(pnl.Height / 2 - 7), (float)(2 * r), 14);
                w = e.Graphics.MeasureString("ORDEM E PROGRESSO", drawFont).Width;

                fundo = new System.Drawing.SolidBrush(Color.Blue);
                e.Graphics.DrawString("ORDEM E PROGRESSO", drawFont, fundo, (float)((pnl.Width - w) / 2), (float)(pnl.Height / 2 - 5));
                drawFont.Dispose();
            }
            // bitmap
            if (tipoDesenho == TipoDesenho.Bitmap)
            {
                Bitmap bmp = new Bitmap("SEU_CREYSON.JPG");
                //e.Graphics.DrawImage(bmp, 0, 0);
                e.Graphics.DrawImage(bmp,0,0,pnl.Width,pnl.Height);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Pen p1 = new Pen(Brushes.Black, 1);
            Pen p2 = new Pen(Brushes.Black, 0.5f);
            Font font1 = new Font("Arial", 14, FontStyle.Bold);
            Font font2 = new Font("Arial", 12, FontStyle.Bold);
            Font font3 = new Font("Arial", 10);
            string[] particip = { 
                                    "Alexandre Takashi Fujita",
                                    "Bruno Cunha Nagalli Ramia",
                                    "Bruno José Gomes",
                                    "Cesar Henrique Coimbra",
                                    "Danilo Luciano V. Silva",
                                    "Deniz Araujo Valdrez",
                                    "Edson Jose Brito Silva",
                                    "Eduardo Oguihara Souza",
                                    "Francisco Augusto M Nóbrega",
                                    "Joaquim D'Oliveira Neto",
                                    "Marcel Renee Cardenuto",
                                    "Nelson Inacio S Junior",
                                    "Paula Marchini",
                                    "Paulo Cesar R Junior",
                                    "Robson Andreo \x22 Hernandez",
                                    "Silvio A. Silva",
                                    "Valdir  Ferreira G Silva",
                                    "Vinícius Fernandes Vieira"

                                };
            
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;

            e.Graphics.DrawRectangle(p1, 20, 20, 170, 250);
            e.Graphics.DrawLine(p2, 20, 55, 190, 55);
            
            Bitmap bmp = new Bitmap("logotipos\\logo_iso.bmp");
            
            e.Graphics.DrawImage(bmp,22,22,30,30);
            e.Graphics.DrawLine(p2, 55, 20, 55, 55);

            bmp = new Bitmap("logotipos\\logo_fundo.bmp");
            e.Graphics.DrawImage(bmp, 22, 56, 166, 180);

            string s = "IMPACTA TECNOLOGIA";
            double w = e.Graphics.MeasureString(s, font1).Width;
            e.Graphics.DrawString(s, font1, Brushes.Black, 122 - (float)w / 2, 25);

            s = "Treinameno CSharp Módulo II de 30/08 a 17/09";
            w = e.Graphics.MeasureString(s, font2).Width;
            e.Graphics.DrawString(s, font2, Brushes.Black, 122 - (float)w / 2, 34);

            s = "Instrutor: Carlos Magno P Souza";
            w = e.Graphics.MeasureString(s, font2).Width;
            e.Graphics.DrawString(s, font2, Brushes.Black, 122 - (float)w / 2, 40);

            s = "magno@somainfome.com - delphimagno@uol.com.br - magnocsharp@uol.com.br";
            w = e.Graphics.MeasureString(s, font3).Width;
            e.Graphics.DrawString(s, font3, Brushes.Black, 122 - (float)w / 2, 48);

            s = "PARTICIPANTES";
            w = e.Graphics.MeasureString(s, font1).Width;
            e.Graphics.DrawString(s, font1, Brushes.Black, 105 - (float)w / 2, 75);

            for (int i = 0; i < particip.Length; i++)
            {
                s = particip[i];
                w = e.Graphics.MeasureString(s, font2).Width;
                e.Graphics.DrawString(s, font2, Brushes.Black, 105 - (float)w / 2, 85 + i*10);
            }


            e.HasMorePages = false;
        }


    }
}