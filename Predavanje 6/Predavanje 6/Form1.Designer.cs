
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
            this.bt_unesi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_rakete = new System.Windows.Forms.ComboBox();
            this.bt_500 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_unesi
            // 
            this.bt_unesi.Location = new System.Drawing.Point(201, 129);
            this.bt_unesi.Name = "bt_unesi";
            this.bt_unesi.Size = new System.Drawing.Size(75, 23);
            this.bt_unesi.TabIndex = 0;
            this.bt_unesi.Text = "Unesi";
            this.bt_unesi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime rakete:";
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(126, 38);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(150, 22);
            this.tb_ime.TabIndex = 2;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(126, 82);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(150, 22);
            this.tb_brzina.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Brzina:";
            // 
            // cb_rakete
            // 
            this.cb_rakete.FormattingEnabled = true;
            this.cb_rakete.Location = new System.Drawing.Point(53, 227);
            this.cb_rakete.Name = "cb_rakete";
            this.cb_rakete.Size = new System.Drawing.Size(121, 24);
            this.cb_rakete.TabIndex = 5;
            // 
            // bt_500
            // 
            this.bt_500.Location = new System.Drawing.Point(201, 227);
            this.bt_500.Name = "bt_500";
            this.bt_500.Size = new System.Drawing.Size(75, 23);
            this.bt_500.TabIndex = 6;
            this.bt_500.Text = "+500";
            this.bt_500.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_500);
            this.Controls.Add(this.cb_rakete);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_unesi);
            this.Name = "Form1";
            this.Text = "Predavanje 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_unesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_rakete;
        private System.Windows.Forms.Button bt_500;
    }
}

