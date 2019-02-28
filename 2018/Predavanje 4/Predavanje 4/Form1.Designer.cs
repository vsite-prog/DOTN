namespace Predavanje_4
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osnovniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosAutaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osnovniToolStripMenuItem,
            this.ostaloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osnovniToolStripMenuItem
            // 
            this.osnovniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosAutaToolStripMenuItem});
            this.osnovniToolStripMenuItem.Name = "osnovniToolStripMenuItem";
            this.osnovniToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.osnovniToolStripMenuItem.Text = "Osnovni";
            // 
            // unosAutaToolStripMenuItem
            // 
            this.unosAutaToolStripMenuItem.Name = "unosAutaToolStripMenuItem";
            this.unosAutaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.unosAutaToolStripMenuItem.Text = "Unos auta";
            this.unosAutaToolStripMenuItem.Click += new System.EventHandler(this.unosAutaToolStripMenuItem_Click);
            // 
            // ostaloToolStripMenuItem
            // 
            this.ostaloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.ostaloToolStripMenuItem.Name = "ostaloToolStripMenuItem";
            this.ostaloToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ostaloToolStripMenuItem.Text = "Ostalo";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem osnovniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosAutaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

