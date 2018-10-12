namespace ExitWindows
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDesligar = new System.Windows.Forms.RadioButton();
            this.rbReiniciar = new System.Windows.Forms.RadioButton();
            this.rbLogOff = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sair Windows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLogOff);
            this.groupBox1.Controls.Add(this.rbReiniciar);
            this.groupBox1.Controls.Add(this.rbDesligar);
            this.groupBox1.Location = new System.Drawing.Point(50, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Razão";
            // 
            // rbDesligar
            // 
            this.rbDesligar.AutoSize = true;
            this.rbDesligar.Location = new System.Drawing.Point(50, 32);
            this.rbDesligar.Name = "rbDesligar";
            this.rbDesligar.Size = new System.Drawing.Size(63, 17);
            this.rbDesligar.TabIndex = 0;
            this.rbDesligar.TabStop = true;
            this.rbDesligar.Text = "Desligar";
            this.rbDesligar.UseVisualStyleBackColor = true;
            // 
            // rbReiniciar
            // 
            this.rbReiniciar.AutoSize = true;
            this.rbReiniciar.Location = new System.Drawing.Point(50, 55);
            this.rbReiniciar.Name = "rbReiniciar";
            this.rbReiniciar.Size = new System.Drawing.Size(66, 17);
            this.rbReiniciar.TabIndex = 1;
            this.rbReiniciar.TabStop = true;
            this.rbReiniciar.Text = "Reiniciar";
            this.rbReiniciar.UseVisualStyleBackColor = true;
            // 
            // rbLogOff
            // 
            this.rbLogOff.AutoSize = true;
            this.rbLogOff.Location = new System.Drawing.Point(50, 78);
            this.rbLogOff.Name = "rbLogOff";
            this.rbLogOff.Size = new System.Drawing.Size(57, 17);
            this.rbLogOff.TabIndex = 2;
            this.rbLogOff.TabStop = true;
            this.rbLogOff.Text = "LogOff";
            this.rbLogOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbLogOff;
        private System.Windows.Forms.RadioButton rbReiniciar;
        private System.Windows.Forms.RadioButton rbDesligar;
    }
}

