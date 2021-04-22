
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
            this.tb_izlijeceni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_umrli = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_drzava = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_corona = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corona)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zaraženi ukupno:";
            // 
            // tb_zarazeni
            // 
            this.tb_zarazeni.Location = new System.Drawing.Point(192, 40);
            this.tb_zarazeni.Name = "tb_zarazeni";
            this.tb_zarazeni.Size = new System.Drawing.Size(149, 22);
            this.tb_zarazeni.TabIndex = 1;
            // 
            // tb_izlijeceni
            // 
            this.tb_izlijeceni.Location = new System.Drawing.Point(192, 88);
            this.tb_izlijeceni.Name = "tb_izlijeceni";
            this.tb_izlijeceni.Size = new System.Drawing.Size(149, 22);
            this.tb_izlijeceni.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Izliječeni ukupno:";
            // 
            // tb_umrli
            // 
            this.tb_umrli.Location = new System.Drawing.Point(192, 145);
            this.tb_umrli.Name = "tb_umrli";
            this.tb_umrli.Size = new System.Drawing.Size(149, 22);
            this.tb_umrli.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Umrli ukupno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Država:";
            // 
            // cb_drzava
            // 
            this.cb_drzava.FormattingEnabled = true;
            this.cb_drzava.Location = new System.Drawing.Point(192, 199);
            this.cb_drzava.Name = "cb_drzava";
            this.cb_drzava.Size = new System.Drawing.Size(149, 24);
            this.cb_drzava.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_corona
            // 
            this.dgv_corona.AllowUserToAddRows = false;
            this.dgv_corona.AllowUserToDeleteRows = false;
            this.dgv_corona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_corona.Location = new System.Drawing.Point(51, 316);
            this.dgv_corona.Name = "dgv_corona";
            this.dgv_corona.ReadOnly = true;
            this.dgv_corona.RowHeadersWidth = 51;
            this.dgv_corona.RowTemplate.Height = 24;
            this.dgv_corona.Size = new System.Drawing.Size(1064, 376);
            this.dgv_corona.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 704);
            this.Controls.Add(this.dgv_corona);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_drzava);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_umrli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_izlijeceni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_zarazeni);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_corona)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_zarazeni;
        private System.Windows.Forms.TextBox tb_izlijeceni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_umrli;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_drzava;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_corona;
    }
}

