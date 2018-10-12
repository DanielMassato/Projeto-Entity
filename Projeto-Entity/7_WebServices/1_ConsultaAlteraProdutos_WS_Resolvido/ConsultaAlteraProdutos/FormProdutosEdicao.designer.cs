namespace ConsultaAlteraProdutos
{
    partial class FormProdutosEdicao
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnGrava = new System.Windows.Forms.Button();
            this.gbEdicao = new System.Windows.Forms.GroupBox();
            this.updIPI = new System.Windows.Forms.NumericUpDown();
            this.updQTD_REAL = new System.Windows.Forms.NumericUpDown();
            this.updQTD_MINIMA = new System.Windows.Forms.NumericUpDown();
            this.updPRECO_VENDA = new System.Windows.Forms.NumericUpDown();
            this.updPRECO_CUSTO = new System.Windows.Forms.NumericUpDown();
            this.cmbUnidades = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxCOD_UNIDADE = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxCOD_TIPO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxCLAS_FISC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxDESCRICAO = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCOD_PRODUTO = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbEdicao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIPI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQTD_REAL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQTD_MINIMA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPRECO_VENDA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPRECO_CUSTO)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancela);
            this.groupBox1.Controls.Add(this.btnGrava);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 46);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnCancela
            // 
            this.btnCancela.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancela.Location = new System.Drawing.Point(488, 14);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(75, 23);
            this.btnCancela.TabIndex = 21;
            this.btnCancela.Text = "Cancela";
            this.btnCancela.UseVisualStyleBackColor = true;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnGrava
            // 
            this.btnGrava.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGrava.Location = new System.Drawing.Point(408, 14);
            this.btnGrava.Name = "btnGrava";
            this.btnGrava.Size = new System.Drawing.Size(75, 23);
            this.btnGrava.TabIndex = 20;
            this.btnGrava.Text = "Grava";
            this.btnGrava.UseVisualStyleBackColor = true;
            this.btnGrava.Click += new System.EventHandler(this.btnGrava_Click);
            // 
            // gbEdicao
            // 
            this.gbEdicao.Controls.Add(this.updIPI);
            this.gbEdicao.Controls.Add(this.updQTD_REAL);
            this.gbEdicao.Controls.Add(this.updQTD_MINIMA);
            this.gbEdicao.Controls.Add(this.updPRECO_VENDA);
            this.gbEdicao.Controls.Add(this.updPRECO_CUSTO);
            this.gbEdicao.Controls.Add(this.cmbUnidades);
            this.gbEdicao.Controls.Add(this.cmbTipo);
            this.gbEdicao.Controls.Add(this.label13);
            this.gbEdicao.Controls.Add(this.tbxCOD_UNIDADE);
            this.gbEdicao.Controls.Add(this.label12);
            this.gbEdicao.Controls.Add(this.tbxCOD_TIPO);
            this.gbEdicao.Controls.Add(this.label11);
            this.gbEdicao.Controls.Add(this.label10);
            this.gbEdicao.Controls.Add(this.tbxCLAS_FISC);
            this.gbEdicao.Controls.Add(this.label9);
            this.gbEdicao.Controls.Add(this.label8);
            this.gbEdicao.Controls.Add(this.label7);
            this.gbEdicao.Controls.Add(this.label6);
            this.gbEdicao.Controls.Add(this.label5);
            this.gbEdicao.Controls.Add(this.tbxDESCRICAO);
            this.gbEdicao.Controls.Add(this.label4);
            this.gbEdicao.Controls.Add(this.tbxCOD_PRODUTO);
            this.gbEdicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEdicao.Location = new System.Drawing.Point(0, 0);
            this.gbEdicao.Name = "gbEdicao";
            this.gbEdicao.Size = new System.Drawing.Size(576, 157);
            this.gbEdicao.TabIndex = 5;
            this.gbEdicao.TabStop = false;
            this.gbEdicao.Text = "Ficha do Produto";
            // 
            // updIPI
            // 
            this.updIPI.Location = new System.Drawing.Point(299, 81);
            this.updIPI.Name = "updIPI";
            this.updIPI.Size = new System.Drawing.Size(45, 20);
            this.updIPI.TabIndex = 28;
            this.updIPI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updQTD_REAL
            // 
            this.updQTD_REAL.Location = new System.Drawing.Point(99, 81);
            this.updQTD_REAL.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updQTD_REAL.Name = "updQTD_REAL";
            this.updQTD_REAL.Size = new System.Drawing.Size(66, 20);
            this.updQTD_REAL.TabIndex = 27;
            this.updQTD_REAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updQTD_MINIMA
            // 
            this.updQTD_MINIMA.Location = new System.Drawing.Point(16, 81);
            this.updQTD_MINIMA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updQTD_MINIMA.Name = "updQTD_MINIMA";
            this.updQTD_MINIMA.Size = new System.Drawing.Size(66, 20);
            this.updQTD_MINIMA.TabIndex = 26;
            this.updQTD_MINIMA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updPRECO_VENDA
            // 
            this.updPRECO_VENDA.DecimalPlaces = 4;
            this.updPRECO_VENDA.Location = new System.Drawing.Point(436, 35);
            this.updPRECO_VENDA.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updPRECO_VENDA.Name = "updPRECO_VENDA";
            this.updPRECO_VENDA.Size = new System.Drawing.Size(66, 20);
            this.updPRECO_VENDA.TabIndex = 25;
            this.updPRECO_VENDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // updPRECO_CUSTO
            // 
            this.updPRECO_CUSTO.DecimalPlaces = 4;
            this.updPRECO_CUSTO.Location = new System.Drawing.Point(353, 36);
            this.updPRECO_CUSTO.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.updPRECO_CUSTO.Name = "updPRECO_CUSTO";
            this.updPRECO_CUSTO.Size = new System.Drawing.Size(66, 20);
            this.updPRECO_CUSTO.TabIndex = 24;
            this.updPRECO_CUSTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbUnidades
            // 
            this.cmbUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnidades.FormattingEnabled = true;
            this.cmbUnidades.Location = new System.Drawing.Point(390, 123);
            this.cmbUnidades.Name = "cmbUnidades";
            this.cmbUnidades.Size = new System.Drawing.Size(161, 21);
            this.cmbUnidades.TabIndex = 23;
            this.cmbUnidades.SelectedIndexChanged += new System.EventHandler(this.cmbUnidades_SelectedIndexChanged);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(52, 123);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(289, 21);
            this.cmbTipo.TabIndex = 22;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(346, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Cód.Unid.:";
            // 
            // tbxCOD_UNIDADE
            // 
            this.tbxCOD_UNIDADE.Location = new System.Drawing.Point(350, 123);
            this.tbxCOD_UNIDADE.Name = "tbxCOD_UNIDADE";
            this.tbxCOD_UNIDADE.ReadOnly = true;
            this.tbxCOD_UNIDADE.Size = new System.Drawing.Size(37, 20);
            this.tbxCOD_UNIDADE.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 107);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Cód.Tipo:";
            // 
            // tbxCOD_TIPO
            // 
            this.tbxCOD_TIPO.Location = new System.Drawing.Point(12, 123);
            this.tbxCOD_TIPO.Name = "tbxCOD_TIPO";
            this.tbxCOD_TIPO.ReadOnly = true;
            this.tbxCOD_TIPO.Size = new System.Drawing.Size(37, 20);
            this.tbxCOD_TIPO.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "%IPI:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(179, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Class.Fiscal:";
            // 
            // tbxCLAS_FISC
            // 
            this.tbxCLAS_FISC.Location = new System.Drawing.Point(183, 81);
            this.tbxCLAS_FISC.Name = "tbxCLAS_FISC";
            this.tbxCLAS_FISC.Size = new System.Drawing.Size(111, 20);
            this.tbxCLAS_FISC.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(96, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Qtd.Mínima:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Qtd.Real:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pr.Venda:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pr.Custo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Descrição:";
            // 
            // tbxDESCRICAO
            // 
            this.tbxDESCRICAO.Location = new System.Drawing.Point(99, 34);
            this.tbxDESCRICAO.Name = "tbxDESCRICAO";
            this.tbxDESCRICAO.Size = new System.Drawing.Size(249, 20);
            this.tbxDESCRICAO.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Código:";
            // 
            // tbxCOD_PRODUTO
            // 
            this.tbxCOD_PRODUTO.Location = new System.Drawing.Point(16, 34);
            this.tbxCOD_PRODUTO.Name = "tbxCOD_PRODUTO";
            this.tbxCOD_PRODUTO.Size = new System.Drawing.Size(77, 20);
            this.tbxCOD_PRODUTO.TabIndex = 0;
            // 
            // FormProdutosEdicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 203);
            this.Controls.Add(this.gbEdicao);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProdutosEdicao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormProdutosEdicao";
            this.groupBox1.ResumeLayout(false);
            this.gbEdicao.ResumeLayout(false);
            this.gbEdicao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updIPI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQTD_REAL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updQTD_MINIMA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPRECO_VENDA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPRECO_CUSTO)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnGrava;
        private System.Windows.Forms.GroupBox gbEdicao;
        private System.Windows.Forms.NumericUpDown updIPI;
        private System.Windows.Forms.NumericUpDown updQTD_REAL;
        private System.Windows.Forms.NumericUpDown updQTD_MINIMA;
        private System.Windows.Forms.NumericUpDown updPRECO_VENDA;
        private System.Windows.Forms.NumericUpDown updPRECO_CUSTO;
        private System.Windows.Forms.ComboBox cmbUnidades;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbxCOD_UNIDADE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxCOD_TIPO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxCLAS_FISC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxDESCRICAO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCOD_PRODUTO;
    }
}