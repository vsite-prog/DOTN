namespace Predavanje7
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
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_oib = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_studij = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_svi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(128, 36);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_ime.TabIndex = 1;
            // 
            // tb_oib
            // 
            this.tb_oib.Location = new System.Drawing.Point(128, 62);
            this.tb_oib.Name = "tb_oib";
            this.tb_oib.Size = new System.Drawing.Size(100, 20);
            this.tb_oib.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "OIB:";
            // 
            // cb_studij
            // 
            this.cb_studij.FormattingEnabled = true;
            this.cb_studij.Items.AddRange(new object[] {
            "1",
            "4"});
            this.cb_studij.Location = new System.Drawing.Point(128, 88);
            this.cb_studij.Name = "cb_studij";
            this.cb_studij.Size = new System.Drawing.Size(100, 21);
            this.cb_studij.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Studij:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Kreiraj studenta";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_svi
            // 
            this.lb_svi.AutoSize = true;
            this.lb_svi.Location = new System.Drawing.Point(52, 175);
            this.lb_svi.Name = "lb_svi";
            this.lb_svi.Size = new System.Drawing.Size(0, 13);
            this.lb_svi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 320);
            this.Controls.Add(this.lb_svi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_studij);
            this.Controls.Add(this.tb_oib);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Studenti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_oib;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_studij;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_svi;
    }
}

