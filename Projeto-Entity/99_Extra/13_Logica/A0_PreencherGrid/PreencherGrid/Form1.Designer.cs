namespace PreencherGrid
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnMoldura = new System.Windows.Forms.Button();
            this.btnDiagonais = new System.Windows.Forms.Button();
            this.btnGeraGrid = new System.Windows.Forms.Button();
            this.btnLosango = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.ColumnHeadersVisible = false;
            this.dgv.Location = new System.Drawing.Point(388, 6);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 15;
            this.dgv.Size = new System.Drawing.Size(511, 485);
            this.dgv.TabIndex = 0;
            // 
            // btnMoldura
            // 
            this.btnMoldura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoldura.Location = new System.Drawing.Point(12, 68);
            this.btnMoldura.Name = "btnMoldura";
            this.btnMoldura.Size = new System.Drawing.Size(360, 26);
            this.btnMoldura.TabIndex = 1;
            this.btnMoldura.Text = "Moldura";
            this.btnMoldura.UseVisualStyleBackColor = true;
            this.btnMoldura.Click += new System.EventHandler(this.btnMoldura_Click);
            // 
            // btnDiagonais
            // 
            this.btnDiagonais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagonais.Location = new System.Drawing.Point(12, 100);
            this.btnDiagonais.Name = "btnDiagonais";
            this.btnDiagonais.Size = new System.Drawing.Size(360, 26);
            this.btnDiagonais.TabIndex = 2;
            this.btnDiagonais.Text = "Diagonais";
            this.btnDiagonais.UseVisualStyleBackColor = true;
            this.btnDiagonais.Click += new System.EventHandler(this.btnDiagonais_Click);
            // 
            // btnGeraGrid
            // 
            this.btnGeraGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraGrid.Location = new System.Drawing.Point(12, 36);
            this.btnGeraGrid.Name = "btnGeraGrid";
            this.btnGeraGrid.Size = new System.Drawing.Size(360, 26);
            this.btnGeraGrid.TabIndex = 3;
            this.btnGeraGrid.Text = "Gera Grid Vazio";
            this.btnGeraGrid.UseVisualStyleBackColor = true;
            this.btnGeraGrid.Click += new System.EventHandler(this.btnGeraGrid_Click);
            // 
            // btnLosango
            // 
            this.btnLosango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLosango.Location = new System.Drawing.Point(12, 132);
            this.btnLosango.Name = "btnLosango";
            this.btnLosango.Size = new System.Drawing.Size(360, 26);
            this.btnLosango.TabIndex = 4;
            this.btnLosango.Text = "Losango";
            this.btnLosango.UseVisualStyleBackColor = true;
            this.btnLosango.Click += new System.EventHandler(this.btnLosango_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 499);
            this.Controls.Add(this.btnLosango);
            this.Controls.Add(this.btnGeraGrid);
            this.Controls.Add(this.btnDiagonais);
            this.Controls.Add(this.btnMoldura);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Preencher Grid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMoldura;
        private System.Windows.Forms.Button btnDiagonais;
        private System.Windows.Forms.Button btnGeraGrid;
        private System.Windows.Forms.Button btnLosango;
    }
}

