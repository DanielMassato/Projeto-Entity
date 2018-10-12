namespace ADOISQL
{
    partial class FrmConfigCol
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvColunas = new System.Windows.Forms.DataGridView();
            this.Visivel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Campo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alinhamento = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Largura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 28);
            this.panel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(68, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sair";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(541, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(68, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Aplicar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(88, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sel. Nada";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sel. Tudo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvColunas
            // 
            this.dgvColunas.AllowUserToAddRows = false;
            this.dgvColunas.AllowUserToDeleteRows = false;
            this.dgvColunas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            this.dgvColunas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Visivel,
            this.Campo,
            this.Column3,
            this.Column4,
            this.Alinhamento,
            this.Largura});
            this.dgvColunas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvColunas.Location = new System.Drawing.Point(0, 0);
            this.dgvColunas.Name = "dgvColunas";
            this.dgvColunas.Size = new System.Drawing.Size(680, 305);
            this.dgvColunas.TabIndex = 2;
            // 
            // Visivel
            // 
            this.Visivel.HeaderText = "Visível:";
            this.Visivel.Name = "Visivel";
            this.Visivel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Visivel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Visivel.Width = 50;
            // 
            // Campo
            // 
            this.Campo.HeaderText = "Campo:";
            this.Campo.Name = "Campo";
            this.Campo.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Título:";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Formato:";
            this.Column4.Name = "Column4";
            // 
            // Alinhamento
            // 
            this.Alinhamento.HeaderText = "Alinhamento:";
            this.Alinhamento.Items.AddRange(new object[] {
            "Esquerda",
            "Centro",
            "Direita"});
            this.Alinhamento.Name = "Alinhamento";
            this.Alinhamento.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Alinhamento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Largura
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Largura.DefaultCellStyle = dataGridViewCellStyle2;
            this.Largura.HeaderText = "Largura:";
            this.Largura.Name = "Largura";
            this.Largura.Width = 60;
            // 
            // FrmConfigCol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 333);
            this.Controls.Add(this.dgvColunas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfigCol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configura Colunas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColunas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvColunas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Alinhamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Largura;
    }
}