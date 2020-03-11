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
            this.tb_tekst = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_poruka = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_boja = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.početniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOrukaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi tekst:";
            // 
            // tb_tekst
            // 
            this.tb_tekst.Location = new System.Drawing.Point(205, 65);
            this.tb_tekst.Name = "tb_tekst";
            this.tb_tekst.Size = new System.Drawing.Size(274, 22);
            this.tb_tekst.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(508, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prikaži tekst";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_poruka
            // 
            this.lb_poruka.AutoSize = true;
            this.lb_poruka.Location = new System.Drawing.Point(64, 375);
            this.lb_poruka.Name = "lb_poruka";
            this.lb_poruka.Size = new System.Drawing.Size(0, 17);
            this.lb_poruka.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Odaberi boju pozadine:";
            // 
            // cb_boja
            // 
            this.cb_boja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_boja.FormattingEnabled = true;
            this.cb_boja.Items.AddRange(new object[] {
            "Standardna",
            "Crvena",
            "Plava",
            "Zelena"});
            this.cb_boja.Location = new System.Drawing.Point(205, 148);
            this.cb_boja.Name = "cb_boja";
            this.cb_boja.Size = new System.Drawing.Size(274, 24);
            this.cb_boja.TabIndex = 5;
            this.cb_boja.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.početniToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // početniToolStripMenuItem
            // 
            this.početniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pOrukaToolStripMenuItem});
            this.početniToolStripMenuItem.Name = "početniToolStripMenuItem";
            this.početniToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.početniToolStripMenuItem.Text = "Početni";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izlazToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pOrukaToolStripMenuItem
            // 
            this.pOrukaToolStripMenuItem.Name = "pOrukaToolStripMenuItem";
            this.pOrukaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pOrukaToolStripMenuItem.Text = "Poruka";
            this.pOrukaToolStripMenuItem.Click += new System.EventHandler(this.pOrukaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_boja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_poruka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_tekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Predavanje 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_tekst;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_poruka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_boja;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem početniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOrukaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
    }
}

