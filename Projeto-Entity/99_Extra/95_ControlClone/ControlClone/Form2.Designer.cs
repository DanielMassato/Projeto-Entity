namespace ControlClone
{
    partial class Form2
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
            this.textBoxClone1 = new ControlClone.TextBoxClone();
            this.SuspendLayout();
            // 
            // textBoxClone1
            // 
            this.textBoxClone1.Clone = null;
            this.textBoxClone1.Location = new System.Drawing.Point(12, 3);
            this.textBoxClone1.Multiline = true;
            this.textBoxClone1.Name = "textBoxClone1";
            this.textBoxClone1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxClone1.Size = new System.Drawing.Size(300, 235);
            this.textBoxClone1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 275);
            this.Controls.Add(this.textBoxClone1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBoxClone textBoxClone1;



    }
}