namespace Predavanje_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_unos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osnovniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugaModalnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi tekst:";
            // 
            // tb_unos
            // 
            this.tb_unos.Location = new System.Drawing.Point(112, 43);
            this.tb_unos.Name = "tb_unos";
            this.tb_unos.Size = new System.Drawing.Size(132, 20);
            this.tb_unos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Klikni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osnovniToolStripMenuItem,
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(513, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osnovniToolStripMenuItem
            // 
            this.osnovniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drugaToolStripMenuItem,
            this.drugaModalnoToolStripMenuItem});
            this.osnovniToolStripMenuItem.Name = "osnovniToolStripMenuItem";
            this.osnovniToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.osnovniToolStripMenuItem.Text = "Osnovni";
            // 
            // drugaToolStripMenuItem
            // 
            this.drugaToolStripMenuItem.Name = "drugaToolStripMenuItem";
            this.drugaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.drugaToolStripMenuItem.Text = "Druga";
            this.drugaToolStripMenuItem.Click += new System.EventHandler(this.drugaToolStripMenuItem_Click);
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            // 
            // oProgToolStripMenuItem
            // 
            this.oProgToolStripMenuItem.Name = "oProgToolStripMenuItem";
            this.oProgToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgToolStripMenuItem.Text = "O programu";
            this.oProgToolStripMenuItem.Click += new System.EventHandler(this.oProgToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // drugaModalnoToolStripMenuItem
            // 
            this.drugaModalnoToolStripMenuItem.Name = "drugaModalnoToolStripMenuItem";
            this.drugaModalnoToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.drugaModalnoToolStripMenuItem.Text = "Druga modalno";
            this.drugaModalnoToolStripMenuItem.Click += new System.EventHandler(this.drugaModalnoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_unos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Predavanje 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_unos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem osnovniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugaModalnoToolStripMenuItem;
    }
}

