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
using mshtml;

namespace Mail
{
    public partial class Form1 : Form
    {
        private IHTMLDocument2 doc;

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

            if (rbTexto.Checked)
            {
                message.Body = tbxMail.Text;
            }
            else
            {
                message.Body = HTMLEditor.DocumentText;
            }

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
            
            mail.Send(message);

            lblStatus.Text = "Enviado";
            
                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HTMLEditor.DocumentText = "<html><body></body></html>"; //This will get our HTML editor ready, inserting common HTML blocks into the document
            //Make the web 'browser' an editable HTML field

            doc =
            HTMLEditor.Document.DomDocument as IHTMLDocument2;
            doc.designMode = "On";

            System.Drawing.Text.InstalledFontCollection fonts = new System.Drawing.Text.InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                cmbFontes.Items.Add(family.Name);
            }
        }

        private void toolStrip1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Bold", false, null);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Italic", false, null);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("Underline", false, null);
        }
        /*
         HTMLEditor.Document.ExecCommand("Bold", false, null);
HTMLEditor.Document.ExecCommand("Underline", false, null);
HTMLEditor.Document.ExecCommand("Italics", false, null);
HTMLEditor.Document.ExecCommand("StrikeThrough", false, null);
HTMLEditor.Document.ExecCommand("FontName", false, "Times New Roman");
HTMLEditor.Document.ExecCommand("FontName", false, "Arial");
HTMLEditor.Document.ExecCommand("FontName", false, "etc.");
HTMLEditor.Document.ExecCommand("FontSize", false, "1");
HTMLEditor.Document.ExecCommand("FontSize", false, "2");
HTMLEditor.Document.ExecCommand("FontSize", false, "3");
HTMLEditor.Document.ExecCommand("InsertUnorderedList", false, null);
HTMLEditor.Document.ExecCommand("InsertOrderedList", false, null);
HTMLEditor.Document.ExecCommand("Cut", false, null);
HTMLEditor.Document.ExecCommand("Copy", false, null);
HTMLEditor.Document.ExecCommand("Paste", false, null);
HTMLEditor.Document.ExecCommand("CreateLink", true, null); 


//HERE IS THE WAY TO INSERT YOUR OWN TEXT INTO THE HTML EDITOR:


String TEXT = "YOUR TEXT GOES HERE!";

IHTMLTxtRange range =
doc.selection.createRange() as IHTMLTxtRange;
range.pasteHTML(TEXT);
range.collapse(false);
range.select();
         * 
         * String SAVECONTENTS = HTMLEditor.DocumentText;
         * 
         * HTMLEditor.Document.ExecCommand("InsertImage", false,  IMGSRC);

//LINK:
string URL = "http://www.example.com";
string Text = "Example.com";

IHTMLTxtRange range =
                    doc.selection.createRange() as IHTMLTxtRange;
                    range.pasteHTML("<A href=\"" + URL + "\">" + Text + "</A>");
                    range.collapse(false);
                    range.select();
         * 
         * HTMLEditor.Document.ExecCommand("InsertHorizontalRule", false, null);

//ALIGN:
HTMLEditor.Document.ExecCommand("JustifyLeft", false, null);
HTMLEditor.Document.ExecCommand("JustifyRight", false, null);
HTMLEditor.Document.ExecCommand("JustifyCenter", false, null);
HTMLEditor.Document.ExecCommand("JustifyFull", false, null);
         * 
         */
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FormImagem frm = new FormImagem();
            frm.ShowDialog();
            string img = frm.FileName;

            HTMLEditor.Document.ExecCommand("InsertImage", false, img);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            //string URL = "http://www.example.com";
            //string Text = "Example.com";
            string s = "";
            IHTMLSelectionObject currentSelection = doc.selection;

            if (currentSelection != null)
            {
                IHTMLTxtRange r = currentSelection.createRange() as IHTMLTxtRange;

                if (r != null)
                {
                    s = r.text;
                }
            }

            IHTMLTxtRange range =
                                doc.selection.createRange() as IHTMLTxtRange;

            FormLink frm = new FormLink();
            frm.tbxTexto.Text = s;
            frm.ShowDialog();

            range.pasteHTML("<A href=\"" + frm.URL + "\">" + frm.Texto + "</A>");
            range.collapse(false);
            range.select();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            String TEXT = "<br>";

            IHTMLTxtRange range =
            doc.selection.createRange() as IHTMLTxtRange;
            range.pasteHTML(TEXT);
            range.collapse(false);
            range.select();
        }

        private void rbTexto_Click(object sender, EventArgs e)
        {
            if (rbTexto.Checked)
            {
                tabControl1.SelectedIndex = 0;               
            }
            else
                tabControl1.SelectedIndex = 1;
        }

        private void cmbFontes_TextChanged(object sender, EventArgs e)
        {
            HTMLEditor.Document.ExecCommand("FontName", false, cmbFontes.Text);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
                rbTexto.Checked = true;
            else
                rbHTML.Checked = true;
        }
    }
}
