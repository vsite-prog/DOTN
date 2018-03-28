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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.bt_spremi = new System.Windows.Forms.Button();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_avioni = new System.Windows.Forms.ComboBox();
            this.bt_ubrzaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(86, 53);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(118, 20);
            this.tb_naziv.TabIndex = 2;
            // 
            // bt_spremi
            // 
            this.bt_spremi.Location = new System.Drawing.Point(86, 135);
            this.bt_spremi.Name = "bt_spremi";
            this.bt_spremi.Size = new System.Drawing.Size(75, 23);
            this.bt_spremi.TabIndex = 3;
            this.bt_spremi.Text = "Spremi";
            this.bt_spremi.UseVisualStyleBackColor = true;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(86, 96);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(118, 20);
            this.tb_brzina.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Brzina:";
            // 
            // cb_avioni
            // 
            this.cb_avioni.FormattingEnabled = true;
            this.cb_avioni.Location = new System.Drawing.Point(31, 180);
            this.cb_avioni.Name = "cb_avioni";
            this.cb_avioni.Size = new System.Drawing.Size(121, 21);
            this.cb_avioni.TabIndex = 6;
            // 
            // bt_ubrzaj
            // 
            this.bt_ubrzaj.Location = new System.Drawing.Point(158, 178);
            this.bt_ubrzaj.Name = "bt_ubrzaj";
            this.bt_ubrzaj.Size = new System.Drawing.Size(100, 23);
            this.bt_ubrzaj.TabIndex = 7;
            this.bt_ubrzaj.Text = "Ubrzaj za 100";
            this.bt_ubrzaj.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bt_ubrzaj);
            this.Controls.Add(this.cb_avioni);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_spremi);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Button bt_spremi;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_avioni;
        private System.Windows.Forms.Button bt_ubrzaj;
    }

    class MyEventArgs : System.EventArgs
    {
        public double Prekoracenje { get; set; }
    }
}

