namespace TreeViewRecursaoBD
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.inserirFilhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inserirIrmãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluiItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.abrirTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 44);
            this.panel1.TabIndex = 0;
            // 
            // tree
            // 
            this.tree.ContextMenuStrip = this.contextMenuStrip1;
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.ImageIndex = 0;
            this.tree.ImageList = this.imageList1;
            this.tree.LabelEdit = true;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(377, 271);
            this.tree.TabIndex = 1;
            this.tree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tree_AfterLabelEdit);
            this.tree.AfterCollapse += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterCollapse);
            this.tree.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect);
            this.tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tree_AfterSelect_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inserirFilhoToolStripMenuItem,
            this.inserirIrmãoToolStripMenuItem,
            this.excluiItemToolStripMenuItem,
            this.toolStripMenuItem1,
            this.abrirTodosToolStripMenuItem,
            this.fecharTodosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 142);
            // 
            // inserirFilhoToolStripMenuItem
            // 
            this.inserirFilhoToolStripMenuItem.Name = "inserirFilhoToolStripMenuItem";
            this.inserirFilhoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserirFilhoToolStripMenuItem.Tag = "0";
            this.inserirFilhoToolStripMenuItem.Text = "Inserir Filho";
            this.inserirFilhoToolStripMenuItem.Click += new System.EventHandler(this.inserirIrmãoToolStripMenuItem_Click);
            // 
            // inserirIrmãoToolStripMenuItem
            // 
            this.inserirIrmãoToolStripMenuItem.Name = "inserirIrmãoToolStripMenuItem";
            this.inserirIrmãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inserirIrmãoToolStripMenuItem.Tag = "1";
            this.inserirIrmãoToolStripMenuItem.Text = "Inserir Irmão";
            this.inserirIrmãoToolStripMenuItem.Click += new System.EventHandler(this.inserirIrmãoToolStripMenuItem_Click);
            // 
            // excluiItemToolStripMenuItem
            // 
            this.excluiItemToolStripMenuItem.Name = "excluiItemToolStripMenuItem";
            this.excluiItemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.excluiItemToolStripMenuItem.Text = "Exclui Item";
            this.excluiItemToolStripMenuItem.Click += new System.EventHandler(this.excluiItemToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Silver;
            this.imageList1.Images.SetKeyName(0, "OPEN.BMP");
            this.imageList1.Images.SetKeyName(1, "CLOSE.BMP");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propr. Name do nó Selecionado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // abrirTodosToolStripMenuItem
            // 
            this.abrirTodosToolStripMenuItem.Name = "abrirTodosToolStripMenuItem";
            this.abrirTodosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirTodosToolStripMenuItem.Text = "Abrir Todos";
            this.abrirTodosToolStripMenuItem.Click += new System.EventHandler(this.abrirTodosToolStripMenuItem_Click);
            // 
            // fecharTodosToolStripMenuItem
            // 
            this.fecharTodosToolStripMenuItem.Name = "fecharTodosToolStripMenuItem";
            this.fecharTodosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fecharTodosToolStripMenuItem.Text = "Fechar Todos";
            this.fecharTodosToolStripMenuItem.Click += new System.EventHandler(this.fecharTodosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 315);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inserirFilhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inserirIrmãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluiItemToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharTodosToolStripMenuItem;
    }
}

