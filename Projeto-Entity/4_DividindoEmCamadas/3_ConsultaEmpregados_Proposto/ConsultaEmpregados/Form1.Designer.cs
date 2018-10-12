namespace ConsultaEmpregados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.tbtnAnterior = new System.Windows.Forms.ToolStripButton();
            this.tbtnProximo = new System.Windows.Forms.ToolStripButton();
            this.tbtnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tbxProcura = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnProcuraNome = new System.Windows.Forms.ToolStripButton();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpData2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpData1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updSal2 = new System.Windows.Forms.NumericUpDown();
            this.updSal1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxCargo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDepto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmpregados = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSal2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnFiltra);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tbxCargo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbxDepto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(853, 75);
            this.panel1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnPrimeiro,
            this.tbtnAnterior,
            this.tbtnProximo,
            this.tbtnUltimo,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.tbxProcura,
            this.tbtnProcuraNome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(853, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnPrimeiro
            // 
            this.tbtnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPrimeiro.Image = global::ConsultaEmpregados.Properties.Resources.primeiro;
            this.tbtnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPrimeiro.Name = "tbtnPrimeiro";
            this.tbtnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.tbtnPrimeiro.Text = "toolStripButton1";
            this.tbtnPrimeiro.Click += new System.EventHandler(this.tbtnPrimeiro_Click);
            // 
            // tbtnAnterior
            // 
            this.tbtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAnterior.Image = global::ConsultaEmpregados.Properties.Resources.anterior;
            this.tbtnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAnterior.Name = "tbtnAnterior";
            this.tbtnAnterior.Size = new System.Drawing.Size(23, 22);
            this.tbtnAnterior.Text = "toolStripButton2";
            this.tbtnAnterior.Click += new System.EventHandler(this.tbtnAnterior_Click);
            // 
            // tbtnProximo
            // 
            this.tbtnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnProximo.Image = global::ConsultaEmpregados.Properties.Resources.proximo;
            this.tbtnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProximo.Name = "tbtnProximo";
            this.tbtnProximo.Size = new System.Drawing.Size(23, 22);
            this.tbtnProximo.Text = "toolStripButton3";
            this.tbtnProximo.Click += new System.EventHandler(this.tbtnProximo_Click);
            // 
            // tbtnUltimo
            // 
            this.tbtnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnUltimo.Image = global::ConsultaEmpregados.Properties.Resources.ultimo;
            this.tbtnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUltimo.Name = "tbtnUltimo";
            this.tbtnUltimo.Size = new System.Drawing.Size(23, 22);
            this.tbtnUltimo.Text = "toolStripButton4";
            this.tbtnUltimo.Click += new System.EventHandler(this.tbtnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(87, 22);
            this.toolStripLabel2.Text = "Procura Nome:";
            // 
            // tbxProcura
            // 
            this.tbxProcura.Name = "tbxProcura";
            this.tbxProcura.Size = new System.Drawing.Size(100, 25);
            this.tbxProcura.TextChanged += new System.EventHandler(this.tbxProcura_TextChanged);
            // 
            // tbtnProcuraNome
            // 
            this.tbtnProcuraNome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnProcuraNome.Image = global::ConsultaEmpregados.Properties.Resources.procura;
            this.tbtnProcuraNome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProcuraNome.Name = "tbtnProcuraNome";
            this.tbtnProcuraNome.Size = new System.Drawing.Size(23, 22);
            this.tbtnProcuraNome.Text = "toolStripButton1";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(756, 28);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(48, 39);
            this.btnFiltra.TabIndex = 8;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpData2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpData1);
            this.groupBox2.Location = new System.Drawing.Point(531, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 43);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admitido entre:";
            // 
            // dtpData2
            // 
            this.dtpData2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData2.Location = new System.Drawing.Point(120, 15);
            this.dtpData2.Name = "dtpData2";
            this.dtpData2.Size = new System.Drawing.Size(89, 20);
            this.dtpData2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "E";
            // 
            // dtpData1
            // 
            this.dtpData1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData1.Location = new System.Drawing.Point(10, 17);
            this.dtpData1.Name = "dtpData1";
            this.dtpData1.Size = new System.Drawing.Size(89, 20);
            this.dtpData1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updSal2);
            this.groupBox1.Controls.Add(this.updSal1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(345, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 44);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salário Entre";
            // 
            // updSal2
            // 
            this.updSal2.Location = new System.Drawing.Point(102, 17);
            this.updSal2.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.updSal2.Name = "updSal2";
            this.updSal2.Size = new System.Drawing.Size(64, 20);
            this.updSal2.TabIndex = 9;
            this.updSal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updSal2.Value = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            // 
            // updSal1
            // 
            this.updSal1.Location = new System.Drawing.Point(12, 18);
            this.updSal1.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.updSal1.Name = "updSal1";
            this.updSal1.Size = new System.Drawing.Size(64, 20);
            this.updSal1.TabIndex = 8;
            this.updSal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "E";
            // 
            // tbxCargo
            // 
            this.tbxCargo.Location = new System.Drawing.Point(219, 43);
            this.tbxCargo.Name = "tbxCargo";
            this.tbxCargo.Size = new System.Drawing.Size(118, 20);
            this.tbxCargo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cargo começando com:";
            // 
            // tbxDepto
            // 
            this.tbxDepto.Location = new System.Drawing.Point(95, 43);
            this.tbxDepto.Name = "tbxDepto";
            this.tbxDepto.Size = new System.Drawing.Size(118, 20);
            this.tbxDepto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Depto começando com:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(8, 43);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(84, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Contendo:";
            // 
            // dgvEmpregados
            // 
            this.dgvEmpregados.AllowUserToAddRows = false;
            this.dgvEmpregados.AllowUserToDeleteRows = false;
            this.dgvEmpregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpregados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvEmpregados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmpregados.Location = new System.Drawing.Point(0, 75);
            this.dgvEmpregados.Name = "dgvEmpregados";
            this.dgvEmpregados.Size = new System.Drawing.Size(853, 409);
            this.dgvEmpregados.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CODFUN";
            this.Column1.HeaderText = "Código:";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NOME";
            this.Column2.HeaderText = "Nome:";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DATA_ADMISSAO";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column3.HeaderText = "Dt. Admissão:";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SALARIO";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "#,##0.00";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column4.HeaderText = "Salário:";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "DEPTO";
            this.Column5.HeaderText = "Departamento";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CARGO";
            this.Column6.HeaderText = "Cargo:";
            this.Column6.Name = "Column6";
            this.Column6.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 484);
            this.Controls.Add(this.dgvEmpregados);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cadastro de Empregados (Dividindo em Camadas - LibPedidosDAL)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updSal2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updSal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpregados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxCargo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDepto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpData2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpData1;
        
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnPrimeiro;
        private System.Windows.Forms.ToolStripButton tbtnAnterior;
        private System.Windows.Forms.ToolStripButton tbtnProximo;
        private System.Windows.Forms.ToolStripButton tbtnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tbxProcura;
        private System.Windows.Forms.ToolStripButton tbtnProcuraNome;
        private System.Windows.Forms.DataGridView dgvEmpregados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.NumericUpDown updSal2;
        private System.Windows.Forms.NumericUpDown updSal1;
    }
}

