namespace Predavanje_4
{
    partial class UnosForma
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_godiste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_reg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_tip = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Naziv:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(113, 38);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(185, 20);
            this.tb_naziv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip:";
            // 
            // tb_godiste
            // 
            this.tb_godiste.Location = new System.Drawing.Point(113, 122);
            this.tb_godiste.Name = "tb_godiste";
            this.tb_godiste.Size = new System.Drawing.Size(185, 20);
            this.tb_godiste.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Godište:";
            // 
            // tb_reg
            // 
            this.tb_reg.Location = new System.Drawing.Point(113, 164);
            this.tb_reg.Name = "tb_reg";
            this.tb_reg.Size = new System.Drawing.Size(185, 20);
            this.tb_reg.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Registracija:";
            // 
            // cb_tip
            // 
            this.cb_tip.FormattingEnabled = true;
            this.cb_tip.Location = new System.Drawing.Point(113, 78);
            this.cb_tip.Name = "cb_tip";
            this.cb_tip.Size = new System.Drawing.Size(185, 21);
            this.cb_tip.TabIndex = 10;
            // 
            // UnosForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 288);
            this.Controls.Add(this.cb_tip);
            this.Controls.Add(this.tb_reg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_godiste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UnosForma";
            this.Text = "Unos jedrilica";
            this.Load += new System.EventHandler(this.UnosForma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_godiste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_reg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_tip;
    }
}