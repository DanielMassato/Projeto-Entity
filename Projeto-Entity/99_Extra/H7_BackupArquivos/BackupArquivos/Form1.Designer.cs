namespace BackupArquivos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcessa = new System.Windows.Forms.Button();
            this.ckbIncluiSub = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDir = new System.Windows.Forms.TextBox();
            this.btnSelDir = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvArquivos = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpAte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpDe);
            this.groupBox1.Controls.Add(this.label3);
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
            this.groupBox1.Size = new System.Drawing.Size(791, 93);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnProcessa
            // 
            this.btnProcessa.Location = new System.Drawing.Point(681, 60);
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
            this.ckbIncluiSub.Location = new System.Drawing.Point(550, 64);
            this.ckbIncluiSub.Name = "ckbIncluiSub";
            this.ckbIncluiSub.Size = new System.Drawing.Size(110, 17);
            this.ckbIncluiSub.TabIndex = 13;
            this.ckbIncluiSub.Text = "Inclui Subpastas?";
            this.ckbIncluiSub.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Filtro de Arq.:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(550, 30);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(229, 20);
            this.tbxFiltro.TabIndex = 11;
            this.tbxFiltro.Text = "*.cs;*.csproj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Selecione o Diretório:";
            // 
            // tbxDir
            // 
            this.tbxDir.Location = new System.Drawing.Point(12, 29);
            this.tbxDir.Name = "tbxDir";
            this.tbxDir.ReadOnly = true;
            this.tbxDir.Size = new System.Drawing.Size(499, 20);
            this.tbxDir.TabIndex = 9;
            this.tbxDir.Text = "C:\\Magno\\Impacta\\CSharp\\2012\\CSharp_Mod_II_Kit\\Mod_II";
            // 
            // btnSelDir
            // 
            this.btnSelDir.Location = new System.Drawing.Point(517, 27);
            this.btnSelDir.Name = "btnSelDir";
            this.btnSelDir.Size = new System.Drawing.Size(27, 23);
            this.btnSelDir.TabIndex = 8;
            this.btnSelDir.Text = "...";
            this.btnSelDir.UseVisualStyleBackColor = true;
            this.btnSelDir.Click += new System.EventHandler(this.btnSelDir_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 322);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(791, 71);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alterado Entre:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(90, 62);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(105, 20);
            this.dtpDe.TabIndex = 16;
            this.dtpDe.Value = new System.DateTime(2014, 8, 8, 0, 0, 0, 0);
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(225, 62);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(105, 20);
            this.dtpAte.TabIndex = 18;
            this.dtpAte.Value = new System.DateTime(2014, 8, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "e";
            // 
            // dgvArquivos
            // 
            this.dgvArquivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArquivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1});
            this.dgvArquivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArquivos.Location = new System.Drawing.Point(0, 93);
            this.dgvArquivos.Name = "dgvArquivos";
            this.dgvArquivos.Size = new System.Drawing.Size(791, 229);
            this.dgvArquivos.TabIndex = 12;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Data Alteração:";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Arquivo:";
            this.Column1.Name = "Column1";
            this.Column1.Width = 600;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 393);
            this.Controls.Add(this.dgvArquivos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArquivos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcessa;
        private System.Windows.Forms.CheckBox ckbIncluiSub;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDir;
        private System.Windows.Forms.Button btnSelDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvArquivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

