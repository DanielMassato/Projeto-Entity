namespace AlcoolGasolina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updPrecoGasolina = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.updPrecoAlcool = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.updConsumoGasolina = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.updConsumoAlcool = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.updLitrosTanque = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblQtdGasol = new System.Windows.Forms.Label();
            this.lblQtdAlcool = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tkbBalGasol = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lblValorPorKm = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblKmTotal = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.alcoolOuGasolina1 = new AlcoolGasolina.AlcoolOuGasolina();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecoGasolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecoAlcool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updConsumoGasolina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updConsumoAlcool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitrosTanque)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBalGasol)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updPrecoGasolina);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.updPrecoAlcool);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.updConsumoGasolina);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.updConsumoAlcool);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.updLitrosTanque);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(571, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados de Entrada";
            // 
            // updPrecoGasolina
            // 
            this.updPrecoGasolina.DecimalPlaces = 2;
            this.updPrecoGasolina.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.updPrecoGasolina.Location = new System.Drawing.Point(448, 48);
            this.updPrecoGasolina.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updPrecoGasolina.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.updPrecoGasolina.Name = "updPrecoGasolina";
            this.updPrecoGasolina.Size = new System.Drawing.Size(71, 20);
            this.updPrecoGasolina.TabIndex = 11;
            this.updPrecoGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPrecoGasolina.Value = new decimal(new int[] {
            270,
            0,
            0,
            131072});
            this.updPrecoGasolina.ValueChanged += new System.EventHandler(this.updPrecoGasolina_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "R$ Gasol:";
            // 
            // updPrecoAlcool
            // 
            this.updPrecoAlcool.DecimalPlaces = 2;
            this.updPrecoAlcool.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.updPrecoAlcool.Location = new System.Drawing.Point(261, 48);
            this.updPrecoAlcool.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.updPrecoAlcool.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.updPrecoAlcool.Name = "updPrecoAlcool";
            this.updPrecoAlcool.Size = new System.Drawing.Size(71, 20);
            this.updPrecoAlcool.TabIndex = 9;
            this.updPrecoAlcool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updPrecoAlcool.Value = new decimal(new int[] {
            170,
            0,
            0,
            131072});
            this.updPrecoAlcool.ValueChanged += new System.EventHandler(this.updPrecoAlcool_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(199, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "R$ Álcool:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Km/l";
            // 
            // updConsumoGasolina
            // 
            this.updConsumoGasolina.DecimalPlaces = 2;
            this.updConsumoGasolina.Location = new System.Drawing.Point(448, 22);
            this.updConsumoGasolina.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updConsumoGasolina.Name = "updConsumoGasolina";
            this.updConsumoGasolina.Size = new System.Drawing.Size(71, 20);
            this.updConsumoGasolina.TabIndex = 6;
            this.updConsumoGasolina.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updConsumoGasolina.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updConsumoGasolina.ValueChanged += new System.EventHandler(this.updConsumoGasolina_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cons. Gasol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Km/l";
            // 
            // updConsumoAlcool
            // 
            this.updConsumoAlcool.DecimalPlaces = 2;
            this.updConsumoAlcool.Location = new System.Drawing.Point(261, 22);
            this.updConsumoAlcool.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updConsumoAlcool.Name = "updConsumoAlcool";
            this.updConsumoAlcool.Size = new System.Drawing.Size(71, 20);
            this.updConsumoAlcool.TabIndex = 3;
            this.updConsumoAlcool.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updConsumoAlcool.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.updConsumoAlcool.ValueChanged += new System.EventHandler(this.updConsumoAlcool_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cons. Álcool:";
            // 
            // updLitrosTanque
            // 
            this.updLitrosTanque.Location = new System.Drawing.Point(94, 22);
            this.updLitrosTanque.Name = "updLitrosTanque";
            this.updLitrosTanque.Size = new System.Drawing.Size(71, 20);
            this.updLitrosTanque.TabIndex = 1;
            this.updLitrosTanque.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.updLitrosTanque.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.updLitrosTanque.ValueChanged += new System.EventHandler(this.updLitrosTanque_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Litros Tanque:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblQtdGasol);
            this.groupBox2.Controls.Add(this.lblQtdAlcool);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tkbBalGasol);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(571, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mistura Álcool Gasolina";
            // 
            // lblQtdGasol
            // 
            this.lblQtdGasol.AutoSize = true;
            this.lblQtdGasol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdGasol.Location = new System.Drawing.Point(462, 40);
            this.lblQtdGasol.Name = "lblQtdGasol";
            this.lblQtdGasol.Size = new System.Drawing.Size(19, 20);
            this.lblQtdGasol.TabIndex = 4;
            this.lblQtdGasol.Text = "0";
            // 
            // lblQtdAlcool
            // 
            this.lblQtdAlcool.AutoSize = true;
            this.lblQtdAlcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdAlcool.Location = new System.Drawing.Point(15, 40);
            this.lblQtdAlcool.Name = "lblQtdAlcool";
            this.lblQtdAlcool.Size = new System.Drawing.Size(29, 20);
            this.lblQtdAlcool.TabIndex = 3;
            this.lblQtdAlcool.Text = "40";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(462, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "GASOLINA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "ÁLCOOL";
            // 
            // tkbBalGasol
            // 
            this.tkbBalGasol.AutoSize = false;
            this.tkbBalGasol.Location = new System.Drawing.Point(106, 23);
            this.tkbBalGasol.Maximum = 100;
            this.tkbBalGasol.Name = "tkbBalGasol";
            this.tkbBalGasol.Size = new System.Drawing.Size(342, 27);
            this.tkbBalGasol.TabIndex = 0;
            this.tkbBalGasol.ValueChanged += new System.EventHandler(this.tkbBalGasol_ValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.lblValorPorKm);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.lblValorTotal);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.lblKmTotal);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 155);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(571, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultados";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(437, 93);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(129, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "magno@somainfome.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblValorPorKm
            // 
            this.lblValorPorKm.AutoSize = true;
            this.lblValorPorKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPorKm.Location = new System.Drawing.Point(422, 46);
            this.lblValorPorKm.Name = "lblValorPorKm";
            this.lblValorPorKm.Size = new System.Drawing.Size(51, 25);
            this.lblValorPorKm.TabIndex = 9;
            this.lblValorPorKm.Text = "400";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(314, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "R$ / Km:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(198, 61);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(39, 20);
            this.lblValorTotal.TabIndex = 7;
            this.lblValorTotal.Text = "400";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(91, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Valor Total:";
            // 
            // lblKmTotal
            // 
            this.lblKmTotal.AutoSize = true;
            this.lblKmTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmTotal.Location = new System.Drawing.Point(198, 30);
            this.lblKmTotal.Name = "lblKmTotal";
            this.lblKmTotal.Size = new System.Drawing.Size(39, 20);
            this.lblKmTotal.TabIndex = 5;
            this.lblKmTotal.Text = "400";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Quilometragem Total:";
            // 
            // alcoolOuGasolina1
            // 
            this.alcoolOuGasolina1.BalancoAlcoolGasolina = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.alcoolOuGasolina1.BalancoGasolonaAlcool = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.alcoolOuGasolina1.ConsumoAlcool = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.alcoolOuGasolina1.ConsumoGasolina = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.alcoolOuGasolina1.LitrosTanque = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.alcoolOuGasolina1.PrecoAlcool = new decimal(new int[] {
            185,
            0,
            0,
            131072});
            this.alcoolOuGasolina1.PrecoGasolina = new decimal(new int[] {
            280,
            0,
            0,
            131072});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 266);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Abastecer com Álcool ou Gasolina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecoGasolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updPrecoAlcool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updConsumoGasolina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updConsumoAlcool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updLitrosTanque)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tkbBalGasol)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown updLitrosTanque;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown updPrecoGasolina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown updPrecoAlcool;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown updConsumoGasolina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown updConsumoAlcool;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar tkbBalGasol;
        private System.Windows.Forms.Label lblQtdGasol;
        private System.Windows.Forms.Label lblQtdAlcool;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKmTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblValorPorKm;
        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.LinkLabel linkLabel1;
        private AlcoolOuGasolina alcoolOuGasolina1;
    }
}

