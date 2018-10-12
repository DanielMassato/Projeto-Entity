namespace ExChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpSeries = new System.Windows.Forms.TabPage();
            this.tbTipos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnGeraGraf1 = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGeraGraficos2 = new System.Windows.Forms.Button();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tpSeries.SuspendLayout();
            this.tbTipos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpSeries);
            this.tabControl1.Controls.Add(this.tbTipos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 419);
            this.tabControl1.TabIndex = 0;
            // 
            // tpSeries
            // 
            this.tpSeries.Controls.Add(this.chart1);
            this.tpSeries.Controls.Add(this.panel1);
            this.tpSeries.Location = new System.Drawing.Point(4, 22);
            this.tpSeries.Name = "tpSeries";
            this.tpSeries.Padding = new System.Windows.Forms.Padding(3);
            this.tpSeries.Size = new System.Drawing.Size(777, 393);
            this.tpSeries.TabIndex = 0;
            this.tpSeries.Text = "Séries";
            this.tpSeries.UseVisualStyleBackColor = true;
            // 
            // tbTipos
            // 
            this.tbTipos.Controls.Add(this.chart2);
            this.tbTipos.Controls.Add(this.panel2);
            this.tbTipos.Location = new System.Drawing.Point(4, 22);
            this.tbTipos.Name = "tbTipos";
            this.tbTipos.Padding = new System.Windows.Forms.Padding(3);
            this.tbTipos.Size = new System.Drawing.Size(777, 393);
            this.tbTipos.TabIndex = 1;
            this.tbTipos.Text = "Tipos de Gráfico";
            this.tbTipos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGeraGraf1);
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 387);
            this.panel1.TabIndex = 0;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.PowderBlue;
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.PowderBlue;
            legend1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(325, 3);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(449, 387);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(322, 353);
            this.dgv.TabIndex = 0;
            // 
            // btnGeraGraf1
            // 
            this.btnGeraGraf1.Location = new System.Drawing.Point(99, 359);
            this.btnGeraGraf1.Name = "btnGeraGraf1";
            this.btnGeraGraf1.Size = new System.Drawing.Size(123, 23);
            this.btnGeraGraf1.TabIndex = 1;
            this.btnGeraGraf1.Text = "Gera Gráficos";
            this.btnGeraGraf1.UseVisualStyleBackColor = true;
            this.btnGeraGraf1.Click += new System.EventHandler(this.btnGeraGraf1_Click);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.PowderBlue;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.BackColor = System.Drawing.Color.PowderBlue;
            legend2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(325, 3);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(449, 387);
            this.chart2.TabIndex = 3;
            this.chart2.Text = "chart2";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTipo);
            this.panel2.Controls.Add(this.btnGeraGraficos2);
            this.panel2.Controls.Add(this.dgv2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(322, 387);
            this.panel2.TabIndex = 2;
            // 
            // btnGeraGraficos2
            // 
            this.btnGeraGraficos2.Location = new System.Drawing.Point(99, 359);
            this.btnGeraGraficos2.Name = "btnGeraGraficos2";
            this.btnGeraGraficos2.Size = new System.Drawing.Size(123, 23);
            this.btnGeraGraficos2.TabIndex = 1;
            this.btnGeraGraficos2.Text = "Gera Gráficos";
            this.btnGeraGraficos2.UseVisualStyleBackColor = true;
            this.btnGeraGraficos2.Click += new System.EventHandler(this.btnGeraGraficos2_Click);
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv2.Location = new System.Drawing.Point(0, 0);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(322, 299);
            this.dgv2.TabIndex = 0;
            // 
            // cmbTipo
            // 
            this.cmbTipo.AccessibleDescription = "";
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Point",
            "FastPoint",
            "Bubble",
            "Line",
            "Spline",
            "StepLine",
            "FastLine",
            "Bar",
            "StackedBar",
            "StackedBar100",
            "Column",
            "StackedColumn",
            "StackedColumn100",
            "Area",
            "SplineArea",
            "StackedArea",
            "StackedArea100",
            "Pie",
            "Doughnut",
            "Stock",
            "Candlestick",
            "Range",
            "SplineRange",
            "RangeBar",
            "RangeColumn",
            "Radar",
            "Polar",
            "ErrorBar",
            "BoxPlot",
            "Renko",
            "ThreeLineBreak",
            "Kagi",
            "PointAndFigure",
            "Funnel",
            "Pyramid"});
            this.cmbTipo.Location = new System.Drawing.Point(77, 317);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(167, 21);
            this.cmbTipo.TabIndex = 2;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Exemplos de Gráficos (Chart Control)";
            this.tabControl1.ResumeLayout(false);
            this.tpSeries.ResumeLayout(false);
            this.tbTipos.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpSeries;
        private System.Windows.Forms.TabPage tbTipos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnGeraGraf1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnGeraGraficos2;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

