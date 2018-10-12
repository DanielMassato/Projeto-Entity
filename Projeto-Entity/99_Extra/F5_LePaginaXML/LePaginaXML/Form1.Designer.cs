namespace LePaginaXML
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
            this.tbx = new System.Windows.Forms.TextBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.gbProxy = new System.Windows.Forms.GroupBox();
            this.tbxProxySenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bxProxyLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxProxyHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbProxy = new System.Windows.Forms.CheckBox();
            this.tbxCEP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbProxy.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx
            // 
            this.tbx.Location = new System.Drawing.Point(3, 93);
            this.tbx.Multiline = true;
            this.tbx.Name = "tbx";
            this.tbx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx.Size = new System.Drawing.Size(461, 305);
            this.tbx.TabIndex = 0;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(337, 47);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(75, 23);
            this.btnConsulta.TabIndex = 1;
            this.btnConsulta.Text = "Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbProxy
            // 
            this.gbProxy.Controls.Add(this.tbxProxySenha);
            this.gbProxy.Controls.Add(this.label3);
            this.gbProxy.Controls.Add(this.bxProxyLogin);
            this.gbProxy.Controls.Add(this.label2);
            this.gbProxy.Controls.Add(this.tbxProxyHost);
            this.gbProxy.Controls.Add(this.label1);
            this.gbProxy.Enabled = false;
            this.gbProxy.Location = new System.Drawing.Point(3, 12);
            this.gbProxy.Name = "gbProxy";
            this.gbProxy.Size = new System.Drawing.Size(258, 75);
            this.gbProxy.TabIndex = 2;
            this.gbProxy.TabStop = false;
            // 
            // tbxProxySenha
            // 
            this.tbxProxySenha.Location = new System.Drawing.Point(170, 40);
            this.tbxProxySenha.Name = "tbxProxySenha";
            this.tbxProxySenha.Size = new System.Drawing.Size(64, 20);
            this.tbxProxySenha.TabIndex = 5;
            this.tbxProxySenha.Text = "internet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha:";
            // 
            // bxProxyLogin
            // 
            this.bxProxyLogin.Location = new System.Drawing.Point(52, 42);
            this.bxProxyLogin.Name = "bxProxyLogin";
            this.bxProxyLogin.Size = new System.Drawing.Size(64, 20);
            this.bxProxyLogin.TabIndex = 3;
            this.bxProxyLogin.Text = "internet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Login";
            // 
            // tbxProxyHost
            // 
            this.tbxProxyHost.Location = new System.Drawing.Point(52, 16);
            this.tbxProxyHost.Name = "tbxProxyHost";
            this.tbxProxyHost.Size = new System.Drawing.Size(182, 20);
            this.tbxProxyHost.TabIndex = 1;
            this.tbxProxyHost.Text = "http://vitara:8088/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host:";
            // 
            // ckbProxy
            // 
            this.ckbProxy.AutoSize = true;
            this.ckbProxy.Location = new System.Drawing.Point(3, 4);
            this.ckbProxy.Name = "ckbProxy";
            this.ckbProxy.Size = new System.Drawing.Size(83, 17);
            this.ckbProxy.TabIndex = 3;
            this.ckbProxy.Text = "Usar Proxy?";
            this.ckbProxy.UseVisualStyleBackColor = true;
            this.ckbProxy.CheckedChanged += new System.EventHandler(this.ckbProxy_CheckedChanged);
            // 
            // tbxCEP
            // 
            this.tbxCEP.Location = new System.Drawing.Point(267, 50);
            this.tbxCEP.Name = "tbxCEP";
            this.tbxCEP.Size = new System.Drawing.Size(64, 20);
            this.tbxCEP.TabIndex = 5;
            this.tbxCEP.Text = "01311100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CEP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 407);
            this.Controls.Add(this.tbxCEP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckbProxy);
            this.Controls.Add(this.gbProxy);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.tbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consulta CEP em http://cep.republicavirtual.com.br/web_cep.php?cep=";
            this.gbProxy.ResumeLayout(false);
            this.gbProxy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.GroupBox gbProxy;
        private System.Windows.Forms.TextBox tbxProxyHost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbProxy;
        private System.Windows.Forms.TextBox tbxProxySenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bxProxyLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxCEP;
        private System.Windows.Forms.Label label4;
    }
}

