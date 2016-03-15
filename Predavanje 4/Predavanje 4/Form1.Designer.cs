namespace Predavanje_4
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
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tip = new System.Windows.Forms.ComboBox();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_auti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(125, 25);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(213, 20);
            this.tb_naziv.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kreiraj auto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip vozila:";
            // 
            // cb_tip
            // 
            this.cb_tip.FormattingEnabled = true;
            this.cb_tip.Location = new System.Drawing.Point(125, 66);
            this.cb_tip.Name = "cb_tip";
            this.cb_tip.Size = new System.Drawing.Size(213, 21);
            this.cb_tip.TabIndex = 4;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(125, 112);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(213, 20);
            this.tb_brzina.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Brzina:";
            // 
            // lb_auti
            // 
            this.lb_auti.AutoSize = true;
            this.lb_auti.Location = new System.Drawing.Point(30, 191);
            this.lb_auti.Name = "lb_auti";
            this.lb_auti.Size = new System.Drawing.Size(0, 13);
            this.lb_auti.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 456);
            this.Controls.Add(this.lb_auti);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_tip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tip;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_auti;
    }
}

