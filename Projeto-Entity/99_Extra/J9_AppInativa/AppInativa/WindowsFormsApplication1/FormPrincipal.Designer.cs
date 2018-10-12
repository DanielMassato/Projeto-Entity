namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.btnAbreFormA = new System.Windows.Forms.Button();
            this.btnAbreFormB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAbreFormA
            // 
            this.btnAbreFormA.Location = new System.Drawing.Point(12, 73);
            this.btnAbreFormA.Name = "btnAbreFormA";
            this.btnAbreFormA.Size = new System.Drawing.Size(188, 23);
            this.btnAbreFormA.TabIndex = 0;
            this.btnAbreFormA.Text = "Abre o Form A";
            this.btnAbreFormA.UseVisualStyleBackColor = true;
            this.btnAbreFormA.Click += new System.EventHandler(this.btnAbreFormA_Click);
            // 
            // btnAbreFormB
            // 
            this.btnAbreFormB.Location = new System.Drawing.Point(264, 73);
            this.btnAbreFormB.Name = "btnAbreFormB";
            this.btnAbreFormB.Size = new System.Drawing.Size(188, 23);
            this.btnAbreFormB.TabIndex = 1;
            this.btnAbreFormB.Text = "Abre o Form B";
            this.btnAbreFormB.UseVisualStyleBackColor = true;
            this.btnAbreFormB.Click += new System.EventHandler(this.btnAbreFormB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo Inativo:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.Location = new System.Drawing.Point(260, 24);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(19, 20);
            this.lblTempo.TabIndex = 3;
            this.lblTempo.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(183, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 189);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblTempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAbreFormB);
            this.Controls.Add(this.btnAbreFormA);
            this.Name = "FormPrincipal";
            this.Text = "Form Principal da Aplicação";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbreFormA;
        private System.Windows.Forms.Button btnAbreFormB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

