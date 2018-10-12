namespace ConsultaProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbCSV = new System.Windows.Forms.RadioButton();
            this.rbXMLElementos = new System.Windows.Forms.RadioButton();
            this.rbXMLAtributos = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbSelecionados = new System.Windows.Forms.RadioButton();
            this.rbFiltro = new System.Windows.Forms.RadioButton();
            this.btnExportar = new System.Windows.Forms.Button();
            this.updPorc = new System.Windows.Forms.NumericUpDown();
            this.btnReajusta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbxProcura = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPosicao = new System.Windows.Forms.ToolStripLabel();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.tbxTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.dlsSalvar = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPorc)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.updPorc);
            this.groupBox1.Controls.Add(this.btnReajusta);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.btnFiltra);
            this.groupBox1.Controls.Add(this.tbxTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxDescricao);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Área de Filtro";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbCSV);
            this.panel2.Controls.Add(this.rbXMLElementos);
            this.panel2.Controls.Add(this.rbXMLAtributos);
            this.panel2.Location = new System.Drawing.Point(125, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(353, 40);
            this.panel2.TabIndex = 15;
            // 
            // rbCSV
            // 
            this.rbCSV.AutoSize = true;
            this.rbCSV.Location = new System.Drawing.Point(276, 10);
            this.rbCSV.Name = "rbCSV";
            this.rbCSV.Size = new System.Drawing.Size(56, 20);
            this.rbCSV.TabIndex = 3;
            this.rbCSV.Text = "CSV";
            this.rbCSV.UseVisualStyleBackColor = true;
            // 
            // rbXMLElementos
            // 
            this.rbXMLElementos.AutoSize = true;
            this.rbXMLElementos.Location = new System.Drawing.Point(138, 10);
            this.rbXMLElementos.Name = "rbXMLElementos";
            this.rbXMLElementos.Size = new System.Drawing.Size(132, 20);
            this.rbXMLElementos.TabIndex = 2;
            this.rbXMLElementos.Text = "XML Elementos";
            this.rbXMLElementos.UseVisualStyleBackColor = true;
            // 
            // rbXMLAtributos
            // 
            this.rbXMLAtributos.AutoSize = true;
            this.rbXMLAtributos.Checked = true;
            this.rbXMLAtributos.Location = new System.Drawing.Point(12, 10);
            this.rbXMLAtributos.Name = "rbXMLAtributos";
            this.rbXMLAtributos.Size = new System.Drawing.Size(120, 20);
            this.rbXMLAtributos.TabIndex = 1;
            this.rbXMLAtributos.TabStop = true;
            this.rbXMLAtributos.Text = "XML Atributos";
            this.rbXMLAtributos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbSelecionados);
            this.panel1.Controls.Add(this.rbFiltro);
            this.panel1.Location = new System.Drawing.Point(550, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 44);
            this.panel1.TabIndex = 13;
            // 
            // rbSelecionados
            // 
            this.rbSelecionados.AutoSize = true;
            this.rbSelecionados.Location = new System.Drawing.Point(86, 14);
            this.rbSelecionados.Name = "rbSelecionados";
            this.rbSelecionados.Size = new System.Drawing.Size(122, 20);
            this.rbSelecionados.TabIndex = 1;
            this.rbSelecionados.Text = "Selecionados";
            this.rbSelecionados.UseVisualStyleBackColor = true;
            // 
            // rbFiltro
            // 
            this.rbFiltro.AutoSize = true;
            this.rbFiltro.Checked = true;
            this.rbFiltro.Location = new System.Drawing.Point(10, 14);
            this.rbFiltro.Name = "rbFiltro";
            this.rbFiltro.Size = new System.Drawing.Size(61, 20);
            this.rbFiltro.TabIndex = 0;
            this.rbFiltro.TabStop = true;
            this.rbFiltro.Text = "Filtro";
            this.rbFiltro.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(12, 114);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(107, 30);
            this.btnExportar.TabIndex = 14;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // updPorc
            // 
            this.updPorc.Location = new System.Drawing.Point(552, 75);
            this.updPorc.Name = "updPorc";
            this.updPorc.Size = new System.Drawing.Size(52, 22);
            this.updPorc.TabIndex = 9;
            this.updPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReajusta
            // 
            this.btnReajusta.Location = new System.Drawing.Point(620, 54);
            this.btnReajusta.Name = "btnReajusta";
            this.btnReajusta.Size = new System.Drawing.Size(160, 43);
            this.btnReajusta.TabIndex = 8;
            this.btnReajusta.Text = "Reaj. Preços";
            this.btnReajusta.UseVisualStyleBackColor = true;
            this.btnReajusta.Click += new System.EventHandler(this.btnReajusta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Porc(%):";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrimeiro,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbxProcura,
            this.toolStripSeparator2,
            this.lblPosicao});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(871, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiro.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiro.Image")));
            this.btnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.btnPrimeiro.Text = "toolStripButton1";
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = global::ConsultaProdutos.Properties.Resources.anterior;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
            this.btnAnterior.Text = "toolStripButton2";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = global::ConsultaProdutos.Properties.Resources.proximo;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 22);
            this.btnProximo.Text = "toolStripButton3";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimo.Image = global::ConsultaProdutos.Properties.Resources.ultimo;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(23, 22);
            this.btnUltimo.Text = "toolStripButton4";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel1.Text = "Procura Produto:";
            // 
            // tbxProcura
            // 
            this.tbxProcura.Name = "tbxProcura";
            this.tbxProcura.Size = new System.Drawing.Size(150, 25);
            this.tbxProcura.TextChanged += new System.EventHandler(this.tbxProcura_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblPosicao
            // 
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(78, 22);
            this.lblPosicao.Text = "toolStripLabel2";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(430, 57);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(89, 43);
            this.btnFiltra.TabIndex = 4;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // tbxTipo
            // 
            this.tbxTipo.Location = new System.Drawing.Point(253, 78);
            this.tbxTipo.Name = "tbxTipo";
            this.tbxTipo.Size = new System.Drawing.Size(171, 22);
            this.tbxTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo começando com:";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(9, 78);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(238, 22);
            this.tbxDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição contendo:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(0, 167);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.Size = new System.Drawing.Size(877, 349);
            this.dgvProdutos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(877, 516);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Produtos  (DAL - Data Access Layer - Camada de Acesso a Dados)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPorc)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.TextBox tbxTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPrimeiro;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbxProcura;
        private System.Windows.Forms.Button btnReajusta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updPorc;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbCSV;
        private System.Windows.Forms.RadioButton rbXMLElementos;
        private System.Windows.Forms.RadioButton rbXMLAtributos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbSelecionados;
        private System.Windows.Forms.RadioButton rbFiltro;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.SaveFileDialog dlsSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel lblPosicao;
    }
}

