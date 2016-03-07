namespace Predavanje4
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
            this.label2 = new System.Windows.Forms.Label();
            this.cb_zoo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_spremi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tezina = new System.Windows.Forms.TextBox();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(95, 31);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(100, 20);
            this.tb_ime.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ZOO:";
            // 
            // cb_zoo
            // 
            this.cb_zoo.FormattingEnabled = true;
            this.cb_zoo.Location = new System.Drawing.Point(95, 73);
            this.cb_zoo.Name = "cb_zoo";
            this.cb_zoo.Size = new System.Drawing.Size(121, 21);
            this.cb_zoo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Težina:";
            // 
            // bt_spremi
            // 
            this.bt_spremi.Location = new System.Drawing.Point(35, 164);
            this.bt_spremi.Name = "bt_spremi";
            this.bt_spremi.Size = new System.Drawing.Size(75, 23);
            this.bt_spremi.TabIndex = 6;
            this.bt_spremi.Text = "Spremi me";
            this.bt_spremi.UseVisualStyleBackColor = true;
            this.bt_spremi.Click += new System.EventHandler(this.bt_spremi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 7;
            // 
            // tb_tezina
            // 
            this.tb_tezina.Location = new System.Drawing.Point(95, 105);
            this.tb_tezina.Name = "tb_tezina";
            this.tb_tezina.Size = new System.Drawing.Size(100, 20);
            this.tb_tezina.TabIndex = 8;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(95, 138);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(100, 20);
            this.tb_brzina.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Brzina";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tezina);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_spremi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_zoo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Životinje";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_zoo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_spremi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tezina;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Label label5;
    }
}

