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
            ((System.ComponentModel.ISupportInitialize)(this.gv_slucajevi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj zaraženih:";
            // 
            // tb_zarazeni
            // 
            this.tb_zarazeni.Location = new System.Drawing.Point(194, 32);
            this.tb_zarazeni.Name = "tb_zarazeni";
            this.tb_zarazeni.Size = new System.Drawing.Size(228, 22);
            this.tb_zarazeni.TabIndex = 1;
            // 
            // tb_umrli
            // 
            this.tb_umrli.Location = new System.Drawing.Point(194, 82);
            this.tb_umrli.Name = "tb_umrli";
            this.tb_umrli.Size = new System.Drawing.Size(228, 22);
            this.tb_umrli.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj preminulih:";
            // 
            // tb_ozdravljeni
            // 
            this.tb_ozdravljeni.Location = new System.Drawing.Point(194, 141);
            this.tb_ozdravljeni.Name = "tb_ozdravljeni";
            this.tb_ozdravljeni.Size = new System.Drawing.Size(228, 22);
            this.tb_ozdravljeni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj ozdravljenih:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Država:";
            // 
            // cb_drzava
            // 
            this.cb_drzava.FormattingEnabled = true;
            this.cb_drzava.Location = new System.Drawing.Point(194, 199);
            this.cb_drzava.Name = "cb_drzava";
            this.cb_drzava.Size = new System.Drawing.Size(228, 24);
            this.cb_drzava.TabIndex = 7;
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
            this.gv_slucajevi.Location = new System.Drawing.Point(472, 32);
            this.gv_slucajevi.Name = "gv_slucajevi";
            this.gv_slucajevi.RowHeadersWidth = 51;
            this.gv_slucajevi.RowTemplate.Height = 24;
            this.gv_slucajevi.Size = new System.Drawing.Size(952, 506);
            this.gv_slucajevi.TabIndex = 9;
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_slucajevi)).EndInit();
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
    }
}

