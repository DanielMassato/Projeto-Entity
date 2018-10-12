namespace JogoDaForca
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
            this.gbInicio = new System.Windows.Forms.GroupBox();
            this.lblQtdMaxErro = new System.Windows.Forms.Label();
            this.tkbQtdMaxErro = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gbJogo = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCtdAcertos = new System.Windows.Forms.Label();
            this.lblCtdErros = new System.Windows.Forms.Label();
            this.btnTentativa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxLetra = new System.Windows.Forms.TextBox();
            this.gbPalavra = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSalvarArquivos = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.tbxDica = new System.Windows.Forms.TextBox();
            this.btnAddDica = new System.Windows.Forms.Button();
            this.dgvDicas = new System.Windows.Forms.DataGridView();
            this.tbxPalavra = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.dgvPalavras = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQtdMaxErro)).BeginInit();
            this.gbJogo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavras)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(500, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbInicio);
            this.tabPage1.Controls.Add(this.gbJogo);
            this.tabPage1.Controls.Add(this.gbPalavra);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(492, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Testa o Jogo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbInicio
            // 
            this.gbInicio.Controls.Add(this.lblQtdMaxErro);
            this.gbInicio.Controls.Add(this.tkbQtdMaxErro);
            this.gbInicio.Controls.Add(this.label4);
            this.gbInicio.Controls.Add(this.button1);
            this.gbInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbInicio.Location = new System.Drawing.Point(3, 3);
            this.gbInicio.Name = "gbInicio";
            this.gbInicio.Size = new System.Drawing.Size(486, 58);
            this.gbInicio.TabIndex = 17;
            this.gbInicio.TabStop = false;
            this.gbInicio.Text = "Início do Jogo";
            // 
            // lblQtdMaxErro
            // 
            this.lblQtdMaxErro.AutoSize = true;
            this.lblQtdMaxErro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdMaxErro.Location = new System.Drawing.Point(232, 24);
            this.lblQtdMaxErro.Name = "lblQtdMaxErro";
            this.lblQtdMaxErro.Size = new System.Drawing.Size(19, 20);
            this.lblQtdMaxErro.TabIndex = 12;
            this.lblQtdMaxErro.Text = "6";
            // 
            // tkbQtdMaxErro
            // 
            this.tkbQtdMaxErro.AutoSize = false;
            this.tkbQtdMaxErro.Location = new System.Drawing.Point(131, 19);
            this.tkbQtdMaxErro.Minimum = 3;
            this.tkbQtdMaxErro.Name = "tkbQtdMaxErro";
            this.tkbQtdMaxErro.Size = new System.Drawing.Size(104, 27);
            this.tkbQtdMaxErro.TabIndex = 11;
            this.tkbQtdMaxErro.Value = 6;
            this.tkbQtdMaxErro.ValueChanged += new System.EventHandler(this.tkbQtdMaxErro_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Qtd. Máxima de Erros:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Iniciar o Jogo:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbJogo
            // 
            this.gbJogo.Controls.Add(this.button2);
            this.gbJogo.Controls.Add(this.lblDica);
            this.gbJogo.Controls.Add(this.label2);
            this.gbJogo.Controls.Add(this.label3);
            this.gbJogo.Controls.Add(this.lblCtdAcertos);
            this.gbJogo.Controls.Add(this.lblCtdErros);
            this.gbJogo.Controls.Add(this.btnTentativa);
            this.gbJogo.Controls.Add(this.label1);
            this.gbJogo.Controls.Add(this.tbxLetra);
            this.gbJogo.Enabled = false;
            this.gbJogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbJogo.Location = new System.Drawing.Point(5, 120);
            this.gbJogo.Name = "gbJogo";
            this.gbJogo.Size = new System.Drawing.Size(483, 122);
            this.gbJogo.TabIndex = 16;
            this.gbJogo.TabStop = false;
            this.gbJogo.Text = "Jogo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Dica";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Location = new System.Drawing.Point(104, 98);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(193, 13);
            this.lblDica.TabIndex = 21;
            this.lblDica.Text = "_______________________________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Qtd. Erros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Qtd. Acertos:";
            // 
            // lblCtdAcertos
            // 
            this.lblCtdAcertos.AutoSize = true;
            this.lblCtdAcertos.Location = new System.Drawing.Point(278, 55);
            this.lblCtdAcertos.Name = "lblCtdAcertos";
            this.lblCtdAcertos.Size = new System.Drawing.Size(13, 13);
            this.lblCtdAcertos.TabIndex = 18;
            this.lblCtdAcertos.Text = "0";
            // 
            // lblCtdErros
            // 
            this.lblCtdErros.AutoSize = true;
            this.lblCtdErros.Location = new System.Drawing.Point(279, 25);
            this.lblCtdErros.Name = "lblCtdErros";
            this.lblCtdErros.Size = new System.Drawing.Size(13, 13);
            this.lblCtdErros.TabIndex = 17;
            this.lblCtdErros.Text = "0";
            // 
            // btnTentativa
            // 
            this.btnTentativa.Location = new System.Drawing.Point(39, 41);
            this.btnTentativa.Name = "btnTentativa";
            this.btnTentativa.Size = new System.Drawing.Size(75, 27);
            this.btnTentativa.TabIndex = 16;
            this.btnTentativa.Text = "Tentativa";
            this.btnTentativa.UseVisualStyleBackColor = true;
            this.btnTentativa.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Letra:";
            // 
            // tbxLetra
            // 
            this.tbxLetra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxLetra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLetra.Location = new System.Drawing.Point(6, 39);
            this.tbxLetra.MaxLength = 1;
            this.tbxLetra.Name = "tbxLetra";
            this.tbxLetra.Size = new System.Drawing.Size(27, 29);
            this.tbxLetra.TabIndex = 14;
            this.tbxLetra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxLetra_KeyDown);
            // 
            // gbPalavra
            // 
            this.gbPalavra.Location = new System.Drawing.Point(3, 62);
            this.gbPalavra.Name = "gbPalavra";
            this.gbPalavra.Size = new System.Drawing.Size(483, 58);
            this.gbPalavra.TabIndex = 15;
            this.gbPalavra.TabStop = false;
            this.gbPalavra.Text = "Palavra Oculta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSalvarArquivos);
            this.tabPage2.Controls.Add(this.btnAbrir);
            this.tabPage2.Controls.Add(this.tbxDica);
            this.tabPage2.Controls.Add(this.btnAddDica);
            this.tabPage2.Controls.Add(this.dgvDicas);
            this.tabPage2.Controls.Add(this.tbxPalavra);
            this.tabPage2.Controls.Add(this.btnAddWord);
            this.tabPage2.Controls.Add(this.dgvPalavras);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(492, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro de Palavras";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSalvarArquivos
            // 
            this.btnSalvarArquivos.Location = new System.Drawing.Point(346, 6);
            this.btnSalvarArquivos.Name = "btnSalvarArquivos";
            this.btnSalvarArquivos.Size = new System.Drawing.Size(138, 23);
            this.btnSalvarArquivos.TabIndex = 7;
            this.btnSalvarArquivos.Text = "Salvar Arquivos";
            this.btnSalvarArquivos.UseVisualStyleBackColor = true;
            this.btnSalvarArquivos.Click += new System.EventHandler(this.btnSalvarArquivos_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(13, 6);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(138, 23);
            this.btnAbrir.TabIndex = 6;
            this.btnAbrir.Text = "Abrir Arquivos";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // tbxDica
            // 
            this.tbxDica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxDica.Location = new System.Drawing.Point(256, 49);
            this.tbxDica.Name = "tbxDica";
            this.tbxDica.Size = new System.Drawing.Size(181, 20);
            this.tbxDica.TabIndex = 5;
            this.tbxDica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxDica_KeyDown);
            // 
            // btnAddDica
            // 
            this.btnAddDica.Location = new System.Drawing.Point(443, 47);
            this.btnAddDica.Name = "btnAddDica";
            this.btnAddDica.Size = new System.Drawing.Size(41, 25);
            this.btnAddDica.TabIndex = 4;
            this.btnAddDica.Text = "Adic.";
            this.btnAddDica.UseVisualStyleBackColor = true;
            this.btnAddDica.Click += new System.EventHandler(this.Adic_Click);
            // 
            // dgvDicas
            // 
            this.dgvDicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dgvDicas.Location = new System.Drawing.Point(255, 76);
            this.dgvDicas.Name = "dgvDicas";
            this.dgvDicas.RowHeadersVisible = false;
            this.dgvDicas.Size = new System.Drawing.Size(229, 155);
            this.dgvDicas.TabIndex = 3;
            // 
            // tbxPalavra
            // 
            this.tbxPalavra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbxPalavra.Location = new System.Drawing.Point(13, 47);
            this.tbxPalavra.Name = "tbxPalavra";
            this.tbxPalavra.Size = new System.Drawing.Size(120, 20);
            this.tbxPalavra.TabIndex = 2;
            this.tbxPalavra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxPalavra_KeyDown);
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(138, 45);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(41, 25);
            this.btnAddWord.TabIndex = 1;
            this.btnAddWord.Text = "Adic";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // dgvPalavras
            // 
            this.dgvPalavras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPalavras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvPalavras.Location = new System.Drawing.Point(11, 76);
            this.dgvPalavras.Name = "dgvPalavras";
            this.dgvPalavras.RowHeadersVisible = false;
            this.dgvPalavras.Size = new System.Drawing.Size(238, 155);
            this.dgvPalavras.TabIndex = 0;
            this.dgvPalavras.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPalavras_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Dica:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codigo";
            this.Column1.HeaderText = "Código:";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Descricao";
            this.Column2.HeaderText = "Descrição:";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 270);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Forca";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbInicio.ResumeLayout(false);
            this.gbInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbQtdMaxErro)).EndInit();
            this.gbJogo.ResumeLayout(false);
            this.gbJogo.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDicas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPalavras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbJogo;
        private System.Windows.Forms.TextBox tbxLetra;
        private System.Windows.Forms.GroupBox gbPalavra;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCtdAcertos;
        private System.Windows.Forms.Label lblCtdErros;
        private System.Windows.Forms.Button btnTentativa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbInicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar tkbQtdMaxErro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtdMaxErro;
        private System.Windows.Forms.TextBox tbxDica;
        private System.Windows.Forms.Button btnAddDica;
        private System.Windows.Forms.DataGridView dgvDicas;
        private System.Windows.Forms.TextBox tbxPalavra;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.DataGridView dgvPalavras;
        private System.Windows.Forms.Button btnSalvarArquivos;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;

    }
}

