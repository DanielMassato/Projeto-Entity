namespace NumeroSecreto
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
            this.btnInicia = new System.Windows.Forms.Button();
            this.gbJogo = new System.Windows.Forms.GroupBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnJoga = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.tbxTentativa = new System.Windows.Forms.TextBox();
            this.tbxLimite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbJogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInicia
            // 
            this.btnInicia.Location = new System.Drawing.Point(145, 22);
            this.btnInicia.Name = "btnInicia";
            this.btnInicia.Size = new System.Drawing.Size(75, 23);
            this.btnInicia.TabIndex = 1;
            this.btnInicia.Text = "Inicia";
            this.btnInicia.UseVisualStyleBackColor = true;
            this.btnInicia.Click += new System.EventHandler(this.btnInicia_Click);
            // 
            // gbJogo
            // 
            this.gbJogo.Controls.Add(this.lblMsg);
            this.gbJogo.Controls.Add(this.btnJoga);
            this.gbJogo.Controls.Add(this.lbl);
            this.gbJogo.Controls.Add(this.tbxTentativa);
            this.gbJogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbJogo.Enabled = false;
            this.gbJogo.Location = new System.Drawing.Point(0, 54);
            this.gbJogo.Name = "gbJogo";
            this.gbJogo.Size = new System.Drawing.Size(247, 110);
            this.gbJogo.TabIndex = 1;
            this.gbJogo.TabStop = false;
            this.gbJogo.Text = "Jogo";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(32, 77);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(139, 13);
            this.lblMsg.TabIndex = 3;
            this.lblMsg.Text = "______________________";
            // 
            // btnJoga
            // 
            this.btnJoga.Location = new System.Drawing.Point(135, 37);
            this.btnJoga.Name = "btnJoga";
            this.btnJoga.Size = new System.Drawing.Size(75, 23);
            this.btnJoga.TabIndex = 2;
            this.btnJoga.Text = "Joga";
            this.btnJoga.UseVisualStyleBackColor = true;
            this.btnJoga.Click += new System.EventHandler(this.btnJoga_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(31, 24);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 13);
            this.lbl.TabIndex = 1;
            this.lbl.Text = "Sua 1a. Tentativa:";
            // 
            // tbxTentativa
            // 
            this.tbxTentativa.Location = new System.Drawing.Point(29, 39);
            this.tbxTentativa.Name = "tbxTentativa";
            this.tbxTentativa.Size = new System.Drawing.Size(100, 20);
            this.tbxTentativa.TabIndex = 0;
            this.tbxTentativa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxTentativa_KeyPress);
            // 
            // tbxLimite
            // 
            this.tbxLimite.Location = new System.Drawing.Point(39, 25);
            this.tbxLimite.Name = "tbxLimite";
            this.tbxLimite.Size = new System.Drawing.Size(100, 20);
            this.tbxLimite.TabIndex = 0;
            this.tbxLimite.Text = "1000";
            this.tbxLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxLimite_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Limite de Sorteio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxLimite);
            this.Controls.Add(this.gbJogo);
            this.Controls.Add(this.btnInicia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo do Adivinha";
            this.gbJogo.ResumeLayout(false);
            this.gbJogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInicia;
        private System.Windows.Forms.GroupBox gbJogo;
        private System.Windows.Forms.TextBox tbxTentativa;
        private System.Windows.Forms.TextBox tbxLimite;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJoga;
        private System.Windows.Forms.Label lblMsg;
    }
}

