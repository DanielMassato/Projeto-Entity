namespace Fatorial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.updNum = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFatorial = new System.Windows.Forms.Label();
            this.btnCalcula = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.updNum)).BeginInit();
            this.SuspendLayout();
            // 
            // updNum
            // 
            this.updNum.Location = new System.Drawing.Point(23, 35);
            this.updNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updNum.Name = "updNum";
            this.updNum.Size = new System.Drawing.Size(84, 26);
            this.updNum.TabIndex = 0;
            this.updNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updNum.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatorial =";
            // 
            // lblFatorial
            // 
            this.lblFatorial.AutoSize = true;
            this.lblFatorial.Location = new System.Drawing.Point(110, 81);
            this.lblFatorial.Name = "lblFatorial";
            this.lblFatorial.Size = new System.Drawing.Size(69, 20);
            this.lblFatorial.TabIndex = 3;
            this.lblFatorial.Text = "______";
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(131, 24);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(126, 36);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "&Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.btnCalcula_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 116);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.lblFatorial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.updNum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Fatorial";
            ((System.ComponentModel.ISupportInitialize)(this.updNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown updNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFatorial;
        private System.Windows.Forms.Button btnCalcula;
    }
}

