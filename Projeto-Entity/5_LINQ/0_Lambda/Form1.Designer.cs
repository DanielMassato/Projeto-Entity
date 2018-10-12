namespace Lambda1
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
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiplica = new System.Windows.Forms.RadioButton();
            this.btnDivMult1 = new System.Windows.Forms.Button();
            this.btnDivMult2 = new System.Windows.Forms.Button();
            this.btnDivX1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(171, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(280, 383);
            this.lbx.TabIndex = 0;
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(20, 117);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(139, 25);
            this.btnQuadrado.TabIndex = 1;
            this.btnQuadrado.Text = "f(x) = x*x";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(18, 150);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(139, 25);
            this.btnSeno.TabIndex = 2;
            this.btnSeno.Text = "f(x) = sin( x )";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Checked = true;
            this.rbDivide.Location = new System.Drawing.Point(22, 13);
            this.rbDivide.Name = "rbDivide";
            this.rbDivide.Size = new System.Drawing.Size(55, 17);
            this.rbDivide.TabIndex = 3;
            this.rbDivide.TabStop = true;
            this.rbDivide.Text = "Divide";
            this.rbDivide.UseVisualStyleBackColor = true;
            // 
            // rbMultiplica
            // 
            this.rbMultiplica.AutoSize = true;
            this.rbMultiplica.Location = new System.Drawing.Point(95, 13);
            this.rbMultiplica.Name = "rbMultiplica";
            this.rbMultiplica.Size = new System.Drawing.Size(69, 17);
            this.rbMultiplica.TabIndex = 4;
            this.rbMultiplica.Text = "Multiplica";
            this.rbMultiplica.UseVisualStyleBackColor = true;
            // 
            // btnDivMult1
            // 
            this.btnDivMult1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivMult1.Location = new System.Drawing.Point(6, 33);
            this.btnDivMult1.Name = "btnDivMult1";
            this.btnDivMult1.Size = new System.Drawing.Size(159, 25);
            this.btnDivMult1.TabIndex = 5;
            this.btnDivMult1.Text = "Divide ou Multiplica";
            this.btnDivMult1.UseVisualStyleBackColor = true;
            this.btnDivMult1.Click += new System.EventHandler(this.btnDivMult1_Click);
            // 
            // btnDivMult2
            // 
            this.btnDivMult2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivMult2.Location = new System.Drawing.Point(7, 71);
            this.btnDivMult2.Name = "btnDivMult2";
            this.btnDivMult2.Size = new System.Drawing.Size(159, 25);
            this.btnDivMult2.TabIndex = 6;
            this.btnDivMult2.Text = "Divide ou Multiplica";
            this.btnDivMult2.UseVisualStyleBackColor = true;
            this.btnDivMult2.Click += new System.EventHandler(this.btnDivMult2_Click);
            // 
            // btnDivX1
            // 
            this.btnDivX1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivX1.Location = new System.Drawing.Point(17, 184);
            this.btnDivX1.Name = "btnDivX1";
            this.btnDivX1.Size = new System.Drawing.Size(139, 25);
            this.btnDivX1.TabIndex = 7;
            this.btnDivX1.Text = "f(x) = 1/x";
            this.btnDivX1.UseVisualStyleBackColor = true;
            this.btnDivX1.Click += new System.EventHandler(this.btnDivX1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "de 1 até 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDivX1);
            this.Controls.Add(this.btnDivMult2);
            this.Controls.Add(this.btnDivMult1);
            this.Controls.Add(this.rbMultiplica);
            this.Controls.Add(this.rbDivide);
            this.Controls.Add(this.btnSeno);
            this.Controls.Add(this.btnQuadrado);
            this.Controls.Add(this.lbx);
            this.Name = "Form1";
            this.Text = "Delegate e Expressões Lambda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiplica;
        private System.Windows.Forms.Button btnDivMult1;
        private System.Windows.Forms.Button btnDivMult2;
        private System.Windows.Forms.Button btnDivX1;
        private System.Windows.Forms.Label label1;
    }
}

