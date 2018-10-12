namespace Paint
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
            this.btnBandeira = new System.Windows.Forms.Button();
            this.btnPoligono = new System.Windows.Forms.Button();
            this.btnLinhasDiag = new System.Windows.Forms.Button();
            this.btnLinhas1 = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFundo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLinha = new System.Windows.Forms.Label();
            this.dlgCor = new System.Windows.Forms.ColorDialog();
            this.btnRetangulo = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBandeira
            // 
            this.btnBandeira.Location = new System.Drawing.Point(21, 213);
            this.btnBandeira.Name = "btnBandeira";
            this.btnBandeira.Size = new System.Drawing.Size(218, 31);
            this.btnBandeira.TabIndex = 17;
            this.btnBandeira.Tag = "7";
            this.btnBandeira.Text = "Bandeira";
            this.btnBandeira.UseVisualStyleBackColor = true;
            this.btnBandeira.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPoligono
            // 
            this.btnPoligono.Location = new System.Drawing.Point(21, 147);
            this.btnPoligono.Name = "btnPoligono";
            this.btnPoligono.Size = new System.Drawing.Size(218, 31);
            this.btnPoligono.TabIndex = 16;
            this.btnPoligono.Tag = "5";
            this.btnPoligono.Text = "Polígono";
            this.btnPoligono.UseVisualStyleBackColor = true;
            this.btnPoligono.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLinhasDiag
            // 
            this.btnLinhasDiag.Location = new System.Drawing.Point(21, 114);
            this.btnLinhasDiag.Name = "btnLinhasDiag";
            this.btnLinhasDiag.Size = new System.Drawing.Size(218, 31);
            this.btnLinhasDiag.TabIndex = 15;
            this.btnLinhasDiag.Tag = "4";
            this.btnLinhasDiag.Text = "Linhas Diagonais";
            this.btnLinhasDiag.UseVisualStyleBackColor = true;
            this.btnLinhasDiag.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLinhas1
            // 
            this.btnLinhas1.Location = new System.Drawing.Point(21, 81);
            this.btnLinhas1.Name = "btnLinhas1";
            this.btnLinhas1.Size = new System.Drawing.Size(218, 31);
            this.btnLinhas1.TabIndex = 14;
            this.btnLinhas1.Tag = "3";
            this.btnLinhas1.Text = "Linhas Vertical e Horizontal";
            this.btnLinhas1.UseVisualStyleBackColor = true;
            this.btnLinhas1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.Location = new System.Drawing.Point(21, 48);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(218, 31);
            this.btnElipse.TabIndex = 13;
            this.btnElipse.Tag = "2";
            this.btnElipse.Text = "Elipse";
            this.btnElipse.UseVisualStyleBackColor = true;
            this.btnElipse.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblFundo);
            this.panel2.Location = new System.Drawing.Point(350, 255);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 29);
            this.panel2.TabIndex = 12;
            // 
            // lblFundo
            // 
            this.lblFundo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFundo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundo.Location = new System.Drawing.Point(0, 0);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(106, 27);
            this.lblFundo.TabIndex = 0;
            this.lblFundo.Text = "Cor do Fundo";
            this.lblFundo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFundo.Click += new System.EventHandler(this.lblFundo_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblLinha);
            this.panel1.Location = new System.Drawing.Point(115, 256);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(108, 29);
            this.panel1.TabIndex = 11;
            // 
            // lblLinha
            // 
            this.lblLinha.BackColor = System.Drawing.Color.Blue;
            this.lblLinha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinha.Location = new System.Drawing.Point(0, 0);
            this.lblLinha.Name = "lblLinha";
            this.lblLinha.Size = new System.Drawing.Size(106, 27);
            this.lblLinha.TabIndex = 0;
            this.lblLinha.Text = "Cor da Linha";
            this.lblLinha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLinha.Click += new System.EventHandler(this.lblLinha_Click);
            // 
            // btnRetangulo
            // 
            this.btnRetangulo.Location = new System.Drawing.Point(21, 15);
            this.btnRetangulo.Name = "btnRetangulo";
            this.btnRetangulo.Size = new System.Drawing.Size(218, 31);
            this.btnRetangulo.TabIndex = 10;
            this.btnRetangulo.Tag = "1";
            this.btnRetangulo.Text = "Retângulo";
            this.btnRetangulo.UseVisualStyleBackColor = true;
            this.btnRetangulo.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(260, 39);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(322, 205);
            this.pnl.TabIndex = 9;
            this.pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 31);
            this.button1.TabIndex = 18;
            this.button1.Tag = "6";
            this.button1.Text = "Bitmap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(503, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 37);
            this.button2.TabIndex = 19;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBandeira);
            this.Controls.Add(this.btnPoligono);
            this.Controls.Add(this.btnLinhasDiag);
            this.Controls.Add(this.btnLinhas1);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRetangulo);
            this.Controls.Add(this.pnl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desenhos";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBandeira;
        private System.Windows.Forms.Button btnPoligono;
        private System.Windows.Forms.Button btnLinhasDiag;
        private System.Windows.Forms.Button btnLinhas1;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLinha;
        private System.Windows.Forms.ColorDialog dlgCor;
        private System.Windows.Forms.Button btnRetangulo;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PrintDialog printDialog1;
    }
}

