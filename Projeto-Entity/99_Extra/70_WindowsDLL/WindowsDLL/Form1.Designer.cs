namespace WindowsDLL
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
            this.btnOcultaTB = new System.Windows.Forms.Button();
            this.btnMostraTB = new System.Windows.Forms.Button();
            this.btnDisCtrlAltDel = new System.Windows.Forms.Button();
            this.btnEnCtrlAltDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOcultaTB
            // 
            this.btnOcultaTB.Location = new System.Drawing.Point(12, 12);
            this.btnOcultaTB.Name = "btnOcultaTB";
            this.btnOcultaTB.Size = new System.Drawing.Size(75, 23);
            this.btnOcultaTB.TabIndex = 0;
            this.btnOcultaTB.Text = "Oculta TB";
            this.btnOcultaTB.UseVisualStyleBackColor = true;
            this.btnOcultaTB.Click += new System.EventHandler(this.btnOcultaTB_Click);
            // 
            // btnMostraTB
            // 
            this.btnMostraTB.Location = new System.Drawing.Point(93, 12);
            this.btnMostraTB.Name = "btnMostraTB";
            this.btnMostraTB.Size = new System.Drawing.Size(75, 23);
            this.btnMostraTB.TabIndex = 1;
            this.btnMostraTB.Text = "Mostra TB";
            this.btnMostraTB.UseVisualStyleBackColor = true;
            this.btnMostraTB.Click += new System.EventHandler(this.btnMostraTB_Click);
            // 
            // btnDisCtrlAltDel
            // 
            this.btnDisCtrlAltDel.Location = new System.Drawing.Point(12, 57);
            this.btnDisCtrlAltDel.Name = "btnDisCtrlAltDel";
            this.btnDisCtrlAltDel.Size = new System.Drawing.Size(131, 23);
            this.btnDisCtrlAltDel.TabIndex = 2;
            this.btnDisCtrlAltDel.Text = "Desab. Task Manager";
            this.btnDisCtrlAltDel.UseVisualStyleBackColor = true;
            this.btnDisCtrlAltDel.Click += new System.EventHandler(this.btnDisCtrlAltDel_Click);
            // 
            // btnEnCtrlAltDel
            // 
            this.btnEnCtrlAltDel.Location = new System.Drawing.Point(149, 57);
            this.btnEnCtrlAltDel.Name = "btnEnCtrlAltDel";
            this.btnEnCtrlAltDel.Size = new System.Drawing.Size(131, 23);
            this.btnEnCtrlAltDel.TabIndex = 3;
            this.btnEnCtrlAltDel.Text = "Habil. Task Manager";
            this.btnEnCtrlAltDel.UseVisualStyleBackColor = true;
            this.btnEnCtrlAltDel.Click += new System.EventHandler(this.btnEnCtrlAltDel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 128);
            this.Controls.Add(this.btnEnCtrlAltDel);
            this.Controls.Add(this.btnDisCtrlAltDel);
            this.Controls.Add(this.btnMostraTB);
            this.Controls.Add(this.btnOcultaTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOcultaTB;
        private System.Windows.Forms.Button btnMostraTB;
        private System.Windows.Forms.Button btnDisCtrlAltDel;
        private System.Windows.Forms.Button btnEnCtrlAltDel;
    }
}

