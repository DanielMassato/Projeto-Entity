namespace DualListBox
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
            this.btnVemTudo = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnVem = new System.Windows.Forms.Button();
            this.lbx1 = new System.Windows.Forms.ListBox();
            this.btnVaiTudo = new System.Windows.Forms.Button();
            this.btnVai = new System.Windows.Forms.Button();
            this.lbx2 = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnVemTudo
            // 
            this.btnVemTudo.ImageIndex = 3;
            this.btnVemTudo.ImageList = this.imageList1;
            this.btnVemTudo.Location = new System.Drawing.Point(141, 158);
            this.btnVemTudo.Name = "btnVemTudo";
            this.btnVemTudo.Size = new System.Drawing.Size(28, 29);
            this.btnVemTudo.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnVemTudo, "Move todos os itens para o ListBox da esquerda");
            this.btnVemTudo.UseVisualStyleBackColor = true;
            this.btnVemTudo.Click += new System.EventHandler(this.btnVemTudo_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "REDO2.BMP");
            this.imageList1.Images.SetKeyName(1, "UNDO.BMP");
            this.imageList1.Images.SetKeyName(2, "REDO_all.BMP");
            this.imageList1.Images.SetKeyName(3, "UNDO_all.BMP");
            // 
            // btnVem
            // 
            this.btnVem.ImageIndex = 1;
            this.btnVem.ImageList = this.imageList1;
            this.btnVem.Location = new System.Drawing.Point(140, 63);
            this.btnVem.Name = "btnVem";
            this.btnVem.Size = new System.Drawing.Size(28, 29);
            this.btnVem.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnVem, "Move os itens selecionados para o ListBox da Esquerda");
            this.btnVem.UseVisualStyleBackColor = true;
            this.btnVem.Click += new System.EventHandler(this.btnVem_Click);
            // 
            // lbx1
            // 
            this.lbx1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbx1.FormattingEnabled = true;
            this.lbx1.Items.AddRange(new object[] {
            "ASP.NET",
            "C#",
            "C++",
            "DELPHI 7",
            "FLASH",
            "HTML",
            "JAVA",
            "PHP",
            "VB.NET"});
            this.lbx1.Location = new System.Drawing.Point(0, 0);
            this.lbx1.Name = "lbx1";
            this.lbx1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx1.Size = new System.Drawing.Size(126, 207);
            this.lbx1.Sorted = true;
            this.lbx1.TabIndex = 6;
            // 
            // btnVaiTudo
            // 
            this.btnVaiTudo.ImageIndex = 2;
            this.btnVaiTudo.ImageList = this.imageList1;
            this.btnVaiTudo.Location = new System.Drawing.Point(141, 123);
            this.btnVaiTudo.Name = "btnVaiTudo";
            this.btnVaiTudo.Size = new System.Drawing.Size(28, 29);
            this.btnVaiTudo.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnVaiTudo, "Move todos os itens para o ListBox da direita");
            this.btnVaiTudo.UseVisualStyleBackColor = true;
            this.btnVaiTudo.Click += new System.EventHandler(this.btnVaiTudo_Click);
            // 
            // btnVai
            // 
            this.btnVai.ImageIndex = 0;
            this.btnVai.ImageList = this.imageList1;
            this.btnVai.Location = new System.Drawing.Point(140, 28);
            this.btnVai.Name = "btnVai";
            this.btnVai.Size = new System.Drawing.Size(28, 29);
            this.btnVai.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnVai, "Move os itens selecionados para o ListBox da direita");
            this.btnVai.UseVisualStyleBackColor = true;
            this.btnVai.Click += new System.EventHandler(this.btnVai_Click);
            // 
            // lbx2
            // 
            this.lbx2.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbx2.FormattingEnabled = true;
            this.lbx2.Location = new System.Drawing.Point(178, 0);
            this.lbx2.Name = "lbx2";
            this.lbx2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbx2.Size = new System.Drawing.Size(130, 207);
            this.lbx2.Sorted = true;
            this.lbx2.TabIndex = 7;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 207);
            this.Controls.Add(this.btnVemTudo);
            this.Controls.Add(this.btnVem);
            this.Controls.Add(this.lbx1);
            this.Controls.Add(this.btnVaiTudo);
            this.Controls.Add(this.btnVai);
            this.Controls.Add(this.lbx2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dual ListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVemTudo;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnVem;
        private System.Windows.Forms.ListBox lbx1;
        private System.Windows.Forms.Button btnVaiTudo;
        private System.Windows.Forms.Button btnVai;
        private System.Windows.Forms.ListBox lbx2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

