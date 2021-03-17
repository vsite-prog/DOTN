namespace Predavanje_6
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
            this.bt_kreiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_plus = new System.Windows.Forms.Button();
            this.cb_rakete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_kreiraj
            // 
            this.bt_kreiraj.Location = new System.Drawing.Point(624, 86);
            this.bt_kreiraj.Name = "bt_kreiraj";
            this.bt_kreiraj.Size = new System.Drawing.Size(75, 23);
            this.bt_kreiraj.TabIndex = 0;
            this.bt_kreiraj.Text = "Kreiraj";
            this.bt_kreiraj.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unesi naziv rakete:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(219, 86);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(377, 22);
            this.tb_naziv.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ubrzaj za 100";
            // 
            // bt_plus
            // 
            this.bt_plus.Location = new System.Drawing.Point(375, 230);
            this.bt_plus.Name = "bt_plus";
            this.bt_plus.Size = new System.Drawing.Size(68, 23);
            this.bt_plus.TabIndex = 4;
            this.bt_plus.Text = "+";
            this.bt_plus.UseVisualStyleBackColor = true;
            // 
            // cb_rakete
            // 
            this.cb_rakete.FormattingEnabled = true;
            this.cb_rakete.Location = new System.Drawing.Point(54, 227);
            this.cb_rakete.Name = "cb_rakete";
            this.cb_rakete.Size = new System.Drawing.Size(168, 24);
            this.cb_rakete.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_rakete);
            this.Controls.Add(this.bt_plus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_kreiraj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_kreiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bt_plus;
        private System.Windows.Forms.ComboBox cb_rakete;
    }
}

