namespace ProcessaArquivos
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.ckbIncluiSub = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbxArquivos = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxTexto = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbHex = new System.Windows.Forms.RadioButton();
            this.rbInt = new System.Windows.Forms.RadioButton();
            this.dgvBytes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBytes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnProcessa);
            this.groupBox1.Controls.Add(this.ckbIncluiSub);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxDir);
            this.groupBox1.Controls.Add(this.btnSelDir);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 67);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(562, 29);
            this.btnProcessa.Name = "btnProcessa";
            this.btnProcessa.Size = new System.Drawing.Size(98, 23);
            this.btnProcessa.TabIndex = 14;
            this.btnProcessa.Text = "Lista Arquivos";
            this.btnProcessa.UseVisualStyleBackColor = true;
            this.btnProcessa.Click += new System.EventHandler(this.btnProcessa_Click);
            // 
            // ckbIncluiSub
            // 
            this.ckbIncluiSub.AutoSize = true;
            this.ckbIncluiSub.Location = new System.Drawing.Point(446, 35);
            this.ckbIncluiSub.Name = "ckbIncluiSub";
            this.ckbIncluiSub.Size = new System.Drawing.Size(110, 17);
            this.ckbIncluiSub.TabIndex = 13;
            this.ckbIncluiSub.Text = "Inclui Subpastas?";
            this.ckbIncluiSub.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtro de Arq.:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(374, 34);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(66, 20);
            this.tbxFiltro.TabIndex = 11;
            this.tbxFiltro.Text = "*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o Diretório:";
            // 
            // tbxDir
            // 
            this.tbxDir.Location = new System.Drawing.Point(12, 32);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.ReadOnly = true;
            this.tbxDir.Size = new System.Drawing.Size(324, 20);
            this.tbxDir.TabIndex = 9;
            this.tbxDir.Text = "C:\\";
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(338, 30);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(27, 23);
            this.btnSelDir.TabIndex = 8;
            this.btnSelDir.Text = "...";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(690, 346);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbxArquivos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arquivos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxArquivos
            // 
            this.lbxArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxArquivos.FormattingEnabled = true;
            this.lbxArquivos.Location = new System.Drawing.Point(3, 3);
            this.lbxArquivos.Name = "lbxArquivos";
            this.lbxArquivos.Size = new System.Drawing.Size(676, 314);
            this.lbxArquivos.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxTexto);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(682, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Conteúdo Texto";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxTexto
            // 
            this.tbxTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTexto.Location = new System.Drawing.Point(3, 3);
            this.tbxTexto.Multiline = true;
            this.tbxTexto.Name = "tbxTexto";
            this.tbxTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTexto.Size = new System.Drawing.Size(676, 314);
            this.tbxTexto.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rbHex);
            this.tabPage3.Controls.Add(this.rbInt);
            this.tabPage3.Controls.Add(this.dgvBytes);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(682, 320);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Conteúdo Binário";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rbHex
            // 
            this.rbHex.AutoSize = true;
            this.rbHex.Location = new System.Drawing.Point(614, 5);
            this.rbHex.Name = "rbHex";
            this.rbHex.Size = new System.Drawing.Size(44, 17);
            this.rbHex.TabIndex = 2;
            this.rbHex.Text = "Hex";
            this.rbHex.UseVisualStyleBackColor = true;
            this.rbHex.Click += new System.EventHandler(this.rbInt_Click);
            // 
            // rbInt
            // 
            this.rbInt.AutoSize = true;
            this.rbInt.Checked = true;
            this.rbInt.Location = new System.Drawing.Point(575, 5);
            this.rbInt.Name = "rbInt";
            this.rbInt.Size = new System.Drawing.Size(37, 17);
            this.rbInt.TabIndex = 1;
            this.rbInt.TabStop = true;
            this.rbInt.Text = "Int";
            this.rbInt.UseVisualStyleBackColor = true;
            this.rbInt.Click += new System.EventHandler(this.rbInt_Click);
            // 
            // dgvBytes
            // 
            this.dgvBytes.AllowUserToAddRows = false;
            this.dgvBytes.AllowUserToDeleteRows = false;
            this.dgvBytes.AllowUserToResizeColumns = false;
            this.dgvBytes.AllowUserToResizeRows = false;
            this.dgvBytes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBytes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBytes.Location = new System.Drawing.Point(3, 3);
            this.dgvBytes.Name = "dgvBytes";
            this.dgvBytes.ReadOnly = true;
            this.dgvBytes.Size = new System.Drawing.Size(676, 314);
            this.dgvBytes.TabIndex = 0;
            this.dgvBytes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvBytes_CellFormatting);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 413);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Processa Arquivos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBytes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcessa;
        private System.Windows.Forms.CheckBox ckbIncluiSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox lbxArquivos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbxTexto;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbHex;
        private System.Windows.Forms.RadioButton rbInt;
        private System.Windows.Forms.DataGridView dgvBytes;
        private System.Windows.Forms.Button button1;
    }
}

