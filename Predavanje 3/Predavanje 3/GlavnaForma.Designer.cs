
namespace Predavanje_3
{
    partial class GlavnaForma
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
            this.tb_unos = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_pozadina = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prviDioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugiDioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugaFormaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_unos
            // 
            this.tb_unos.Location = new System.Drawing.Point(205, 82);
            this.tb_unos.Name = "tb_unos";
            this.tb_unos.Size = new System.Drawing.Size(268, 22);
            this.tb_unos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(514, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kliknite";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb_pozadina
            // 
            this.cb_pozadina.FormattingEnabled = true;
            this.cb_pozadina.Items.AddRange(new object[] {
            "Bijela",
            "Crvena",
            "Plava",
            "Zelena"});
            this.cb_pozadina.Location = new System.Drawing.Point(256, 161);
            this.cb_pozadina.Name = "cb_pozadina";
            this.cb_pozadina.Size = new System.Drawing.Size(121, 24);
            this.cb_pozadina.TabIndex = 2;
            this.cb_pozadina.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Odaberi boju pozadine:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prviDioToolStripMenuItem,
            this.drugiDioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prviDioToolStripMenuItem
            // 
            this.prviDioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drugaFormaToolStripMenuItem});
            this.prviDioToolStripMenuItem.Name = "prviDioToolStripMenuItem";
            this.prviDioToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.prviDioToolStripMenuItem.Text = "Prvi dio";
            // 
            // drugiDioToolStripMenuItem
            // 
            this.drugiDioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.drugiDioToolStripMenuItem.Name = "drugiDioToolStripMenuItem";
            this.drugiDioToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.drugiDioToolStripMenuItem.Text = "Drugi dio";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // drugaFormaToolStripMenuItem
            // 
            this.drugaFormaToolStripMenuItem.Name = "drugaFormaToolStripMenuItem";
            this.drugaFormaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.drugaFormaToolStripMenuItem.Text = "Druga forma";
            this.drugaFormaToolStripMenuItem.Click += new System.EventHandler(this.drugaFormaToolStripMenuItem_Click);
            // 
            // GlavnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_pozadina);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_unos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GlavnaForma";
            this.Text = "Glavna forma našeg programa";
            this.Load += new System.EventHandler(this.GlavnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_unos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_pozadina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prviDioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugaFormaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem drugiDioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

