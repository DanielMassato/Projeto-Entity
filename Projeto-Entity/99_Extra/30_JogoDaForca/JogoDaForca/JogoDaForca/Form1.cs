using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JogoDaForca
{
    public partial class Form1 : Form
    {
        JogoForca j = new JogoForca();
        JogoForca jCad = new JogoForca();
        string palavraSorteada;
        Label[] labels;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            palavraSorteada = j.Inicia();
            lblCtdErros.Text = "";

            if (labels != null)
            {
                labels.ToList().Clear();
                gbPalavra.Controls.Clear();
            }
            
            gbPalavra.Invalidate();
            labels = new Label[palavraSorteada.Length];
            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                labels[i] = new Label();
                labels[i].Text = "_";
                labels[i].Font = new Font("Arial", 16, FontStyle.Bold);
                labels[i].Location = new System.Drawing.Point(i * 30 + 30, 20);
                labels[i].Size = new System.Drawing.Size(30, 30);
                gbPalavra.Controls.Add(labels[i]);
            }
            gbInicio.Enabled = false;
            gbJogo.Enabled = true;
            tbxLetra.Focus();
            lblDica.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblDica.Text = j.PedeDica();
            lblCtdErros.Text = j.CtdErros.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (j.FazTentativa(tbxLetra.Text[0]))
            {
                  for (int i = 0; i < j.PosicoesDaLetra.Count; i++)

                      labels[j.PosicoesDaLetra[i]].Text = tbxLetra.Text;

            }
            lblCtdAcertos.Text = j.CtdAcertos.ToString();
            lblCtdErros.Text = j.CtdErros.ToString();
            tbxLetra.Focus();
            tbxLetra.SelectAll();
            if (j.StatusJogo== JogoForca.JogoForcaStatusJogo.StatusGanhou)
                MessageBox.Show("PARABENS. Você Ganhou!!!");
            else if (j.StatusJogo== JogoForca.JogoForcaStatusJogo.StatusPerdeu)
                MessageBox.Show("Tentativas esgotadas. FORCA");

            gbJogo.Enabled = (j.StatusJogo == JogoForca.JogoForcaStatusJogo.StatusIniciado);
            gbInicio.Enabled = (j.StatusJogo != JogoForca.JogoForcaStatusJogo.StatusIniciado);
        }

        private void tkbQtdMaxErro_ValueChanged(object sender, EventArgs e)
        {
            lblQtdMaxErro.Text = tkbQtdMaxErro.Value.ToString();
        }

        void mostraGridPalavras(string palavra)
        {
            var palavras = from p in jCad.palavras
                           orderby (p.Descricao)
                           select new { p.Codigo, p.Descricao };
            dgvPalavras.DataSource = palavras.ToList();
            if (palavra != "")
            {
                int index = palavras.ToList().Count / 2, indexBase = 0, indexTop = palavras.ToList().Count-1;
                while (palavras.ToList()[index].Descricao != palavra)
                {
                    if (palavras.ToList()[index].Descricao.CompareTo(palavra) > 0)
                    {
                        indexTop = index;
                        if ((indexTop - index) / 2 == 0)
                            index = 0;
                        else
                            index = indexBase + (indexTop - index) / 2;
                    }
                    else if (palavras.ToList()[index].Descricao.CompareTo(palavra) < 0)
                    {
                        indexBase = index;
                        if ((indexTop - index) / 2 == 0)
                           index = palavras.ToList().Count-1;
                        else
                           index = indexBase + (indexTop - index) / 2;
                    }
                }
                dgvPalavras.CurrentCell = dgvPalavras.Rows[index].Cells[1];
            }
        }

        void mostraGridDicas(int cod)
        {
            var dicas = from d in jCad.dicas
                           orderby (d.Descricao)
                           where (d.Codigo==cod)
                           select new { d.Codigo, d.Descricao };
            dgvDicas.DataSource = dicas.ToList();

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            jCad.LoadXML();
            mostraGridPalavras("");
        }

        private void dgvPalavras_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            mostraGridDicas( Convert.ToInt32( dgvPalavras.Rows[e.RowIndex].Cells[0].Value ) );
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
            // transferir para a classe
            if (jCad.AdicionaPalavra(tbxPalavra.Text))
            {
                mostraGridPalavras(tbxPalavra.Text);
            }
            else
                MessageBox.Show("Palavra já Cadastrada...");
        }

        private void Adic_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(dgvPalavras.Rows[dgvPalavras.CurrentCell.RowIndex].Cells[0].Value);
            if (jCad.AdicionaDica(cod,tbxDica.Text))
               mostraGridDicas(cod);
            else
               MessageBox.Show("Dica já cadastrada para esta palavra");
        }

        private void btnSalvarArquivos_Click(object sender, EventArgs e)
        {
            if (jCad.SaveXML())
                MessageBox.Show("Arquivo salvo com sucesso");
            else
                MessageBox.Show("Erro");
        }

        private void tbxPalavra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                btnAddWord.PerformClick();
        }

        private void tbxDica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                btnAddDica.PerformClick();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvPalavras.Rows[1].Cells[1].Value.ToString());
        }

        private void tbxLetra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                btnTentativa.PerformClick();
        }
    }
}
