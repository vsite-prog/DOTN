namespace Predavanje3
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
            this.tb_pojam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.glavniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomoćniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriFormuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb_gradovi = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_boja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesi pojam:";
            // 
            // tb_pojam
            // 
            this.tb_pojam.Location = new System.Drawing.Point(150, 53);
            this.tb_pojam.Name = "tb_pojam";
            this.tb_pojam.Size = new System.Drawing.Size(174, 20);
            this.tb_pojam.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(344, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Poruka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.glavniToolStripMenuItem,
            this.pomoćniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(590, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // glavniToolStripMenuItem
            // 
            this.glavniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otvoriFormuToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.glavniToolStripMenuItem.Name = "glavniToolStripMenuItem";
            this.glavniToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.glavniToolStripMenuItem.Text = "Glavni";
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.izlazToolStripMenuItem.Text = "Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // pomoćniToolStripMenuItem
            // 
            this.pomoćniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.pomoćniToolStripMenuItem.Name = "pomoćniToolStripMenuItem";
            this.pomoćniToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.pomoćniToolStripMenuItem.Text = "Pomoćni";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // otvoriFormuToolStripMenuItem
            // 
            this.otvoriFormuToolStripMenuItem.Name = "otvoriFormuToolStripMenuItem";
            this.otvoriFormuToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.otvoriFormuToolStripMenuItem.Text = "Otvori formu";
            this.otvoriFormuToolStripMenuItem.Click += new System.EventHandler(this.otvoriFormuToolStripMenuItem_Click);
            // 
            // lb_gradovi
            // 
            this.lb_gradovi.AutoSize = true;
            this.lb_gradovi.Location = new System.Drawing.Point(37, 98);
            this.lb_gradovi.Name = "lb_gradovi";
            this.lb_gradovi.Size = new System.Drawing.Size(0, 13);
            this.lb_gradovi.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(32, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Omogući";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(32, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Onemogući";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(43, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 75);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos gradova";
            // 
            // cb_boja
            // 
            this.cb_boja.FormattingEnabled = true;
            this.cb_boja.Items.AddRange(new object[] {
            "sivo",
            "crveno",
            "plavo",
            "zeleno"});
            this.cb_boja.Location = new System.Drawing.Point(111, 218);
            this.cb_boja.Name = "cb_boja";
            this.cb_boja.Size = new System.Drawing.Size(121, 21);
            this.cb_boja.TabIndex = 8;
            this.cb_boja.SelectedIndexChanged += new System.EventHandler(this.cb_boja_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mijenjaj boju:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 361);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_boja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb_gradovi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pojam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Naša aplikacija";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pojam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem glavniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomoćniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otvoriFormuToolStripMenuItem;
        private System.Windows.Forms.Label lb_gradovi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_boja;
        private System.Windows.Forms.Label label2;
    }
}

