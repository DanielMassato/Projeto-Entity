namespace Relatorios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFiltra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDescricao = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvVendedores = new System.Windows.Forms.DataGridView();
            this.iDPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cODPRODUTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRICAODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECOVENDADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTDREALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUTOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetRelatorios = new Relatorios.DataSetRelatorios();
            this.cLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cODVENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRODUTOSTableAdapter = new Relatorios.DataSetRelatoriosTableAdapters.PRODUTOSTableAdapter();
            this.cLIENTESTableAdapter = new Relatorios.DataSetRelatoriosTableAdapters.CLIENTESTableAdapter();
            this.vENDEDORESTableAdapter = new Relatorios.DataSetRelatoriosTableAdapters.VENDEDORESTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cODCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eSTADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dbNavigator11 = new LibComponentes.DBNavigator1();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRelatorio);
            this.groupBox1.Controls.Add(this.btnConsulta);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Location = new System.Drawing.Point(613, 16);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(125, 23);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "Imprime Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(8, 16);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(125, 23);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Atualiza Consulta";
            this.btnConsulta.UseVisualStyleBackColor = true;
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
            this.tabControl1.Size = new System.Drawing.Size(750, 338);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvProdutos);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(742, 312);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Produtos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.AutoGenerateColumns = false;
            this.dgvProdutos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPRODUTODataGridViewTextBoxColumn,
            this.cODPRODUTODataGridViewTextBoxColumn,
            this.dESCRICAODataGridViewTextBoxColumn,
            this.pRECOVENDADataGridViewTextBoxColumn,
            this.qTDREALDataGridViewTextBoxColumn});
            this.dgvProdutos.DataSource = this.pRODUTOSBindingSource;
            this.dgvProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProdutos.Location = new System.Drawing.Point(3, 3);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(736, 259);
            this.dgvProdutos.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFiltra);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbxDescricao);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(3, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 47);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro:";
            // 
            // btnFiltra
            // 
            this.btnFiltra.Location = new System.Drawing.Point(270, 19);
            this.btnFiltra.Name = "btnFiltra";
            this.btnFiltra.Size = new System.Drawing.Size(75, 23);
            this.btnFiltra.TabIndex = 2;
            this.btnFiltra.Text = "Filtra";
            this.btnFiltra.UseVisualStyleBackColor = true;
            this.btnFiltra.Click += new System.EventHandler(this.btnFiltra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descrição Contendo:";
            // 
            // tbxDescricao
            // 
            this.tbxDescricao.Location = new System.Drawing.Point(127, 21);
            this.tbxDescricao.Name = "tbxDescricao";
            this.tbxDescricao.Size = new System.Drawing.Size(125, 20);
            this.tbxDescricao.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvClientes);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(742, 312);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvVendedores);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(742, 312);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Vendedores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvVendedores
            // 
            this.dgvVendedores.AutoGenerateColumns = false;
            this.dgvVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODVENDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn1,
            this.cIDADEDataGridViewTextBoxColumn1,
            this.eSTADODataGridViewTextBoxColumn1,
            this.cEPDataGridViewTextBoxColumn1});
            this.dgvVendedores.DataSource = this.vENDEDORESBindingSource;
            this.dgvVendedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVendedores.Location = new System.Drawing.Point(3, 3);
            this.dgvVendedores.Name = "dgvVendedores";
            this.dgvVendedores.Size = new System.Drawing.Size(736, 306);
            this.dgvVendedores.TabIndex = 1;
            // 
            // iDPRODUTODataGridViewTextBoxColumn
            // 
            this.iDPRODUTODataGridViewTextBoxColumn.DataPropertyName = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.HeaderText = "ID_PRODUTO";
            this.iDPRODUTODataGridViewTextBoxColumn.Name = "iDPRODUTODataGridViewTextBoxColumn";
            this.iDPRODUTODataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPRODUTODataGridViewTextBoxColumn.Width = 103;
            // 
            // cODPRODUTODataGridViewTextBoxColumn
            // 
            this.cODPRODUTODataGridViewTextBoxColumn.DataPropertyName = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.HeaderText = "COD_PRODUTO";
            this.cODPRODUTODataGridViewTextBoxColumn.Name = "cODPRODUTODataGridViewTextBoxColumn";
            this.cODPRODUTODataGridViewTextBoxColumn.Width = 115;
            // 
            // dESCRICAODataGridViewTextBoxColumn
            // 
            this.dESCRICAODataGridViewTextBoxColumn.DataPropertyName = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.HeaderText = "DESCRICAO";
            this.dESCRICAODataGridViewTextBoxColumn.Name = "dESCRICAODataGridViewTextBoxColumn";
            this.dESCRICAODataGridViewTextBoxColumn.Width = 94;
            // 
            // pRECOVENDADataGridViewTextBoxColumn
            // 
            this.pRECOVENDADataGridViewTextBoxColumn.DataPropertyName = "PRECO_VENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.HeaderText = "PRECO_VENDA";
            this.pRECOVENDADataGridViewTextBoxColumn.Name = "pRECOVENDADataGridViewTextBoxColumn";
            this.pRECOVENDADataGridViewTextBoxColumn.Width = 112;
            // 
            // qTDREALDataGridViewTextBoxColumn
            // 
            this.qTDREALDataGridViewTextBoxColumn.DataPropertyName = "QTD_REAL";
            this.qTDREALDataGridViewTextBoxColumn.HeaderText = "QTD_REAL";
            this.qTDREALDataGridViewTextBoxColumn.Name = "qTDREALDataGridViewTextBoxColumn";
            this.qTDREALDataGridViewTextBoxColumn.Width = 89;
            // 
            // pRODUTOSBindingSource
            // 
            this.pRODUTOSBindingSource.DataMember = "PRODUTOS";
            this.pRODUTOSBindingSource.DataSource = this.dataSetRelatorios;
            // 
            // dataSetRelatorios
            // 
            this.dataSetRelatorios.DataSetName = "DataSetRelatorios";
            this.dataSetRelatorios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTESBindingSource
            // 
            this.cLIENTESBindingSource.DataMember = "CLIENTES";
            this.cLIENTESBindingSource.DataSource = this.dataSetRelatorios;
            // 
            // cODVENDataGridViewTextBoxColumn
            // 
            this.cODVENDataGridViewTextBoxColumn.DataPropertyName = "CODVEN";
            this.cODVENDataGridViewTextBoxColumn.HeaderText = "CODVEN";
            this.cODVENDataGridViewTextBoxColumn.Name = "cODVENDataGridViewTextBoxColumn";
            this.cODVENDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODVENDataGridViewTextBoxColumn.Width = 77;
            // 
            // nOMEDataGridViewTextBoxColumn1
            // 
            this.nOMEDataGridViewTextBoxColumn1.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn1.Name = "nOMEDataGridViewTextBoxColumn1";
            this.nOMEDataGridViewTextBoxColumn1.Width = 64;
            // 
            // cIDADEDataGridViewTextBoxColumn1
            // 
            this.cIDADEDataGridViewTextBoxColumn1.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn1.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn1.Name = "cIDADEDataGridViewTextBoxColumn1";
            this.cIDADEDataGridViewTextBoxColumn1.Width = 72;
            // 
            // eSTADODataGridViewTextBoxColumn1
            // 
            this.eSTADODataGridViewTextBoxColumn1.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn1.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn1.Name = "eSTADODataGridViewTextBoxColumn1";
            this.eSTADODataGridViewTextBoxColumn1.Width = 76;
            // 
            // cEPDataGridViewTextBoxColumn1
            // 
            this.cEPDataGridViewTextBoxColumn1.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn1.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn1.Name = "cEPDataGridViewTextBoxColumn1";
            this.cEPDataGridViewTextBoxColumn1.Width = 53;
            // 
            // vENDEDORESBindingSource
            // 
            this.vENDEDORESBindingSource.DataMember = "VENDEDORES";
            this.vENDEDORESBindingSource.DataSource = this.dataSetRelatorios;
            // 
            // pRODUTOSTableAdapter
            // 
            this.pRODUTOSTableAdapter.ClearBeforeFill = true;
            // 
            // cLIENTESTableAdapter
            // 
            this.cLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // vENDEDORESTableAdapter
            // 
            this.vENDEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dbNavigator11);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(736, 46);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLIDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.eSTADODataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.cLIENTESBindingSource;
            this.dgvClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvClientes.Location = new System.Drawing.Point(3, 49);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(736, 260);
            this.dgvClientes.TabIndex = 3;
            // 
            // cODCLIDataGridViewTextBoxColumn
            // 
            this.cODCLIDataGridViewTextBoxColumn.DataPropertyName = "CODCLI";
            this.cODCLIDataGridViewTextBoxColumn.HeaderText = "CODCLI";
            this.cODCLIDataGridViewTextBoxColumn.Name = "cODCLIDataGridViewTextBoxColumn";
            this.cODCLIDataGridViewTextBoxColumn.ReadOnly = true;
            this.cODCLIDataGridViewTextBoxColumn.Width = 71;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "NOME";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.Width = 64;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.Width = 72;
            // 
            // eSTADODataGridViewTextBoxColumn
            // 
            this.eSTADODataGridViewTextBoxColumn.DataPropertyName = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.HeaderText = "ESTADO";
            this.eSTADODataGridViewTextBoxColumn.Name = "eSTADODataGridViewTextBoxColumn";
            this.eSTADODataGridViewTextBoxColumn.Width = 76;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.Width = 53;
            // 
            // dbNavigator11
            // 
            this.dbNavigator11.BindingSource = this.cLIENTESBindingSource;
            this.dbNavigator11.Location = new System.Drawing.Point(6, 11);
            this.dbNavigator11.Name = "dbNavigator11";
            this.dbNavigator11.Size = new System.Drawing.Size(103, 24);
            this.dbNavigator11.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 389);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Relatórios";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRODUTOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetRelatorios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvVendedores;
        private DataSetRelatorios dataSetRelatorios;
        private System.Windows.Forms.BindingSource pRODUTOSBindingSource;
        private DataSetRelatoriosTableAdapters.PRODUTOSTableAdapter pRODUTOSTableAdapter;
        private System.Windows.Forms.BindingSource cLIENTESBindingSource;
        private DataSetRelatoriosTableAdapters.CLIENTESTableAdapter cLIENTESTableAdapter;
        private System.Windows.Forms.BindingSource vENDEDORESBindingSource;
        private DataSetRelatoriosTableAdapters.VENDEDORESTableAdapter vENDEDORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODVENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODPRODUTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRICAODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECOVENDADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTDREALDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFiltra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDescricao;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eSTADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox3;
        private LibComponentes.DBNavigator1 dbNavigator11;
    }
}

