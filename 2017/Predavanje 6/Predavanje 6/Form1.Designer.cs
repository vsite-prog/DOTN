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
            this.bt_spremi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_brzina = new System.Windows.Forms.TextBox();
            this.bt_brzina = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_avioni = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_spremi
            // 
            this.bt_spremi.Location = new System.Drawing.Point(379, 43);
            this.bt_spremi.Name = "bt_spremi";
            this.bt_spremi.Size = new System.Drawing.Size(75, 23);
            this.bt_spremi.TabIndex = 0;
            this.bt_spremi.Text = "Spremi";
            this.bt_spremi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "UNesi novi avion:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(136, 45);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(219, 20);
            this.tb_naziv.TabIndex = 2;
            // 
            // tb_brzina
            // 
            this.tb_brzina.Location = new System.Drawing.Point(136, 178);
            this.tb_brzina.Name = "tb_brzina";
            this.tb_brzina.Size = new System.Drawing.Size(122, 20);
            this.tb_brzina.TabIndex = 3;
            // 
            // bt_brzina
            // 
            this.bt_brzina.Location = new System.Drawing.Point(280, 175);
            this.bt_brzina.Name = "bt_brzina";
            this.bt_brzina.Size = new System.Drawing.Size(75, 23);
            this.bt_brzina.TabIndex = 4;
            this.bt_brzina.Text = "Spremi";
            this.bt_brzina.UseVisualStyleBackColor = true;
            this.bt_brzina.Click += new System.EventHandler(this.bt_brzina_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Promjena brzine:";
            // 
            // cb_avioni
            // 
            this.cb_avioni.FormattingEnabled = true;
            this.cb_avioni.Location = new System.Drawing.Point(136, 115);
            this.cb_avioni.Name = "cb_avioni";
            this.cb_avioni.Size = new System.Drawing.Size(219, 21);
            this.cb_avioni.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 261);
            this.Controls.Add(this.cb_avioni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_brzina);
            this.Controls.Add(this.tb_brzina);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_spremi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_spremi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.TextBox tb_brzina;
        private System.Windows.Forms.Button bt_brzina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_avioni;
    }
}

