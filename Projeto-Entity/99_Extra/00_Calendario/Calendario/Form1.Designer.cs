namespace Calendario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.adicionaCompromissoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaCompromissosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDU2 = new System.Windows.Forms.CheckBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbManterAFrente = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDt1 = new System.Windows.Forms.Label();
            this.ckbDiasUteis = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSomaDias = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxfDias = new Curso.Controles.TextBoxFloat();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.monthCalendar3 = new System.Windows.Forms.MonthCalendar();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.ContextMenuStrip = this.contextMenuStrip1;
            this.monthCalendar1.Location = new System.Drawing.Point(7, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TodayDate = new System.DateTime(2008, 7, 28, 0, 0, 0, 0);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionaCompromissoToolStripMenuItem,
            this.consultaCompromissosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(205, 48);
            // 
            // adicionaCompromissoToolStripMenuItem
            // 
            this.adicionaCompromissoToolStripMenuItem.Name = "adicionaCompromissoToolStripMenuItem";
            this.adicionaCompromissoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.adicionaCompromissoToolStripMenuItem.Text = "Adiciona Compromisso";
            this.adicionaCompromissoToolStripMenuItem.Click += new System.EventHandler(this.adicionaCompromissoToolStripMenuItem_Click);
            // 
            // consultaCompromissosToolStripMenuItem
            // 
            this.consultaCompromissosToolStripMenuItem.Name = "consultaCompromissosToolStripMenuItem";
            this.consultaCompromissosToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.consultaCompromissosToolStripMenuItem.Text = "Consulta Compromissos";
            this.consultaCompromissosToolStripMenuItem.Click += new System.EventHandler(this.consultaCompromissosToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDU2);
            this.groupBox1.Controls.Add(this.lblDias);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.ckbManterAFrente);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblDt1);
            this.groupBox1.Controls.Add(this.ckbDiasUteis);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnSomaDias);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbxfDias);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(692, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // ckbDU2
            // 
            this.ckbDU2.AutoSize = true;
            this.ckbDU2.Location = new System.Drawing.Point(542, 36);
            this.ckbDU2.Name = "ckbDU2";
            this.ckbDU2.Size = new System.Drawing.Size(74, 18);
            this.ckbDU2.TabIndex = 14;
            this.ckbDU2.Text = "Dias Úteis";
            this.toolTip1.SetToolTip(this.ckbDU2, "Não considera sábados e domingos nos cálculos");
            this.ckbDU2.UseVisualStyleBackColor = true;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(505, 38);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(13, 14);
            this.lblDias.TabIndex = 12;
            this.lblDias.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dias:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(569, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "-";
            this.toolTip1.SetToolTip(this.button3, "Calcula a diferença em dias entre a data do calendário e a data à esquerda");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(469, 13);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(84, 20);
            this.dtp.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(457, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(5, 47);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // ckbManterAFrente
            // 
            this.ckbManterAFrente.AutoSize = true;
            this.ckbManterAFrente.Location = new System.Drawing.Point(286, 13);
            this.ckbManterAFrente.Name = "ckbManterAFrente";
            this.ckbManterAFrente.Size = new System.Drawing.Size(102, 18);
            this.ckbManterAFrente.TabIndex = 7;
            this.ckbManterAFrente.Text = "Manter à Frente";
            this.toolTip1.SetToolTip(this.ckbManterAFrente, "Mantem esta janela sempre à frente");
            this.ckbManterAFrente.UseVisualStyleBackColor = true;
            this.ckbManterAFrente.Click += new System.EventHandler(this.ckbManterAFrente_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(235, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(5, 47);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // lblDt1
            // 
            this.lblDt1.AutoSize = true;
            this.lblDt1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt1.Location = new System.Drawing.Point(89, 35);
            this.lblDt1.Name = "lblDt1";
            this.lblDt1.Size = new System.Drawing.Size(61, 14);
            this.lblDt1.TabIndex = 5;
            this.lblDt1.Text = "__/__/____";
            // 
            // ckbDiasUteis
            // 
            this.ckbDiasUteis.AutoSize = true;
            this.ckbDiasUteis.Location = new System.Drawing.Point(89, 12);
            this.ckbDiasUteis.Name = "ckbDiasUteis";
            this.ckbDiasUteis.Size = new System.Drawing.Size(74, 18);
            this.ckbDiasUteis.TabIndex = 4;
            this.ckbDiasUteis.Text = "Dias Úteis";
            this.toolTip1.SetToolTip(this.ckbDiasUteis, "Não considera sábados e domingos nos cálculos");
            this.ckbDiasUteis.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "-";
            this.toolTip1.SetToolTip(this.button2, "Subtrai da data do calendário a quantidade de dias à esquerda");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSomaDias
            // 
            this.btnSomaDias.Location = new System.Drawing.Point(53, 10);
            this.btnSomaDias.Name = "btnSomaDias";
            this.btnSomaDias.Size = new System.Drawing.Size(27, 23);
            this.btnSomaDias.TabIndex = 2;
            this.btnSomaDias.Text = "+";
            this.toolTip1.SetToolTip(this.btnSomaDias, "Soma na data do calendário a quantidade de dias à esquerda");
            this.btnSomaDias.UseVisualStyleBackColor = true;
            this.btnSomaDias.Click += new System.EventHandler(this.btnSomaDias_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dias:";
            // 
            // tbxfDias
            // 
            this.tbxfDias.DecPlaces = ((byte)(0));
            this.tbxfDias.DisplayFormat = Curso.Controles.TextBoxFloat.TextBoxFloatFormat.None;
            this.tbxfDias.DisplayFormatCustom = null;
            this.tbxfDias.Location = new System.Drawing.Point(12, 27);
            this.tbxfDias.MaxValue = 0D;
            this.tbxfDias.MinValue = 0D;
            this.tbxfDias.Name = "tbxfDias";
            this.tbxfDias.Size = new System.Drawing.Size(33, 20);
            this.tbxfDias.TabIndex = 0;
            this.tbxfDias.Text = "0";
            this.tbxfDias.Value = 0D;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.ContextMenuStrip = this.contextMenuStrip1;
            this.monthCalendar2.Location = new System.Drawing.Point(235, 8);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 3;
            this.monthCalendar2.Tag = "1";
            // 
            // monthCalendar3
            // 
            this.monthCalendar3.ContextMenuStrip = this.contextMenuStrip1;
            this.monthCalendar3.Location = new System.Drawing.Point(465, 8);
            this.monthCalendar3.Name = "monthCalendar3";
            this.monthCalendar3.TabIndex = 4;
            this.monthCalendar3.Tag = "2";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.FileName = "mailto:magnocsharp@uol.com.br";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(0, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(517, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Utilize Click direito sobre o calendário para Incluir / Consultar compromissos ag" +
    "endados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 237);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar3);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calendario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Curso.Controles.TextBoxFloat tbxfDias;
        private System.Windows.Forms.Label lblDt1;
        private System.Windows.Forms.CheckBox ckbDiasUteis;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSomaDias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbManterAFrente;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.MonthCalendar monthCalendar3;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.CheckBox ckbDU2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adicionaCompromissoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaCompromissosToolStripMenuItem;
        private System.Windows.Forms.Label label3;
    }
}

