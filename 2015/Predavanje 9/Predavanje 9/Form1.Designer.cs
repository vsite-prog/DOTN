namespace Predavanje_9
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
            this.tb_adresa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_poruka = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web adresa:";
            // 
            // tb_adresa
            // 
            this.tb_adresa.Location = new System.Drawing.Point(123, 35);
            this.tb_adresa.Name = "tb_adresa";
            this.tb_adresa.Size = new System.Drawing.Size(349, 20);
            this.tb_adresa.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Idi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_poruka
            // 
            this.lb_poruka.AutoSize = true;
            this.lb_poruka.Location = new System.Drawing.Point(33, 74);
            this.lb_poruka.Name = "lb_poruka";
            this.lb_poruka.Size = new System.Drawing.Size(0, 13);
            this.lb_poruka.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(36, 103);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(536, 331);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 446);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.lb_poruka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_adresa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Naš preglednik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_adresa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_poruka;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

