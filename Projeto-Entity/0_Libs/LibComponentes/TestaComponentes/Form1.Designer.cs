namespace TestaComponentes
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
            this.turbina1 = new LibComponentes.Turbina();
            this.textBoxEx5 = new LibComponentes.TextBoxEx();
            this.textBoxEx6 = new LibComponentes.TextBoxEx();
            this.textBoxEx7 = new LibComponentes.TextBoxEx();
            this.textBoxEx8 = new LibComponentes.TextBoxEx();
            this.textBoxEx3 = new LibComponentes.TextBoxEx();
            this.textBoxEx4 = new LibComponentes.TextBoxEx();
            this.textBoxEx2 = new LibComponentes.TextBoxEx();
            this.textBoxEx1 = new LibComponentes.TextBoxEx();
            this.convTemperaturas1 = new LibComponentes.ConvTemperaturas();
            this.convTemperaturas2 = new LibComponentes.ConvTemperaturas();
            this.SuspendLayout();
            // 
            // turbina1
            // 
            this.turbina1.Location = new System.Drawing.Point(316, 65);
            this.turbina1.Name = "turbina1";
            this.turbina1.Size = new System.Drawing.Size(183, 192);
            this.turbina1.TabIndex = 8;
            this.turbina1.Text = "turbina1";
            this.turbina1.TurbineActive = false;
            this.turbina1.TurbineColorOff = System.Drawing.Color.Gray;
            this.turbina1.TurbineColorOn = System.Drawing.Color.Red;
            this.turbina1.TurbinePenColor = System.Drawing.Color.Black;
            this.turbina1.TurbinePenWidth = ((byte)(1));
            // 
            // textBoxEx5
            // 
            this.textBoxEx5.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx5.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx5.Location = new System.Drawing.Point(38, 217);
            this.textBoxEx5.Name = "textBoxEx5";
            this.textBoxEx5.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx5.TabIndex = 7;
            // 
            // textBoxEx6
            // 
            this.textBoxEx6.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx6.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx6.Location = new System.Drawing.Point(38, 191);
            this.textBoxEx6.Name = "textBoxEx6";
            this.textBoxEx6.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx6.TabIndex = 6;
            // 
            // textBoxEx7
            // 
            this.textBoxEx7.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx7.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx7.Location = new System.Drawing.Point(38, 166);
            this.textBoxEx7.Name = "textBoxEx7";
            this.textBoxEx7.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx7.TabIndex = 5;
            // 
            // textBoxEx8
            // 
            this.textBoxEx8.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx8.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx8.Location = new System.Drawing.Point(38, 140);
            this.textBoxEx8.Name = "textBoxEx8";
            this.textBoxEx8.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx8.TabIndex = 4;
            // 
            // textBoxEx3
            // 
            this.textBoxEx3.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx3.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx3.Location = new System.Drawing.Point(38, 116);
            this.textBoxEx3.Name = "textBoxEx3";
            this.textBoxEx3.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx3.TabIndex = 3;
            // 
            // textBoxEx4
            // 
            this.textBoxEx4.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx4.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx4.Location = new System.Drawing.Point(38, 90);
            this.textBoxEx4.Name = "textBoxEx4";
            this.textBoxEx4.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx4.TabIndex = 2;
            this.textBoxEx4.Text = "mAGNO";
            // 
            // textBoxEx2
            // 
            this.textBoxEx2.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx2.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx2.Location = new System.Drawing.Point(38, 65);
            this.textBoxEx2.Name = "textBoxEx2";
            this.textBoxEx2.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx2.TabIndex = 1;
            this.textBoxEx2.Text = "MAGNO";
            // 
            // textBoxEx1
            // 
            this.textBoxEx1.BackColorIn = System.Drawing.Color.DarkGray;
            this.textBoxEx1.BackColorOut = System.Drawing.Color.Empty;
            this.textBoxEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEx1.Location = new System.Drawing.Point(38, 39);
            this.textBoxEx1.Name = "textBoxEx1";
            this.textBoxEx1.Size = new System.Drawing.Size(148, 29);
            this.textBoxEx1.TabIndex = 0;
            this.textBoxEx1.Text = "magno";
            // 
            // convTemperaturas1
            // 
            this.convTemperaturas1.Celsius = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.convTemperaturas1.Fahrenheit = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.convTemperaturas1.Kelvin = new decimal(new int[] {
            283,
            0,
            0,
            0});
            // 
            // convTemperaturas2
            // 
            this.convTemperaturas2.Celsius = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.convTemperaturas2.Fahrenheit = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.convTemperaturas2.Kelvin = new decimal(new int[] {
            273,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 370);
            this.Controls.Add(this.turbina1);
            this.Controls.Add(this.textBoxEx5);
            this.Controls.Add(this.textBoxEx6);
            this.Controls.Add(this.textBoxEx7);
            this.Controls.Add(this.textBoxEx8);
            this.Controls.Add(this.textBoxEx3);
            this.Controls.Add(this.textBoxEx4);
            this.Controls.Add(this.textBoxEx2);
            this.Controls.Add(this.textBoxEx1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibComponentes.ConvTemperaturas convTemperaturas1;
        private LibComponentes.ConvTemperaturas convTemperaturas2;
        private LibComponentes.TextBoxEx textBoxEx1;
        private LibComponentes.TextBoxEx textBoxEx2;
        private LibComponentes.TextBoxEx textBoxEx3;
        private LibComponentes.TextBoxEx textBoxEx4;
        private LibComponentes.TextBoxEx textBoxEx5;
        private LibComponentes.TextBoxEx textBoxEx6;
        private LibComponentes.TextBoxEx textBoxEx7;
        private LibComponentes.TextBoxEx textBoxEx8;
        private LibComponentes.Turbina turbina1;
    }
}

