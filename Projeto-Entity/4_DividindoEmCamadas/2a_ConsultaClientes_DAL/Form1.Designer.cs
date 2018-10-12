namespace ConsultaClientes
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
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxUF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.tbtnAnterior = new System.Windows.Forms.ToolStripButton();
            this.tbtnProximo = new System.Windows.Forms.ToolStripButton();
            this.tbtnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tbxProcura = new System.Windows.Forms.ToolStripTextBox();
            this.tbtnProcura = new System.Windows.Forms.ToolStripButton();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.tbxCidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(0, 65);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(715, 389);
            this.dgvClientes.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxUF);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.btnFiltra);
            this.panel1.Controls.Add(this.tbxCidade);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxNome);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 65);
            this.panel1.TabIndex = 2;
            // 
            // tbxUF
            // 
            this.tbxUF.Location = new System.Drawing.Point(476, 40);
            this.tbxUF.Name = "tbxUF";
            this.tbxUF.Size = new System.Drawing.Size(31, 20);
            this.tbxUF.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "UF";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnPrimeiro,
            this.tbtnAnterior,
            this.tbtnProximo,
            this.tbtnUltimo,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tbxProcura,
            this.tbtnProcura});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(715, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnPrimeiro
            // 
            this.tbtnPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnPrimeiro.Image = global::ConsultaClientes.Properties.Resources.primeiro;
            this.tbtnPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnPrimeiro.Name = "tbtnPrimeiro";
            this.tbtnPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.tbtnPrimeiro.Text = "toolStripButton1";
            this.tbtnPrimeiro.Click += new System.EventHandler(this.tbtnPrimeiro_Click);
            // 
            // tbtnAnterior
            // 
            this.tbtnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAnterior.Image = global::ConsultaClientes.Properties.Resources.anterior;
            this.tbtnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAnterior.Name = "tbtnAnterior";
            this.tbtnAnterior.Size = new System.Drawing.Size(23, 22);
            this.tbtnAnterior.Text = "toolStripButton2";
            this.tbtnAnterior.Click += new System.EventHandler(this.tbtnAnterior_Click);
            // 
            // tbtnProximo
            // 
            this.tbtnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnProximo.Image = global::ConsultaClientes.Properties.Resources.proximo;
            this.tbtnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProximo.Name = "tbtnProximo";
            this.tbtnProximo.Size = new System.Drawing.Size(23, 22);
            this.tbtnProximo.Text = "toolStripButton3";
            this.tbtnProximo.Click += new System.EventHandler(this.tbtnProximo_Click);
            // 
            // tbtnUltimo
            // 
            this.tbtnUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnUltimo.Image = global::ConsultaClientes.Properties.Resources.ultimo;
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 22);
            this.toolStripLabel1.Text = "Procura Cliente";
            // 
            // tbxProcura
            // 
            this.tbxProcura.Name = "tbxProcura";
            this.tbxProcura.Size = new System.Drawing.Size(150, 25);
            this.tbxProcura.TextChanged += new System.EventHandler(this.tbxProcura_TextChanged);
            // 
            // tbtnProcura
            // 
            this.tbtnProcura.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnProcura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnProcura.Name = "tbtnProcura";
            this.tbtnProcura.Size = new System.Drawing.Size(23, 22);
            this.tbtnProcura.Text = "toolStripButton1";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Image = global::ConsultaClientes.Properties.Resources.Procurar4;
            this.btnFiltra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltra.Location = new System.Drawing.Point(530, 31);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(81, 28);
            this.btnFiltra.TabIndex = 4;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // tbxCidade
            // 
            this.tbxCidade.Location = new System.Drawing.Point(331, 39);
            this.tbxCidade.Name = "tbxCidade";
            this.tbxCidade.Size = new System.Drawing.Size(101, 20);
            this.tbxCidade.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cidade Contendo:";
            // 
            // tbxNome
            // 
            this.tbxNome.Location = new System.Drawing.Point(105, 39);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(122, 20);
            this.tbxNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Contendo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 454);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cadastro de Clientes (Dividindo em Camadas - LibPedidosDAL)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnPrimeiro;
        private System.Windows.Forms.ToolStripButton tbtnAnterior;
        private System.Windows.Forms.ToolStripButton tbtnProximo;
        private System.Windows.Forms.ToolStripButton tbtnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tbxProcura;
        private System.Windows.Forms.ToolStripButton tbtnProcura;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.TextBox tbxCidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxUF;
        private System.Windows.Forms.Label label3;
    }
}

