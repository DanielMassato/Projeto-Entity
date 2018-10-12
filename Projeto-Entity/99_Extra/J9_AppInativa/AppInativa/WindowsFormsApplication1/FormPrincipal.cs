using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    // implementar a interface IMessageFilter que contem método para tratar mensagens
    // enviadas para a aplicação. Isso poderia ser feito em outra
    // classe, mas aqui vamos usar o próprio FormPrincipal
    public partial class FormPrincipal : Form, IMessageFilter
    {
        // contador de tempo inativo da aplicação (em segundos)
        int ctInativo = 0;
        // mensagens do windows que deverão zerar o contador
        const int 
                  // todas as mensagens de teclado se encontram no intervalo de 0x100 a 0x108     
                  WM_KEYFIRST = 0x100, WM_KEYLAST = 0x108, 
                  // todas as mensagens de mouse se encontram no intervalo de 0x200 a 0x20E
                  WM_MOUSEFIRST = 0x200, WM_MOUSELAST = 0x20E,
                  // todas as mensagens de mouse na área de títuloo do form se encontram no intervalo de 0xA0 a 0xA9
                  WM_NCMOUSEFIRST = 0xA0, WM_NCMOUSELAST = 0xA9;

        public FormPrincipal()
        {
            InitializeComponent();
            // registra a classe FormPrincipal como a classe
            // que vai receber todas as mensagens enviadas
            // para a aplicação para o método PreFilterMessage resultande da 
            // implementação da interface IMessageFilter
            Application.AddMessageFilter(this);
        }

        // método que recebe todas as mensagens que o Windows
        // envia para a aplicação
        public bool PreFilterMessage(ref Message m)
        {
            // se for uma mensagem de teclado OU
            if (m.Msg >= WM_KEYFIRST && m.Msg <= WM_KEYLAST ||
                // for uma mensagem de mouse na área cliente do form
                m.Msg >= WM_MOUSEFIRST && m.Msg <= WM_MOUSELAST ||
                // ou for mensagem de mouse fora da área cliente
                m.Msg >= WM_NCMOUSEFIRST && m.Msg <= WM_NCMOUSELAST)
            {
                // zera o contador de tempo inativo
                ctInativo = 0;
            }
            // mostra o ID da mensagem 
            Text = "Form Principal: ID Msg = " + m.Msg.ToString() + " - 0x" +
                   String.Format("{0:x4}", m.Msg).ToUpper();
            // retornar false faz com que a mensagem seja 
            // processada normalmente pela aplicação. Retornar
            // true faz com que a aplicação não trate a mensagem
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //incrementar o contador de tempo
            ctInativo++;
            // mostrar o tempo na tela
            lblTempo.Text = ctInativo.ToString();
            // se passar do limite de tempo inativo
            if (ctInativo >= 30)
            {
                // desliga o timer
                timer1.Enabled = false;
                // abre a tela de login
                if (MessageBox.Show("Atenção", "Tempo exprirou. Deseja voltar para a aplicação?", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    // finaliza a aplicação
                    Application.Exit();
                }
                // liga o timer
                timer1.Enabled = true;
            }
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

            Top = 0;
            Left = 0;
        }

        private void btnAbreFormA_Click(object sender, EventArgs e)
        {
            new FormA().Show();
        }

        private void btnAbreFormB_Click(object sender, EventArgs e)
        {
            new FormB().Show();
        }






    }
}
