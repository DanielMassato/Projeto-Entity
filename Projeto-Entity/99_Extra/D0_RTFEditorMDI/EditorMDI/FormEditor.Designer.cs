namespace EditorMDI
{
    partial class FormEditor
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
            this.rtfEditor = new LibComponentes.RichTextBoxPrintCtrl();
            this.SuspendLayout();
            // 
            // rtfEditor
            // 
            this.rtfEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtfEditor.Location = new System.Drawing.Point(0, 0);
            this.rtfEditor.Name = "rtfEditor";
            this.rtfEditor.Size = new System.Drawing.Size(756, 413);
            this.rtfEditor.TabIndex = 8;
            this.rtfEditor.Text = "";
            this.rtfEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtfEditor_KeyDown);
            this.rtfEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtfEditor_KeyPress);
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 413);
            this.Controls.Add(this.rtfEditor);
            this.Name = "FormEditor";
            this.Text = "FormEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEditor_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditor_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        public LibComponentes.RichTextBoxPrintCtrl rtfEditor;

    }
}