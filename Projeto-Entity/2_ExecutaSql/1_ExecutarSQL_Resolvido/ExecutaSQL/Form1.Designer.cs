namespace ExecutaSQL
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbxSQL = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExecSQL = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvSelect = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPrimeiro = new System.Windows.Forms.ToolStripButton();
            this.tsbAnterior = new System.Windows.Forms.ToolStripButton();
            this.tsbProximo = new System.Windows.Forms.ToolStripButton();
            this.tsbUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvCampos = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvIndices = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbxTabelas = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.btnPelaAplicacao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExecParam = new System.Windows.Forms.Button();
            this.lblResposta = new System.Windows.Forms.Label();
            this.btnExecReader = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updNumPed = new System.Windows.Forms.NumericUpDown();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmbOrdem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFuncTabular = new System.Windows.Forms.Button();
            this.btnExecProc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.updAno = new System.Windows.Forms.NumericUpDown();
            this.btnExecView = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvProc = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndices)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updNumPed)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 33);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 404);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 33);
            this.panel2.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(12, 11);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(25, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "___";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 33);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 371);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tbxSQL);
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 345);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Comando SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbxSQL
            // 
            this.tbxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSQL.Location = new System.Drawing.Point(3, 40);
            this.tbxSQL.Multiline = true;
            this.tbxSQL.Name = "tbxSQL";
            this.tbxSQL.Size = new System.Drawing.Size(782, 302);
            this.tbxSQL.TabIndex = 3;
            this.tbxSQL.Text = "SELECT * FROM EMPREGADOS;\r\nSELECT * FROM CLIENTES;\r\n\r\nUPDATE EMPREGADOS SET SALAR" +
    "IO = 2000\r\nWHERE CODFUN = 1; ";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnExecSQL);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(782, 37);
            this.panel3.TabIndex = 2;
            // 
            // btnExecSQL
            // 
            this.btnExecSQL.Location = new System.Drawing.Point(19, 8);
            this.btnExecSQL.Name = "btnExecSQL";
            this.btnExecSQL.Size = new System.Drawing.Size(75, 23);
            this.btnExecSQL.TabIndex = 0;
            this.btnExecSQL.Text = "Executa";
            this.btnExecSQL.UseVisualStyleBackColor = true;
            this.btnExecSQL.Click += new System.EventHandler(this.btnExecSQL_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvSelect);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 345);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Resultado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvSelect
            // 
            this.dgvSelect.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSelect.Location = new System.Drawing.Point(3, 28);
            this.dgvSelect.Name = "dgvSelect";
            this.dgvSelect.ReadOnly = true;
            this.dgvSelect.Size = new System.Drawing.Size(782, 314);
            this.dgvSelect.TabIndex = 11;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPrimeiro,
            this.tsbAnterior,
            this.tsbProximo,
            this.tsbUltimo,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPrimeiro
            // 
            this.tsbPrimeiro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrimeiro.Image = global::ExecutaSQL.Properties.Resources.primeiro;
            this.tsbPrimeiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrimeiro.Name = "tsbPrimeiro";
            this.tsbPrimeiro.Size = new System.Drawing.Size(23, 22);
            this.tsbPrimeiro.Text = "toolStripButton1";
            this.tsbPrimeiro.ToolTipText = "Primeiro";
            this.tsbPrimeiro.Click += new System.EventHandler(this.tsbPrimeiro_Click);
            // 
            // tsbAnterior
            // 
            this.tsbAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAnterior.Image = global::ExecutaSQL.Properties.Resources.anterior;
            this.tsbAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAnterior.Name = "tsbAnterior";
            this.tsbAnterior.Size = new System.Drawing.Size(23, 22);
            this.tsbAnterior.Text = "toolStripButton2";
            this.tsbAnterior.ToolTipText = "Anterior";
            this.tsbAnterior.Click += new System.EventHandler(this.tsbAnterior_Click);
            // 
            // tsbProximo
            // 
            this.tsbProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProximo.Image = global::ExecutaSQL.Properties.Resources.proximo;
            this.tsbProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProximo.Name = "tsbProximo";
            this.tsbProximo.Size = new System.Drawing.Size(23, 22);
            this.tsbProximo.Text = "toolStripButton3";
            this.tsbProximo.ToolTipText = "Próximo";
            this.tsbProximo.Click += new System.EventHandler(this.tsbProximo_Click);
            // 
            // tsbUltimo
            // 
            this.tsbUltimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUltimo.Image = global::ExecutaSQL.Properties.Resources.ultimo;
            this.tsbUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUltimo.Name = "tsbUltimo";
            this.tsbUltimo.Size = new System.Drawing.Size(23, 22);
            this.tsbUltimo.Text = "toolStripButton4";
            this.tsbUltimo.ToolTipText = "Último";
            this.tsbUltimo.Click += new System.EventHandler(this.tsbUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Controls.Add(this.panel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(788, 345);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Tabelas e Estruturas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(156, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(629, 339);
            this.tabControl2.TabIndex = 5;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvCampos);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(621, 313);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Campos da Tabela";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvCampos
            // 
            this.dgvCampos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCampos.Location = new System.Drawing.Point(3, 3);
            this.dgvCampos.Name = "dgvCampos";
            this.dgvCampos.ReadOnly = true;
            this.dgvCampos.Size = new System.Drawing.Size(615, 307);
            this.dgvCampos.TabIndex = 3;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvIndices);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(621, 313);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Índices da Tabela";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvIndices
            // 
            this.dgvIndices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvIndices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIndices.Location = new System.Drawing.Point(3, 3);
            this.dgvIndices.Name = "dgvIndices";
            this.dgvIndices.ReadOnly = true;
            this.dgvIndices.Size = new System.Drawing.Size(615, 307);
            this.dgvIndices.TabIndex = 4;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dgvDados);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(621, 313);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Dados da Tabela";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 3);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(615, 307);
            this.dgvDados.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbxTabelas);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(153, 339);
            this.panel4.TabIndex = 4;
            // 
            // lbxTabelas
            // 
            this.lbxTabelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxTabelas.FormattingEnabled = true;
            this.lbxTabelas.Location = new System.Drawing.Point(0, 0);
            this.lbxTabelas.Name = "lbxTabelas";
            this.lbxTabelas.Size = new System.Drawing.Size(153, 339);
            this.lbxTabelas.TabIndex = 4;
            this.lbxTabelas.SelectedIndexChanged += new System.EventHandler(this.lbxTabelas_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.btnPelaAplicacao);
            this.tabPage7.Controls.Add(this.label5);
            this.tabPage7.Controls.Add(this.btnExecParam);
            this.tabPage7.Controls.Add(this.lblResposta);
            this.tabPage7.Controls.Add(this.btnExecReader);
            this.tabPage7.Controls.Add(this.label1);
            this.tabPage7.Controls.Add(this.updNumPed);
            this.tabPage7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(788, 345);
            this.tabPage7.TabIndex = 5;
            this.tabPage7.Text = "Executa Stored Procedure";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // btnPelaAplicacao
            // 
            this.btnPelaAplicacao.Location = new System.Drawing.Point(36, 117);
            this.btnPelaAplicacao.Name = "btnPelaAplicacao";
            this.btnPelaAplicacao.Size = new System.Drawing.Size(489, 48);
            this.btnPelaAplicacao.TabIndex = 6;
            this.btnPelaAplicacao.Text = "Pela Aplicação";
            this.btnPelaAplicacao.UseVisualStyleBackColor = true;
            this.btnPelaAplicacao.Click += new System.EventHandler(this.btnPelaAplicacao_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(782, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gera Cópia de um Pedido já Existente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExecParam
            // 
            this.btnExecParam.Location = new System.Drawing.Point(284, 172);
            this.btnExecParam.Name = "btnExecParam";
            this.btnExecParam.Size = new System.Drawing.Size(242, 74);
            this.btnExecParam.TabIndex = 4;
            this.btnExecParam.Text = "Executa Procedure c/ Param Output";
            this.btnExecParam.UseVisualStyleBackColor = true;
            this.btnExecParam.Click += new System.EventHandler(this.btnExecParam_Click);
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(17, 280);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(86, 20);
            this.lblResposta.TabIndex = 3;
            this.lblResposta.Text = "Resposta";
            // 
            // btnExecReader
            // 
            this.btnExecReader.Location = new System.Drawing.Point(36, 172);
            this.btnExecReader.Name = "btnExecReader";
            this.btnExecReader.Size = new System.Drawing.Size(242, 74);
            this.btnExecReader.TabIndex = 2;
            this.btnExecReader.Text = "Executa Procedure que Retorna SELECT";
            this.btnExecReader.UseVisualStyleBackColor = true;
            this.btnExecReader.Click += new System.EventHandler(this.btnExecReader_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Num.Pedido:";
            // 
            // updNumPed
            // 
            this.updNumPed.Location = new System.Drawing.Point(21, 80);
            this.updNumPed.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.updNumPed.Name = "updNumPed";
            this.updNumPed.Size = new System.Drawing.Size(100, 26);
            this.updNumPed.TabIndex = 0;
            this.updNumPed.Value = new decimal(new int[] {
            5136,
            0,
            0,
            0});
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.panel5);
            this.tabPage8.Controls.Add(this.dgvProc);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(788, 345);
            this.tabPage8.TabIndex = 6;
            this.tabPage8.Text = "View - Procedure - Função Tabular";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cmbOrdem);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnFuncTabular);
            this.panel5.Controls.Add(this.btnExecProc);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.updAno);
            this.panel5.Controls.Add(this.btnExecView);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(242, 339);
            this.panel5.TabIndex = 9;
            // 
            // cmbOrdem
            // 
            this.cmbOrdem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOrdem.FormattingEnabled = true;
            this.cmbOrdem.Items.AddRange(new object[] {
            "MES",
            "TOTAL_VENDIDO"});
            this.cmbOrdem.Location = new System.Drawing.Point(102, 258);
            this.cmbOrdem.Name = "cmbOrdem";
            this.cmbOrdem.Size = new System.Drawing.Size(129, 21);
            this.cmbOrdem.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Ordenar Por:";
            // 
            // btnFuncTabular
            // 
            this.btnFuncTabular.Location = new System.Drawing.Point(3, 292);
            this.btnFuncTabular.Name = "btnFuncTabular";
            this.btnFuncTabular.Size = new System.Drawing.Size(226, 30);
            this.btnFuncTabular.TabIndex = 17;
            this.btnFuncTabular.Text = "Função Tabular (recebe parâmetro)";
            this.btnFuncTabular.UseVisualStyleBackColor = true;
            this.btnFuncTabular.Click += new System.EventHandler(this.btnFuncTabular_Click);
            // 
            // btnExecProc
            // 
            this.btnExecProc.Location = new System.Drawing.Point(5, 211);
            this.btnExecProc.Name = "btnExecProc";
            this.btnExecProc.Size = new System.Drawing.Size(226, 30);
            this.btnExecProc.TabIndex = 16;
            this.btnExecProc.Text = "Stored Procedure (recebe parâmetro)";
            this.btnExecProc.UseVisualStyleBackColor = true;
            this.btnExecProc.Click += new System.EventHandler(this.btnExecProc_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 84);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total vendido em cada um dos meses do ano.\r\nRetorna dado tabular\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // updAno
            // 
            this.updAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updAno.Location = new System.Drawing.Point(108, 173);
            this.updAno.Maximum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.updAno.Minimum = new decimal(new int[] {
            2007,
            0,
            0,
            0});
            this.updAno.Name = "updAno";
            this.updAno.Size = new System.Drawing.Size(61, 22);
            this.updAno.TabIndex = 13;
            this.updAno.Value = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            // 
            // btnExecView
            // 
            this.btnExecView.Location = new System.Drawing.Point(4, 109);
            this.btnExecView.Name = "btnExecView";
            this.btnExecView.Size = new System.Drawing.Size(226, 30);
            this.btnExecView.TabIndex = 12;
            this.btnExecView.Text = "View (não recebe parâmetro)";
            this.btnExecView.UseVisualStyleBackColor = true;
            this.btnExecView.Click += new System.EventHandler(this.btnExecView_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Ano:";
            // 
            // dgvProc
            // 
            this.dgvProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProc.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvProc.Location = new System.Drawing.Point(245, 3);
            this.dgvProc.Name = "dgvProc";
            this.dgvProc.Size = new System.Drawing.Size(540, 339);
            this.dgvProc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 437);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Execução de Comandos SQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelect)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampos)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndices)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updNumPed)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox tbxSQL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnExecSQL;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ListBox lbxTabelas;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvCampos;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvIndices;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.ToolStripButton tsbPrimeiro;
        private System.Windows.Forms.ToolStripButton tsbAnterior;
        private System.Windows.Forms.ToolStripButton tsbProximo;
        private System.Windows.Forms.ToolStripButton tsbUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvSelect;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.Button btnExecReader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updNumPed;
        private System.Windows.Forms.Button btnExecParam;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.DataGridView dgvProc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnFuncTabular;
        private System.Windows.Forms.Button btnExecProc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updAno;
        private System.Windows.Forms.Button btnExecView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbOrdem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPelaAplicacao;
        private System.Windows.Forms.Label label5;

    }
}

