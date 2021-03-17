namespace Predavanje_8
{
    partial class PreglednikForma
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.lb_statusa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(27, 81);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1453, 514);
            this.webBrowser1.TabIndex = 0;
            // 
            // lb_statusa
            // 
            this.lb_statusa.AutoSize = true;
            this.lb_statusa.Location = new System.Drawing.Point(27, 612);
            this.lb_statusa.Name = "lb_statusa";
            this.lb_statusa.Size = new System.Drawing.Size(0, 17);
            this.lb_statusa.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesi adresu stranice:";
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(187, 36);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(1162, 22);
            this.tb_adresa.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1371, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Idi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PreglednikForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_statusa);
            this.Controls.Add(this.webBrowser1);
            this.Name = "PreglednikForma";
            this.Text = "PreglednikForma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label lb_statusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.Button button1;
    }
}