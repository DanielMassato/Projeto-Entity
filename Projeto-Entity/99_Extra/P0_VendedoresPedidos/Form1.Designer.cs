namespace VendedoresPedidos
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updAno = new System.Windows.Forms.NumericUpDown();
            this.updMes = new System.Windows.Forms.NumericUpDown();
            this.ckbNC = new System.Windows.Forms.CheckBox();
            this.lblRecNo = new System.Windows.Forms.Label();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.tbtnAnterior = new System.Windows.Forms.ToolStripButton();
            this.tbtnProximo = new System.Windows.Forms.ToolStripButton();
            this.tbtnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPed = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.bsVendedores = new System.Windows.Forms.BindingSource(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMes)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 247);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Controls.Add(this.dgvVendedores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 151);
            this.panel3.TabIndex = 2;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvVendedores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column11,
            this.Column4,
            this.Column12,
            this.Column10});
            this.dgvVendedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvVendedores.Location = new System.Drawing.Point(0, 0);
            this.dgvVendedores.MultiSelect = false;
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(474, 151);
            this.dgvVendedores.TabIndex = 4;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CODVEN";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column6.HeaderText = "Código:";
            this.Column6.Name = "Column6";
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "NOME";
            this.Column7.HeaderText = "Nome Vendedor:";
            this.Column7.Name = "Column7";
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column7.Width = 120;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "TOT_VENDIDO";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "#,##0.00";
            this.Column11.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column11.HeaderText = "Tot.Vendido:";
            this.Column11.Name = "Column11";
            this.Column11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column11.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "COMISSAO";
            this.Column4.HeaderText = "Comissão:";
            this.Column4.Name = "Column4";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "QTD_PEDIDOS";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "#,##0";
            this.Column12.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column12.HeaderText = "Qtd.Pedidos:";
            this.Column12.Name = "Column12";
            this.Column12.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column12.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "FONE1";
            this.Column10.HeaderText = "Fone:";
            this.Column10.Name = "Column10";
            this.Column10.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Column10.Width = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updAno);
            this.groupBox1.Controls.Add(this.updMes);
            this.groupBox1.Controls.Add(this.ckbNC);
            this.groupBox1.Controls.Add(this.lblRecNo);
            this.groupBox1.Controls.Add(this.btnFiltra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 71);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // updAno
            // 
            this.updAno.Location = new System.Drawing.Point(197, 29);
            this.updAno.Maximum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.updAno.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.updAno.Name = "updAno";
            this.updAno.Size = new System.Drawing.Size(71, 22);
            this.updAno.TabIndex = 21;
            this.updAno.Value = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.updAno.ValueChanged += new System.EventHandler(this.updMes_ValueChanged);
            // 
            // updMes
            // 
            this.updMes.Location = new System.Drawing.Point(138, 28);
            this.updMes.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.updMes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updMes.Name = "updMes";
            this.updMes.Size = new System.Drawing.Size(53, 22);
            this.updMes.TabIndex = 20;
            this.updMes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updMes.ValueChanged += new System.EventHandler(this.updMes_ValueChanged);
            // 
            // ckbNC
            // 
            this.ckbNC.AutoSize = true;
            this.ckbNC.Location = new System.Drawing.Point(277, 28);
            this.ckbNC.Name = "ckbNC";
            this.ckbNC.Size = new System.Drawing.Size(351, 20);
            this.ckbNC.TabIndex = 19;
            this.ckbNC.Text = "Trazer também vendedores que não venderam";
            this.ckbNC.UseVisualStyleBackColor = true;
            this.ckbNC.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // lblRecNo
            // 
            this.lblRecNo.AutoSize = true;
            this.lblRecNo.Location = new System.Drawing.Point(4, 42);
            this.lblRecNo.Name = "lblRecNo";
            this.lblRecNo.Size = new System.Drawing.Size(51, 16);
            this.lblRecNo.TabIndex = 18;
            this.lblRecNo.Text = "label5";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(640, 24);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(74, 30);
            this.btnFiltra.TabIndex = 17;
            this.btnFiltra.Text = "FILTRA";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ano:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mês:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnPrimeiro,
            this.tbtnAnterior,
            this.tbtnProximo,
            this.tbtnUltimo,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 17);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(125, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnPrimeiro
            // 
            this.tbtnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPrimeiro.Image = global::VendedoresPedidos.Properties.Resources.primeiro;
            this.tbtnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPrimeiro.Name = "tbtnPrimeiro";
            this.tbtnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.tbtnPrimeiro.Text = "toolStripButton1";
            this.tbtnPrimeiro.Click += new System.EventHandler(this.tbtnPrimeiro_Click);
            // 
            // tbtnAnterior
            // 
            this.tbtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAnterior.Image = global::VendedoresPedidos.Properties.Resources.anterior;
            this.tbtnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAnterior.Name = "tbtnAnterior";
            this.tbtnAnterior.Size = new System.Drawing.Size(23, 22);
            this.tbtnAnterior.Text = "toolStripButton2";
            this.tbtnAnterior.Click += new System.EventHandler(this.tbtnAnterior_Click);
            // 
            // tbtnProximo
            // 
            this.tbtnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnProximo.Image = global::VendedoresPedidos.Properties.Resources.proximo;
            this.tbtnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProximo.Name = "tbtnProximo";
            this.tbtnProximo.Size = new System.Drawing.Size(23, 22);
            this.tbtnProximo.Text = "toolStripButton3";
            this.tbtnProximo.Click += new System.EventHandler(this.tbtnProximo_Click);
            // 
            // tbtnUltimo
            // 
            this.tbtnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnUltimo.Image = global::VendedoresPedidos.Properties.Resources.ultimo;
            this.tbtnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnUltimo.Name = "tbtnUltimo";
            this.tbtnUltimo.Size = new System.Drawing.Size(23, 22);
            this.tbtnUltimo.Text = "toolStripButton4";
            this.tbtnUltimo.Click += new System.EventHandler(this.tbtnUltimo_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(78, 22);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(24, 13);
            this.toolStripLabel2.Text = "De:";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Vendedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPed);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 229);
            this.panel2.TabIndex = 2;
            // 
            // dgvPed
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvPed.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            this.dgvPed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPed.Location = new System.Drawing.Point(0, 23);
            this.dgvPed.MultiSelect = false;
            this.dgvPed.Name = "dgvPed";
            this.dgvPed.ReadOnly = true;
            this.dgvPed.Size = new System.Drawing.Size(786, 206);
            this.dgvPed.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NUM_PEDIDO";
            this.Column1.HeaderText = "No.Pedido:";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "DATA_EMISSAO";
            this.Column2.HeaderText = "Data Emissão:";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "VLR_TOTAL";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "#,##0.00";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column3.HeaderText = "Vlr.Total:";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CLIENTE";
            this.Column5.HeaderText = "Cliente:";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 350;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(786, 23);
            this.label6.TabIndex = 1;
            this.label6.Text = "Pedidos Deste Vendedor";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bsVendedores
            // 
            this.bsVendedores.CurrentChanged += new System.EventHandler(this.bsVendedores_CurrentChanged);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Right;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(476, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(308, 151);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Clientes e Seus Pedidos no Período";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updMes)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnPrimeiro;
        private System.Windows.Forms.ToolStripButton tbtnAnterior;
        private System.Windows.Forms.ToolStripButton tbtnProximo;
        private System.Windows.Forms.ToolStripButton tbtnUltimo;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bsVendedores;
        private System.Windows.Forms.DataGridView dgvPed;
        private System.Windows.Forms.Label lblRecNo;
        private System.Windows.Forms.CheckBox ckbNC;
        private System.Windows.Forms.NumericUpDown updAno;
        private System.Windows.Forms.NumericUpDown updMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

