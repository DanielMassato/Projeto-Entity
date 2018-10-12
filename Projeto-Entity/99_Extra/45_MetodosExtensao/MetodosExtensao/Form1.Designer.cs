namespace MetodosExtensao
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxNumero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTesta = new System.Windows.Forms.Button();
            this.lblTesta = new System.Windows.Forms.Label();
            this.lblConvDec = new System.Windows.Forms.Label();
            this.btnConvDec = new System.Windows.Forms.Button();
            this.lblConvInt = new System.Windows.Forms.Label();
            this.btnConvInt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxTexto = new System.Windows.Forms.TextBox();
            this.btnContaPal = new System.Windows.Forms.Button();
            this.lblContaPal = new System.Windows.Forms.Label();
            this.lblPegaPal = new System.Windows.Forms.Label();
            this.btnPegaPal = new System.Windows.Forms.Button();
            this.updPos = new System.Windows.Forms.NumericUpDown();
            this.lblNomeProprio = new System.Windows.Forms.Label();
            this.btnNomeProprio = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.updFat = new System.Windows.Forms.NumericUpDown();
            this.btnFat = new System.Windows.Forms.Button();
            this.lblFat = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPos)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFat)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(395, 255);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblConvInt);
            this.tabPage1.Controls.Add(this.btnConvInt);
            this.tabPage1.Controls.Add(this.lblConvDec);
            this.tabPage1.Controls.Add(this.btnConvDec);
            this.tabPage1.Controls.Add(this.lblTesta);
            this.tabPage1.Controls.Add(this.btnTesta);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbxNumero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(387, 229);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conversão String para Número";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblNomeProprio);
            this.tabPage2.Controls.Add(this.btnNomeProprio);
            this.tabPage2.Controls.Add(this.updPos);
            this.tabPage2.Controls.Add(this.lblPegaPal);
            this.tabPage2.Controls.Add(this.btnPegaPal);
            this.tabPage2.Controls.Add(this.lblContaPal);
            this.tabPage2.Controls.Add(this.btnContaPal);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.tbxTexto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(387, 229);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Rotinas String";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxNumero
            // 
            this.tbxNumero.Location = new System.Drawing.Point(151, 12);
            this.tbxNumero.Name = "tbxNumero";
            this.tbxNumero.Size = new System.Drawing.Size(100, 20);
            this.tbxNumero.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite um Dado Numérico:";
            // 
            // btnTesta
            // 
            this.btnTesta.Location = new System.Drawing.Point(20, 55);
            this.btnTesta.Name = "btnTesta";
            this.btnTesta.Size = new System.Drawing.Size(128, 23);
            this.btnTesta.TabIndex = 2;
            this.btnTesta.Text = "Testa se é numérico";
            this.btnTesta.UseVisualStyleBackColor = true;
            this.btnTesta.Click += new System.EventHandler(this.btnTesta_Click);
            // 
            // lblTesta
            // 
            this.lblTesta.AutoSize = true;
            this.lblTesta.Location = new System.Drawing.Point(162, 64);
            this.lblTesta.Name = "lblTesta";
            this.lblTesta.Size = new System.Drawing.Size(49, 13);
            this.lblTesta.TabIndex = 3;
            this.lblTesta.Text = "_______";
            // 
            // lblConvDec
            // 
            this.lblConvDec.AutoSize = true;
            this.lblConvDec.Location = new System.Drawing.Point(162, 106);
            this.lblConvDec.Name = "lblConvDec";
            this.lblConvDec.Size = new System.Drawing.Size(49, 13);
            this.lblConvDec.TabIndex = 5;
            this.lblConvDec.Text = "_______";
            // 
            // btnConvDec
            // 
            this.btnConvDec.Location = new System.Drawing.Point(20, 97);
            this.btnConvDec.Name = "btnConvDec";
            this.btnConvDec.Size = new System.Drawing.Size(128, 23);
            this.btnConvDec.TabIndex = 4;
            this.btnConvDec.Text = "Converte p/ decimal";
            this.btnConvDec.UseVisualStyleBackColor = true;
            this.btnConvDec.Click += new System.EventHandler(this.btnConvDec_Click);
            // 
            // lblConvInt
            // 
            this.lblConvInt.AutoSize = true;
            this.lblConvInt.Location = new System.Drawing.Point(162, 149);
            this.lblConvInt.Name = "lblConvInt";
            this.lblConvInt.Size = new System.Drawing.Size(49, 13);
            this.lblConvInt.TabIndex = 7;
            this.lblConvInt.Text = "_______";
            // 
            // btnConvInt
            // 
            this.btnConvInt.Location = new System.Drawing.Point(20, 140);
            this.btnConvInt.Name = "btnConvInt";
            this.btnConvInt.Size = new System.Drawing.Size(128, 23);
            this.btnConvInt.TabIndex = 6;
            this.btnConvInt.Text = "Converte p/ inteiro";
            this.btnConvInt.UseVisualStyleBackColor = true;
            this.btnConvInt.Click += new System.EventHandler(this.btnConvInt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite o Texto:";
            // 
            // tbxTexto
            // 
            this.tbxTexto.Location = new System.Drawing.Point(88, 5);
            this.tbxTexto.Name = "tbxTexto";
            this.tbxTexto.Size = new System.Drawing.Size(291, 20);
            this.tbxTexto.TabIndex = 2;
            this.tbxTexto.Text = "CARLOS MAGNO PRATICO DE SOUZA";
            // 
            // btnContaPal
            // 
            this.btnContaPal.Location = new System.Drawing.Point(14, 46);
            this.btnContaPal.Name = "btnContaPal";
            this.btnContaPal.Size = new System.Drawing.Size(116, 23);
            this.btnContaPal.TabIndex = 4;
            this.btnContaPal.Text = "Conta Palavras";
            this.btnContaPal.UseVisualStyleBackColor = true;
            this.btnContaPal.Click += new System.EventHandler(this.btnContaPal_Click);
            // 
            // lblContaPal
            // 
            this.lblContaPal.AutoSize = true;
            this.lblContaPal.Location = new System.Drawing.Point(145, 56);
            this.lblContaPal.Name = "lblContaPal";
            this.lblContaPal.Size = new System.Drawing.Size(43, 13);
            this.lblContaPal.TabIndex = 5;
            this.lblContaPal.Text = "______";
            // 
            // lblPegaPal
            // 
            this.lblPegaPal.AutoSize = true;
            this.lblPegaPal.Location = new System.Drawing.Point(194, 93);
            this.lblPegaPal.Name = "lblPegaPal";
            this.lblPegaPal.Size = new System.Drawing.Size(43, 13);
            this.lblPegaPal.TabIndex = 7;
            this.lblPegaPal.Text = "______";
            // 
            // btnPegaPal
            // 
            this.btnPegaPal.Location = new System.Drawing.Point(14, 84);
            this.btnPegaPal.Name = "btnPegaPal";
            this.btnPegaPal.Size = new System.Drawing.Size(116, 23);
            this.btnPegaPal.TabIndex = 6;
            this.btnPegaPal.Text = "Pega Palavras";
            this.btnPegaPal.UseVisualStyleBackColor = true;
            this.btnPegaPal.Click += new System.EventHandler(this.btnPegaPal_Click);
            // 
            // updPos
            // 
            this.updPos.Location = new System.Drawing.Point(136, 86);
            this.updPos.Name = "updPos";
            this.updPos.Size = new System.Drawing.Size(52, 20);
            this.updPos.TabIndex = 8;
            // 
            // lblNomeProprio
            // 
            this.lblNomeProprio.AutoSize = true;
            this.lblNomeProprio.Location = new System.Drawing.Point(145, 134);
            this.lblNomeProprio.Name = "lblNomeProprio";
            this.lblNomeProprio.Size = new System.Drawing.Size(43, 13);
            this.lblNomeProprio.TabIndex = 10;
            this.lblNomeProprio.Text = "______";
            // 
            // btnNomeProprio
            // 
            this.btnNomeProprio.Location = new System.Drawing.Point(14, 124);
            this.btnNomeProprio.Name = "btnNomeProprio";
            this.btnNomeProprio.Size = new System.Drawing.Size(116, 23);
            this.btnNomeProprio.TabIndex = 9;
            this.btnNomeProprio.Text = "Nome Próprio";
            this.btnNomeProprio.UseVisualStyleBackColor = true;
            this.btnNomeProprio.Click += new System.EventHandler(this.btnNomeProprio_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblFat);
            this.tabPage3.Controls.Add(this.btnFat);
            this.tabPage3.Controls.Add(this.updFat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(387, 229);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rotinas Numéricas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // updFat
            // 
            this.updFat.Location = new System.Drawing.Point(8, 26);
            this.updFat.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.updFat.Name = "updFat";
            this.updFat.Size = new System.Drawing.Size(52, 20);
            this.updFat.TabIndex = 0;
            // 
            // btnFat
            // 
            this.btnFat.Location = new System.Drawing.Point(66, 23);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(89, 23);
            this.btnFat.TabIndex = 1;
            this.btnFat.Text = "Fatorial";
            this.btnFat.UseVisualStyleBackColor = true;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Location = new System.Drawing.Point(177, 29);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(37, 13);
            this.lblFat.TabIndex = 2;
            this.lblFat.Text = "_____";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 255);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Testandoo Métodos de Extensão";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPos)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxNumero;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblTesta;
        private System.Windows.Forms.Button btnTesta;
        private System.Windows.Forms.Label lblConvDec;
        private System.Windows.Forms.Button btnConvDec;
        private System.Windows.Forms.Label lblConvInt;
        private System.Windows.Forms.Button btnConvInt;
        private System.Windows.Forms.Label lblContaPal;
        private System.Windows.Forms.Button btnContaPal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxTexto;
        private System.Windows.Forms.NumericUpDown updPos;
        private System.Windows.Forms.Label lblPegaPal;
        private System.Windows.Forms.Button btnPegaPal;
        private System.Windows.Forms.Label lblNomeProprio;
        private System.Windows.Forms.Button btnNomeProprio;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Button btnFat;
        private System.Windows.Forms.NumericUpDown updFat;

    }
}

