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
            this.tb_unos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_boja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.osnovniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugaFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_unos = new System.Windows.Forms.CheckBox();
            this.lb_studenti = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reci nešto:";
            // 
            // tb_unos
            // 
            this.tb_unos.Location = new System.Drawing.Point(108, 42);
            this.tb_unos.Name = "tb_unos";
            this.tb_unos.Size = new System.Drawing.Size(230, 20);
            this.tb_unos.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Vikni";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_boja
            // 
            this.cb_boja.FormattingEnabled = true;
            this.cb_boja.Items.AddRange(new object[] {
            "Standardna",
            "Crvena",
            "Plava",
            "Zelena"});
            this.cb_boja.Location = new System.Drawing.Point(100, 100);
            this.cb_boja.Name = "cb_boja";
            this.cb_boja.Size = new System.Drawing.Size(121, 21);
            this.cb_boja.TabIndex = 3;
            this.cb_boja.SelectedIndexChanged += new System.EventHandler(this.cb_boja_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberi boju:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.osnovniToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // osnovniToolStripMenuItem
            // 
            this.osnovniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drugaFormaToolStripMenuItem});
            this.osnovniToolStripMenuItem.Name = "osnovniToolStripMenuItem";
            this.osnovniToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.osnovniToolStripMenuItem.Text = "Osnovni";
            // 
            // drugaFormaToolStripMenuItem
            // 
            this.drugaFormaToolStripMenuItem.Name = "drugaFormaToolStripMenuItem";
            this.drugaFormaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.drugaFormaToolStripMenuItem.Text = "Unos studenata";
            this.drugaFormaToolStripMenuItem.Click += new System.EventHandler(this.drugaFormaToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // cb_unos
            // 
            this.cb_unos.AutoSize = true;
            this.cb_unos.Location = new System.Drawing.Point(100, 153);
            this.cb_unos.Name = "cb_unos";
            this.cb_unos.Size = new System.Drawing.Size(87, 17);
            this.cb_unos.TabIndex = 6;
            this.cb_unos.Text = "Dozvoli unos";
            this.cb_unos.UseVisualStyleBackColor = true;
            this.cb_unos.CheckedChanged += new System.EventHandler(this.cb_unos_CheckedChanged);
            // 
            // lb_studenti
            // 
            this.lb_studenti.AutoSize = true;
            this.lb_studenti.Location = new System.Drawing.Point(370, 90);
            this.lb_studenti.Name = "lb_studenti";
            this.lb_studenti.Size = new System.Drawing.Size(0, 13);
            this.lb_studenti.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 261);
            this.Controls.Add(this.lb_studenti);
            this.Controls.Add(this.cb_unos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_boja);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_unos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_unos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_boja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem osnovniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugaFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cb_unos;
        private System.Windows.Forms.Label lb_studenti;
    }
}

