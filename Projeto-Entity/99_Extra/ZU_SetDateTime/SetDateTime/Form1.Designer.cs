namespace SetDateTime
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
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.btnSetDate = new System.Windows.Forms.Button();
            this.wb = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.tbxHTML = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpData
            // 
            this.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData.Location = new System.Drawing.Point(42, 31);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(93, 20);
            this.dtpData.TabIndex = 0;
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(141, 31);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(79, 20);
            this.dtpHora.TabIndex = 1;
            // 
            // btnSetDate
            // 
            this.btnSetDate.Location = new System.Drawing.Point(239, 23);
            this.btnSetDate.Name = "btnSetDate";
            this.btnSetDate.Size = new System.Drawing.Size(131, 27);
            this.btnSetDate.TabIndex = 2;
            this.btnSetDate.Text = "Corrige Data do Sistema";
            this.btnSetDate.UseVisualStyleBackColor = true;
            this.btnSetDate.Click += new System.EventHandler(this.btnSetDate_Click);
            // 
            // wb
            // 
            this.wb.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wb.Location = new System.Drawing.Point(0, 220);
            this.wb.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(691, 250);
            this.wb.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(390, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbxHTML
            // 
            this.tbxHTML.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxHTML.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHTML.Location = new System.Drawing.Point(0, 76);
            this.tbxHTML.Multiline = true;
            this.tbxHTML.Name = "tbxHTML";
            this.tbxHTML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxHTML.Size = new System.Drawing.Size(691, 144);
            this.tbxHTML.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxHTML);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wb);
            this.Controls.Add(this.btnSetDate);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Button btnSetDate;
        private System.Windows.Forms.WebBrowser wb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbxHTML;
        private System.Windows.Forms.Label label1;
    }
}

