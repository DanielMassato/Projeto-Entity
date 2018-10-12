namespace ExprRegular
{
    partial class FormPrincipal
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tbxExprReg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExato = new System.Windows.Forms.Button();
            this.btnExtrai = new System.Windows.Forms.Button();
            this.lblResutado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnContem = new System.Windows.Forms.Button();
            this.tbxTeste = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvExemplos = new System.Windows.Forms.DataGridView();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExemplos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAjuda);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.tbxExprReg);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expressão Regular";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(403, 13);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 35);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar em Exemplos";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tbxExprReg
            // 
            this.tbxExprReg.Location = new System.Drawing.Point(12, 23);
            this.tbxExprReg.Name = "tbxExprReg";
            this.tbxExprReg.Size = new System.Drawing.Size(385, 20);
            this.tbxExprReg.TabIndex = 0;
            this.tbxExprReg.Text = "[A-Z]{3}-[0-9]{4}";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExato);
            this.groupBox2.Controls.Add(this.btnExtrai);
            this.groupBox2.Controls.Add(this.lblResutado);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnContem);
            this.groupBox2.Controls.Add(this.tbxTeste);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 132);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Testa Expressão Regular";
            // 
            // btnExato
            // 
            this.btnExato.Location = new System.Drawing.Point(176, 51);
            this.btnExato.Name = "btnExato";
            this.btnExato.Size = new System.Drawing.Size(75, 23);
            this.btnExato.TabIndex = 5;
            this.btnExato.Text = "Exato";
            this.btnExato.UseVisualStyleBackColor = true;
            this.btnExato.Click += new System.EventHandler(this.btnExato_Click);
            // 
            // btnExtrai
            // 
            this.btnExtrai.Location = new System.Drawing.Point(95, 51);
            this.btnExtrai.Name = "btnExtrai";
            this.btnExtrai.Size = new System.Drawing.Size(75, 23);
            this.btnExtrai.TabIndex = 4;
            this.btnExtrai.Text = "Extrai";
            this.btnExtrai.UseVisualStyleBackColor = true;
            this.btnExtrai.Click += new System.EventHandler(this.btnExtrai_Click);
            // 
            // lblResutado
            // 
            this.lblResutado.AutoSize = true;
            this.lblResutado.Location = new System.Drawing.Point(15, 107);
            this.lblResutado.Name = "lblResutado";
            this.lblResutado.Size = new System.Drawing.Size(139, 13);
            this.lblResutado.TabIndex = 3;
            this.lblResutado.Text = "______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Resultado:";
            // 
            // btnContem
            // 
            this.btnContem.Location = new System.Drawing.Point(14, 51);
            this.btnContem.Name = "btnContem";
            this.btnContem.Size = new System.Drawing.Size(75, 23);
            this.btnContem.TabIndex = 1;
            this.btnContem.Text = "Contem";
            this.btnContem.UseVisualStyleBackColor = true;
            this.btnContem.Click += new System.EventHandler(this.btnContem_Click);
            // 
            // tbxTeste
            // 
            this.tbxTeste.Location = new System.Drawing.Point(12, 23);
            this.tbxTeste.Name = "tbxTeste";
            this.tbxTeste.Size = new System.Drawing.Size(385, 20);
            this.tbxTeste.TabIndex = 0;
            this.tbxTeste.Text = "123ABC-1234DJDH";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvExemplos);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Exemplos";
            // 
            // dgvExemplos
            // 
            this.dgvExemplos.AllowUserToAddRows = false;
            this.dgvExemplos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExemplos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvExemplos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExemplos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvExemplos.Location = new System.Drawing.Point(3, 16);
            this.dgvExemplos.Name = "dgvExemplos";
            this.dgvExemplos.Size = new System.Drawing.Size(515, 135);
            this.dgvExemplos.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAjuda.Image = global::ExprRegular.Properties.Resources.HELP3;
            this.btnAjuda.Location = new System.Drawing.Point(474, 13);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(40, 35);
            this.btnAjuda.TabIndex = 2;
            this.btnAjuda.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Expressão";
            this.Column1.Name = "Column1";
            this.Column1.Width = 250;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Função";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 340);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPrincipal";
            this.Text = "Expressões Regulares";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExemplos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxExprReg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResutado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnContem;
        private System.Windows.Forms.TextBox tbxTeste;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvExemplos;
        private System.Windows.Forms.Button btnExtrai;
        private System.Windows.Forms.Button btnExato;
        private System.Windows.Forms.Button btnAjuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

