namespace Mail
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tbxPorta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxSMTP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbAutentic = new System.Windows.Forms.CheckBox();
            this.rbHTML = new System.Windows.Forms.RadioButton();
            this.rbTexto = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.tbxAssunto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxCC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbAutentic = new System.Windows.Forms.GroupBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDesanexar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.lbxAnexos = new System.Windows.Forms.ListBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.gbAutentic.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.tbxPorta);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tbxSMTP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.ckbAutentic);
            this.panel1.Controls.Add(this.rbHTML);
            this.panel1.Controls.Add(this.rbTexto);
            this.panel1.Controls.Add(this.btnEnviar);
            this.panel1.Controls.Add(this.tbxAssunto);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbxCC);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbxTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.gbAutentic);
            this.panel1.Controls.Add(this.tbxFrom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 142);
            this.panel1.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(488, 20);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(200, 25);
            this.lblStatus.TabIndex = 17;
            this.lblStatus.Text = "DESCONECTADO";
            // 
            // tbxPorta
            // 
            this.tbxPorta.Location = new System.Drawing.Point(396, 10);
            this.tbxPorta.Name = "tbxPorta";
            this.tbxPorta.Size = new System.Drawing.Size(36, 20);
            this.tbxPorta.TabIndex = 16;
            this.tbxPorta.Text = "25";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Porta:";
            // 
            // tbxSMTP
            // 
            this.tbxSMTP.Location = new System.Drawing.Point(115, 10);
            this.tbxSMTP.Name = "tbxSMTP";
            this.tbxSMTP.Size = new System.Drawing.Size(213, 20);
            this.tbxSMTP.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SMTP:";
            // 
            // ckbAutentic
            // 
            this.ckbAutentic.AutoSize = true;
            this.ckbAutentic.Location = new System.Drawing.Point(347, 43);
            this.ckbAutentic.Name = "ckbAutentic";
            this.ckbAutentic.Size = new System.Drawing.Size(95, 17);
            this.ckbAutentic.TabIndex = 12;
            this.ckbAutentic.Text = "Autenticação?";
            this.ckbAutentic.UseVisualStyleBackColor = true;
            this.ckbAutentic.Click += new System.EventHandler(this.ckbAutentic_Click);
            // 
            // rbHTML
            // 
            this.rbHTML.AutoSize = true;
            this.rbHTML.Location = new System.Drawing.Point(505, 120);
            this.rbHTML.Name = "rbHTML";
            this.rbHTML.Size = new System.Drawing.Size(55, 17);
            this.rbHTML.TabIndex = 11;
            this.rbHTML.Text = "HTML";
            this.rbHTML.UseVisualStyleBackColor = true;
            // 
            // rbTexto
            // 
            this.rbTexto.AutoSize = true;
            this.rbTexto.Checked = true;
            this.rbTexto.Location = new System.Drawing.Point(402, 120);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(52, 17);
            this.rbTexto.TabIndex = 10;
            this.rbTexto.TabStop = true;
            this.rbTexto.Text = "Texto";
            this.rbTexto.UseVisualStyleBackColor = true;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(634, 114);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // tbxAssunto
            // 
            this.tbxAssunto.Location = new System.Drawing.Point(115, 114);
            this.tbxAssunto.Name = "tbxAssunto";
            this.tbxAssunto.Size = new System.Drawing.Size(213, 20);
            this.tbxAssunto.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Assunto";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxCC
            // 
            this.tbxCC.Location = new System.Drawing.Point(115, 92);
            this.tbxCC.Name = "tbxCC";
            this.tbxCC.Size = new System.Drawing.Size(213, 20);
            this.tbxCC.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cópia Para:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxTo
            // 
            this.tbxTo.Location = new System.Drawing.Point(115, 70);
            this.tbxTo.Name = "tbxTo";
            this.tbxTo.Size = new System.Drawing.Size(213, 20);
            this.tbxTo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Para (To):";
            // 
            // gbAutentic
            // 
            this.gbAutentic.Controls.Add(this.tbxSenha);
            this.gbAutentic.Controls.Add(this.label3);
            this.gbAutentic.Controls.Add(this.tbxUser);
            this.gbAutentic.Controls.Add(this.label2);
            this.gbAutentic.Location = new System.Drawing.Point(344, 58);
            this.gbAutentic.Name = "gbAutentic";
            this.gbAutentic.Size = new System.Drawing.Size(365, 53);
            this.gbAutentic.TabIndex = 2;
            this.gbAutentic.TabStop = false;
            // 
            // tbxSenha
            // 
            this.tbxSenha.Enabled = false;
            this.tbxSenha.Location = new System.Drawing.Point(225, 27);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '#';
            this.tbxSenha.Size = new System.Drawing.Size(132, 20);
            this.tbxSenha.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(224, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // tbxUser
            // 
            this.tbxUser.Enabled = false;
            this.tbxUser.Location = new System.Drawing.Point(7, 27);
            this.tbxUser.Name = "tbxUser";
            this.tbxUser.Size = new System.Drawing.Size(213, 20);
            this.tbxUser.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuário:";
            // 
            // tbxFrom
            // 
            this.tbxFrom.Location = new System.Drawing.Point(115, 48);
            this.tbxFrom.Name = "tbxFrom";
            this.tbxFrom.Size = new System.Drawing.Size(213, 20);
            this.tbxFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enviado Por (From):";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDesanexar);
            this.panel2.Controls.Add(this.btnAnexar);
            this.panel2.Controls.Add(this.lbxAnexos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnDesanexar
            // 
            this.btnDesanexar.Location = new System.Drawing.Point(15, 51);
            this.btnDesanexar.Name = "btnDesanexar";
            this.btnDesanexar.Size = new System.Drawing.Size(117, 27);
            this.btnDesanexar.TabIndex = 2;
            this.btnDesanexar.Text = "Desanexar";
            this.btnDesanexar.UseVisualStyleBackColor = true;
            this.btnDesanexar.Click += new System.EventHandler(this.btnDesanexar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(15, 18);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(117, 27);
            this.btnAnexar.TabIndex = 1;
            this.btnAnexar.Text = "Anexar";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // lbxAnexos
            // 
            this.lbxAnexos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbxAnexos.FormattingEnabled = true;
            this.lbxAnexos.Location = new System.Drawing.Point(147, 0);
            this.lbxAnexos.Name = "lbxAnexos";
            this.lbxAnexos.Size = new System.Drawing.Size(582, 95);
            this.lbxAnexos.TabIndex = 0;
            // 
            // tbxMail
            // 
            this.tbxMail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMail.Location = new System.Drawing.Point(0, 242);
            this.tbxMail.Multiline = true;
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(733, 231);
            this.tbxMail.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 473);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "My Crossoft Mail - MAGNO O BÃO";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAutentic.ResumeLayout(false);
            this.gbAutentic.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbAutentic;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAssunto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxCC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RadioButton rbHTML;
        private System.Windows.Forms.RadioButton rbTexto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDesanexar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.ListBox lbxAnexos;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.CheckBox ckbAutentic;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbxPorta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxSMTP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStatus;
    }
}

