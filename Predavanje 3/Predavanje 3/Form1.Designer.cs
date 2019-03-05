namespace Predavanje_3
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
            this.tb_ponovi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_pozadina = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.glavniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.osnovniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugaFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi neku poruku:";
            // 
            // tb_ponovi
            // 
            this.tb_ponovi.Location = new System.Drawing.Point(165, 50);
            this.tb_ponovi.Name = "tb_ponovi";
            this.tb_ponovi.Size = new System.Drawing.Size(173, 20);
            this.tb_ponovi.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ponovi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_pozadina
            // 
            this.cb_pozadina.FormattingEnabled = true;
            this.cb_pozadina.Items.AddRange(new object[] {
            "Plava",
            "Crvena",
            "Zelena",
            "Default"});
            this.cb_pozadina.Location = new System.Drawing.Point(164, 104);
            this.cb_pozadina.Name = "cb_pozadina";
            this.cb_pozadina.Size = new System.Drawing.Size(173, 21);
            this.cb_pozadina.TabIndex = 3;
            this.cb_pozadina.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberi boju pozadine:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glavniToolStripMenuItem,
            this.osnovniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // glavniToolStripMenuItem
            // 
            this.glavniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drugaFormaToolStripMenuItem});
            this.glavniToolStripMenuItem.Name = "glavniToolStripMenuItem";
            this.glavniToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.glavniToolStripMenuItem.Text = "Glavni";
            // 
            // osnovniToolStripMenuItem
            // 
            this.osnovniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.osnovniToolStripMenuItem.Name = "osnovniToolStripMenuItem";
            this.osnovniToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.osnovniToolStripMenuItem.Text = "Osnovni";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // drugaFormaToolStripMenuItem
            // 
            this.drugaFormaToolStripMenuItem.Name = "drugaFormaToolStripMenuItem";
            this.drugaFormaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.drugaFormaToolStripMenuItem.Text = "Megafon forma";
            this.drugaFormaToolStripMenuItem.Click += new System.EventHandler(this.drugaFormaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_pozadina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ponovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Naša aplikacija";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ponovi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_pozadina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem glavniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugaFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem osnovniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

