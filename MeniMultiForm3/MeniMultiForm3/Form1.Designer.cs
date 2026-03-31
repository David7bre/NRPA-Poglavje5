namespace MeniMultiForm1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.datotekaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izhodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oknoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dialoškoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.nedialoškoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.okno3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomočToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oprogramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.okno2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.okno3ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.oprogramuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datotekaToolStripMenuItem,
            this.oknoToolStripMenuItem,
            this.pomočToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // datotekaToolStripMenuItem
            // 
            this.datotekaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izhodToolStripMenuItem});
            this.datotekaToolStripMenuItem.Name = "datotekaToolStripMenuItem";
            this.datotekaToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.datotekaToolStripMenuItem.Text = "&Datoteka";
            // 
            // izhodToolStripMenuItem
            // 
            this.izhodToolStripMenuItem.Name = "izhodToolStripMenuItem";
            this.izhodToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.izhodToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.izhodToolStripMenuItem.Text = "&Izhod";
            this.izhodToolStripMenuItem.Click += new System.EventHandler(this.izhodToolStripMenuItem_Click);
            // 
            // oknoToolStripMenuItem
            // 
            this.oknoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dialoškoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.nedialoškoToolStripMenuItem});
            this.oknoToolStripMenuItem.Name = "oknoToolStripMenuItem";
            this.oknoToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oknoToolStripMenuItem.Text = "&Okno";
            // 
            // dialoškoToolStripMenuItem
            // 
            this.dialoškoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno2ToolStripMenuItem});
            this.dialoškoToolStripMenuItem.Name = "dialoškoToolStripMenuItem";
            this.dialoškoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.dialoškoToolStripMenuItem.Text = "&Dialoško";
            // 
            // okno2ToolStripMenuItem
            // 
            this.okno2ToolStripMenuItem.Name = "okno2ToolStripMenuItem";
            this.okno2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.okno2ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.okno2ToolStripMenuItem.Text = "Okno&2";
            this.okno2ToolStripMenuItem.Click += new System.EventHandler(this.okno2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(130, 6);
            // 
            // nedialoškoToolStripMenuItem
            // 
            this.nedialoškoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno3ToolStripMenuItem});
            this.nedialoškoToolStripMenuItem.Name = "nedialoškoToolStripMenuItem";
            this.nedialoškoToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.nedialoškoToolStripMenuItem.Text = "&Nedialoško";
            // 
            // okno3ToolStripMenuItem
            // 
            this.okno3ToolStripMenuItem.Name = "okno3ToolStripMenuItem";
            this.okno3ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.okno3ToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.okno3ToolStripMenuItem.Text = "Okno&3";
            this.okno3ToolStripMenuItem.Click += new System.EventHandler(this.okno3ToolStripMenuItem_Click);
            // 
            // pomočToolStripMenuItem
            // 
            this.pomočToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oprogramuToolStripMenuItem});
            this.pomočToolStripMenuItem.Name = "pomočToolStripMenuItem";
            this.pomočToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomočToolStripMenuItem.Text = "&Pomoč";
            // 
            // oprogramuToolStripMenuItem
            // 
            this.oprogramuToolStripMenuItem.Name = "oprogramuToolStripMenuItem";
            this.oprogramuToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.oprogramuToolStripMenuItem.Text = "O &programu";
            this.oprogramuToolStripMenuItem.Click += new System.EventHandler(this.oprogramuToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.okno2ToolStripMenuItem1,
            this.okno3ToolStripMenuItem1,
            this.oprogramuToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(140, 70);
            // 
            // okno2ToolStripMenuItem1
            // 
            this.okno2ToolStripMenuItem1.Name = "okno2ToolStripMenuItem1";
            this.okno2ToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.okno2ToolStripMenuItem1.Text = "Okno&2";
            this.okno2ToolStripMenuItem1.Click += new System.EventHandler(this.OpenForm);
            // 
            // okno3ToolStripMenuItem1
            // 
            this.okno3ToolStripMenuItem1.Name = "okno3ToolStripMenuItem1";
            this.okno3ToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.okno3ToolStripMenuItem1.Text = "Okno&3 ";
            this.okno3ToolStripMenuItem1.Click += new System.EventHandler(this.OpenForm);
            // 
            // oprogramuToolStripMenuItem1
            // 
            this.oprogramuToolStripMenuItem1.Name = "oprogramuToolStripMenuItem1";
            this.oprogramuToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.oprogramuToolStripMenuItem1.Text = "O &programu";
            this.oprogramuToolStripMenuItem1.Click += new System.EventHandler(this.OpenForm);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Program z več okni – glavno okno";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem datotekaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izhodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oknoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dialoškoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nedialoškoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem okno2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem okno3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomočToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oprogramuToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem okno2ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem okno3ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem oprogramuToolStripMenuItem1;
    }
}

