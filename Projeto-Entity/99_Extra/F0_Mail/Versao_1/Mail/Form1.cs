using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Curso.Classes;
using System.Net.Mail;

namespace Mail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ckbAutentic_Click(object sender, EventArgs e)
        {
            Utils.EnableContainer(gbAutentic, ckbAutentic.Checked);
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lbxAnexos.Items.Add(openFileDialog1.FileName);
            }
        }

        private void btnDesanexar_Click(object sender, EventArgs e)
        {
            if (lbxAnexos.SelectedIndex >= 0)
            {
                lbxAnexos.Items.RemoveAt(lbxAnexos.SelectedIndex);
            }
        }

        private void EnvioCompleto(object sender, AsyncCompletedEventArgs e)
        {
            String token = (string)e.UserState;

            if (e.Cancelled)
            {
                lblStatus.Text = string.Format("[{0}] Cancelado.", token);
            }
            if (e.Error != null)
            {
                lblStatus.Text = string.Format("[{0}] {1}", token, e.Error.ToString());
            }
            else
            {
                Text = String.Format("Enviado");                
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SmtpClient mail = new SmtpClient(tbxSMTP.Text);
            MailAddress from = new MailAddress(tbxFrom.Text, tbxFrom.Text);
            MailAddress to = new MailAddress(tbxTo.Text);
            MailMessage message = new MailMessage(from, to);
            //message.BodyEncoding = System.Text.Encoding.
            //
            message.IsBodyHtml = rbHTML.Checked;

            if (ckbAutentic.Checked)
            {
                System.Net.NetworkCredential autenticao = new System.Net.NetworkCredential();
                autenticao.UserName = tbxUser.Text;
                autenticao.Password = tbxSenha.Text;
                mail.UseDefaultCredentials = false;
                mail.Credentials = autenticao;
            }


            message.Body = tbxMail.Text;
            message.Subject = tbxAssunto.Text;
            mail.SendCompleted += new SendCompletedEventHandler(EnvioCompleto);
            
            if (lbxAnexos.Items.Count > 0)
            {
                for (int i = 0; i < lbxAnexos.Items.Count; i++)
                {
                    Attachment anexo = new Attachment(lbxAnexos.Items[i].ToString());
                    message.Attachments.Add( anexo );
                }
            }
            lblStatus.Text = "Conectando";   
            string userState = "test message1";
            mail.SendAsync(message, userState);
                     
        }
    }
}
