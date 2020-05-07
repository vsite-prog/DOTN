namespace Predavanje_8
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
            this.tb_zarazeni = new System.Windows.Forms.TextBox();
            this.tb_umrli = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ozdravljeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_drzava = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gv_slucajevi = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.izbornikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ostaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izađiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pregledniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gv_slucajevi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj zaraženih:";
            // 
            // tb_zarazeni
            // 
            this.tb_zarazeni.Location = new System.Drawing.Point(201, 86);
            this.tb_zarazeni.Name = "tb_zarazeni";
            this.tb_zarazeni.Size = new System.Drawing.Size(228, 22);
            this.tb_zarazeni.TabIndex = 1;
            // 
            // tb_umrli
            // 
            this.tb_umrli.Location = new System.Drawing.Point(201, 136);
            this.tb_umrli.Name = "tb_umrli";
            this.tb_umrli.Size = new System.Drawing.Size(228, 22);
            this.tb_umrli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj preminulih:";
            // 
            // tb_ozdravljeni
            // 
            this.tb_ozdravljeni.Location = new System.Drawing.Point(201, 195);
            this.tb_ozdravljeni.Name = "tb_ozdravljeni";
            this.tb_ozdravljeni.Size = new System.Drawing.Size(228, 22);
            this.tb_ozdravljeni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj ozdravljenih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(479, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Država:";
            // 
            // cb_drzava
            // 
            this.cb_drzava.FormattingEnabled = true;
            this.cb_drzava.Location = new System.Drawing.Point(616, 30);
            this.cb_drzava.Name = "cb_drzava";
            this.cb_drzava.Size = new System.Drawing.Size(228, 24);
            this.cb_drzava.TabIndex = 7;
            this.cb_drzava.SelectedIndexChanged += new System.EventHandler(this.cb_drzava_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "Spremi u bazu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gv_slucajevi
            // 
            this.gv_slucajevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_slucajevi.Location = new System.Drawing.Point(472, 87);
            this.gv_slucajevi.Name = "gv_slucajevi";
            this.gv_slucajevi.RowHeadersWidth = 51;
            this.gv_slucajevi.RowTemplate.Height = 24;
            this.gv_slucajevi.Size = new System.Drawing.Size(952, 451);
            this.gv_slucajevi.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izbornikToolStripMenuItem,
            this.ostaloToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1436, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // izbornikToolStripMenuItem
            // 
            this.izbornikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pregledniToolStripMenuItem});
            this.izbornikToolStripMenuItem.Name = "izbornikToolStripMenuItem";
            this.izbornikToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.izbornikToolStripMenuItem.Text = "Izbornik";
            // 
            // ostaloToolStripMenuItem
            // 
            this.ostaloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.izađiToolStripMenuItem});
            this.ostaloToolStripMenuItem.Name = "ostaloToolStripMenuItem";
            this.ostaloToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.ostaloToolStripMenuItem.Text = "Ostalo";
            // 
            // izađiToolStripMenuItem
            // 
            this.izađiToolStripMenuItem.Name = "izađiToolStripMenuItem";
            this.izađiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.izađiToolStripMenuItem.Text = "Izađi";
            this.izađiToolStripMenuItem.Click += new System.EventHandler(this.izađiToolStripMenuItem_Click);
            // 
            // pregledniToolStripMenuItem
            // 
            this.pregledniToolStripMenuItem.Name = "pregledniToolStripMenuItem";
            this.pregledniToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pregledniToolStripMenuItem.Text = "Pregledni";
            this.pregledniToolStripMenuItem.Click += new System.EventHandler(this.pregledniToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 550);
            this.Controls.Add(this.gv_slucajevi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_drzava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ozdravljeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_umrli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_zarazeni);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_slucajevi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_zarazeni;
        private System.Windows.Forms.TextBox tb_umrli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ozdravljeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_drzava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gv_slucajevi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem izbornikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pregledniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ostaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izađiToolStripMenuItem;
    }
}

