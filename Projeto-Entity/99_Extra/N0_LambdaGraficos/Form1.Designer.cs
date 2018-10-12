namespace Lambda1
{
    partial class Lambda
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbx = new System.Windows.Forms.ListBox();
            this.btnQuadrado = new System.Windows.Forms.Button();
            this.btnSeno = new System.Windows.Forms.Button();
            this.rbDivide = new System.Windows.Forms.RadioButton();
            this.rbMultiplica = new System.Windows.Forms.RadioButton();
            this.btnDivMult1 = new System.Windows.Forms.Button();
            this.btnDivMult2 = new System.Windows.Forms.Button();
            this.btn1X_1 = new System.Windows.Forms.Button();
            this.btn1X2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCoseno = new System.Windows.Forms.Button();
            this.btnParabola = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbx
            // 
            this.lbx.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbx.FormattingEnabled = true;
            this.lbx.Location = new System.Drawing.Point(709, 0);
            this.lbx.Name = "lbx";
            this.lbx.Size = new System.Drawing.Size(166, 382);
            this.lbx.TabIndex = 0;
            // 
            // btnQuadrado
            // 
            this.btnQuadrado.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuadrado.Location = new System.Drawing.Point(58, 123);
            this.btnQuadrado.Name = "btnQuadrado";
            this.btnQuadrado.Size = new System.Drawing.Size(148, 25);
            this.btnQuadrado.TabIndex = 1;
            this.btnQuadrado.Text = "f(x) = x*x";
            this.btnQuadrado.UseVisualStyleBackColor = true;
            this.btnQuadrado.Click += new System.EventHandler(this.btnQuadrado_Click);
            // 
            // btnSeno
            // 
            this.btnSeno.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeno.Location = new System.Drawing.Point(56, 156);
            this.btnSeno.Name = "btnSeno";
            this.btnSeno.Size = new System.Drawing.Size(148, 25);
            this.btnSeno.TabIndex = 2;
            this.btnSeno.Text = "f(x) = sin( x )";
            this.btnSeno.UseVisualStyleBackColor = true;
            this.btnSeno.Click += new System.EventHandler(this.btnSeno_Click);
            // 
            // rbDivide
            // 
            this.rbDivide.AutoSize = true;
            this.rbDivide.Checked = true;
            this.rbDivide.Location = new System.Drawing.Point(60, 19);
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
            this.rbMultiplica.Location = new System.Drawing.Point(133, 19);
            this.rbMultiplica.Name = "rbMultiplica";
            this.rbMultiplica.Size = new System.Drawing.Size(69, 17);
            this.rbMultiplica.TabIndex = 4;
            this.rbMultiplica.Text = "Multiplica";
            this.rbMultiplica.UseVisualStyleBackColor = true;
            // 
            // btnDivMult1
            // 
            this.btnDivMult1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivMult1.Location = new System.Drawing.Point(44, 39);
            this.btnDivMult1.Name = "btnDivMult1";
            this.btnDivMult1.Size = new System.Drawing.Size(159, 25);
            this.btnDivMult1.TabIndex = 5;
            this.btnDivMult1.Text = "Divide ou Multiplica";
            this.btnDivMult1.UseVisualStyleBackColor = true;
            this.btnDivMult1.Click += new System.EventHandler(this.btnMultDiv1_Click);
            // 
            // btnDivMult2
            // 
            this.btnDivMult2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivMult2.Location = new System.Drawing.Point(45, 77);
            this.btnDivMult2.Name = "btnDivMult2";
            this.btnDivMult2.Size = new System.Drawing.Size(159, 25);
            this.btnDivMult2.TabIndex = 6;
            this.btnDivMult2.Text = "Divide ou Multiplica";
            this.btnDivMult2.UseVisualStyleBackColor = true;
            this.btnDivMult2.Click += new System.EventHandler(this.btnMultDiv2_Click);
            // 
            // btn1X_1
            // 
            this.btn1X_1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1X_1.Location = new System.Drawing.Point(55, 268);
            this.btn1X_1.Name = "btn1X_1";
            this.btn1X_1.Size = new System.Drawing.Size(148, 25);
            this.btn1X_1.TabIndex = 7;
            this.btn1X_1.Text = "f(x) = 1/x";
            this.btn1X_1.UseVisualStyleBackColor = true;
            this.btn1X_1.Click += new System.EventHandler(this.btn1X_1_Click);
            // 
            // btn1X2
            // 
            this.btn1X2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1X2.Location = new System.Drawing.Point(55, 317);
            this.btn1X2.Name = "btn1X2";
            this.btn1X2.Size = new System.Drawing.Size(148, 25);
            this.btn1X2.TabIndex = 8;
            this.btn1X2.Text = "f(x) = 1/x";
            this.btn1X2.UseVisualStyleBackColor = true;
            this.btn1X2.Click += new System.EventHandler(this.btn1X_2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Decrescente de 100 até 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Crescente de 1 até 100";
            // 
            // btnCoseno
            // 
            this.btnCoseno.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCoseno.Location = new System.Drawing.Point(55, 189);
            this.btnCoseno.Name = "btnCoseno";
            this.btnCoseno.Size = new System.Drawing.Size(148, 25);
            this.btnCoseno.TabIndex = 12;
            this.btnCoseno.Text = "f(x) = cos( x )";
            this.btnCoseno.UseVisualStyleBackColor = true;
            this.btnCoseno.Click += new System.EventHandler(this.btnCoseno_Click);
            // 
            // btnParabola
            // 
            this.btnParabola.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParabola.Location = new System.Drawing.Point(55, 224);
            this.btnParabola.Name = "btnParabola";
            this.btnParabola.Size = new System.Drawing.Size(148, 25);
            this.btnParabola.TabIndex = 13;
            this.btnParabola.Text = "f(x) = x*x + x + 1";
            this.btnParabola.UseVisualStyleBackColor = true;
            this.btnParabola.Click += new System.EventHandler(this.btnParabola_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDivMult1);
            this.panel1.Controls.Add(this.btnParabola);
            this.panel1.Controls.Add(this.btnQuadrado);
            this.panel1.Controls.Add(this.btnCoseno);
            this.panel1.Controls.Add(this.btnSeno);
            this.panel1.Controls.Add(this.rbDivide);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.rbMultiplica);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDivMult2);
            this.panel1.Controls.Add(this.btn1X2);
            this.panel1.Controls.Add(this.btn1X_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 382);
            this.panel1.TabIndex = 14;
            // 
            // chart1
            // 
            this.chart1.BorderSkin.BorderWidth = 2;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Funções";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(222, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(487, 382);
            this.chart1.TabIndex = 15;
            this.chart1.Text = "chart1";
            // 
            // Lambda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 382);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbx);
            this.Name = "Lambda";
            this.Text = "Lambda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbx;
        private System.Windows.Forms.Button btnQuadrado;
        private System.Windows.Forms.Button btnSeno;
        private System.Windows.Forms.RadioButton rbDivide;
        private System.Windows.Forms.RadioButton rbMultiplica;
        private System.Windows.Forms.Button btnDivMult1;
        private System.Windows.Forms.Button btnDivMult2;
        private System.Windows.Forms.Button btn1X_1;
        private System.Windows.Forms.Button btn1X2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCoseno;
        private System.Windows.Forms.Button btnParabola;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

