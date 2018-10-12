namespace DesafioSequencia
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
            this.btnCalcSeq = new System.Windows.Forms.Button();
            this.lblNMaior = new System.Windows.Forms.Label();
            this.lblQMaior = new System.Windows.Forms.Label();
            this.lblTempo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTotEltos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGeraSeq = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.updN = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updFim = new System.Windows.Forms.NumericUpDown();
            this.updIni = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnLimpaMatriz = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updIni)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcSeq
            // 
            this.btnCalcSeq.Location = new System.Drawing.Point(268, 71);
            this.btnCalcSeq.Name = "btnCalcSeq";
            this.btnCalcSeq.Size = new System.Drawing.Size(75, 23);
            this.btnCalcSeq.TabIndex = 0;
            this.btnCalcSeq.Text = "Calcula";
            this.btnCalcSeq.UseVisualStyleBackColor = true;
            this.btnCalcSeq.Click += new System.EventHandler(this.btnCalcSeq_Click);
            // 
            // lblNMaior
            // 
            this.lblNMaior.AutoSize = true;
            this.lblNMaior.Location = new System.Drawing.Point(267, 105);
            this.lblNMaior.Name = "lblNMaior";
            this.lblNMaior.Size = new System.Drawing.Size(13, 13);
            this.lblNMaior.TabIndex = 3;
            this.lblNMaior.Text = "0";
            // 
            // lblQMaior
            // 
            this.lblQMaior.AutoSize = true;
            this.lblQMaior.Location = new System.Drawing.Point(267, 127);
            this.lblQMaior.Name = "lblQMaior";
            this.lblQMaior.Size = new System.Drawing.Size(13, 13);
            this.lblQMaior.TabIndex = 4;
            this.lblQMaior.Text = "0";
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Location = new System.Drawing.Point(267, 150);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(62, 13);
            this.lblTempo.TabIndex = 6;
            this.lblTempo.Text = "0 segundos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 247);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblT);
            this.tabPage1.Controls.Add(this.lblTotEltos);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnGeraSeq);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.updN);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.dgv);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 221);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gera Seqência";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblT
            // 
            this.lblT.Location = new System.Drawing.Point(63, 187);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(101, 13);
            this.lblT.TabIndex = 15;
            this.lblT.Text = "0 segundos";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotEltos
            // 
            this.lblTotEltos.AutoSize = true;
            this.lblTotEltos.Location = new System.Drawing.Point(156, 159);
            this.lblTotEltos.Name = "lblTotEltos";
            this.lblTotEltos.Size = new System.Drawing.Size(13, 13);
            this.lblTotEltos.TabIndex = 14;
            this.lblTotEltos.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total de Elementos:";
            // 
            // btnGeraSeq
            // 
            this.btnGeraSeq.Location = new System.Drawing.Point(129, 117);
            this.btnGeraSeq.Name = "btnGeraSeq";
            this.btnGeraSeq.Size = new System.Drawing.Size(99, 23);
            this.btnGeraSeq.TabIndex = 12;
            this.btnGeraSeq.Text = "Gera Seqência";
            this.btnGeraSeq.UseVisualStyleBackColor = true;
            this.btnGeraSeq.Click += new System.EventHandler(this.btnGeraSeq_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "1o. Elemento:";
            // 
            // updN
            // 
            this.updN.Location = new System.Drawing.Point(21, 119);
            this.updN.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.updN.Name = "updN";
            this.updN.Size = new System.Drawing.Size(92, 20);
            this.updN.TabIndex = 10;
            this.updN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updN.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 88);
            this.label3.TabIndex = 9;
            this.label3.Text = "A sequência será formada de acordo com a regra:\r\n\r\n    Se n é par, próx. elto = n" +
                " / 2\r\n    Se n é impar, próx elto = 3 * n + 1\r\n\r\nEsta sequência sempre termina e" +
                "m 1\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv.Location = new System.Drawing.Point(272, 3);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(148, 215);
            this.dgv.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnLimpaMatriz);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.updFim);
            this.tabPage2.Controls.Add(this.lblTempo);
            this.tabPage2.Controls.Add(this.updIni);
            this.tabPage2.Controls.Add(this.lblQMaior);
            this.tabPage2.Controls.Add(this.btnCalcSeq);
            this.tabPage2.Controls.Add(this.lblNMaior);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 221);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calcula Maior Sequência";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Até:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "De:";
            // 
            // updFim
            // 
            this.updFim.Location = new System.Drawing.Point(149, 71);
            this.updFim.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.updFim.Name = "updFim";
            this.updFim.Size = new System.Drawing.Size(98, 20);
            this.updFim.TabIndex = 4;
            this.updFim.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updFim.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // updIni
            // 
            this.updIni.Location = new System.Drawing.Point(34, 71);
            this.updIni.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.updIni.Name = "updIni";
            this.updIni.Size = new System.Drawing.Size(98, 20);
            this.updIni.TabIndex = 3;
            this.updIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updIni.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Número com Maior Seqência:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(97, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total de Elementos da Seqência:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tempo de Processamento:";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(417, 32);
            this.label9.TabIndex = 12;
            this.label9.Text = "Mostra qual número possui a maior sequênca do intervalo fornecido";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLimpaMatriz
            // 
            this.btnLimpaMatriz.Location = new System.Drawing.Point(117, 178);
            this.btnLimpaMatriz.Name = "btnLimpaMatriz";
            this.btnLimpaMatriz.Size = new System.Drawing.Size(167, 23);
            this.btnLimpaMatriz.TabIndex = 13;
            this.btnLimpaMatriz.Text = "Limpar Matriz";
            this.btnLimpaMatriz.UseVisualStyleBackColor = true;
            this.btnLimpaMatriz.Click += new System.EventHandler(this.btnLimpaMatriz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 247);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Otimização de Processo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updFim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updIni)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalcSeq;
        private System.Windows.Forms.Label lblNMaior;
        private System.Windows.Forms.Label lblQMaior;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown updFim;
        private System.Windows.Forms.NumericUpDown updIni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnGeraSeq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updN;
        private System.Windows.Forms.Label lblTotEltos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnLimpaMatriz;
    }
}

