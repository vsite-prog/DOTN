namespace Predavanje_5
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_tekst = new System.Windows.Forms.TextBox();
            this.lb_rezultat = new System.Windows.Forms.Label();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upiši neki  tekst:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(318, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Piši";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_tekst
            // 
            this.tb_tekst.Location = new System.Drawing.Point(164, 23);
            this.tb_tekst.Name = "tb_tekst";
            this.tb_tekst.Size = new System.Drawing.Size(129, 20);
            this.tb_tekst.TabIndex = 2;
            // 
            // lb_rezultat
            // 
            this.lb_rezultat.AutoSize = true;
            this.lb_rezultat.Location = new System.Drawing.Point(56, 69);
            this.lb_rezultat.Name = "lb_rezultat";
            this.lb_rezultat.Size = new System.Drawing.Size(0, 13);
            this.lb_rezultat.TabIndex = 3;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(164, 96);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(129, 20);
            this.tb_brzina.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(318, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ubrzaj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ubrzaj našu raketu:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_rezultat);
            this.Controls.Add(this.tb_tekst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_tekst;
        private System.Windows.Forms.Label lb_rezultat;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}

