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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_auto = new System.Windows.Forms.Label();
            this.bt_novi = new System.Windows.Forms.Button();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_auti = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promjena brzine:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lb_auto
            // 
            this.lb_auto.AutoSize = true;
            this.lb_auto.Location = new System.Drawing.Point(323, 20);
            this.lb_auto.Name = "lb_auto";
            this.lb_auto.Size = new System.Drawing.Size(35, 13);
            this.lb_auto.TabIndex = 3;
            this.lb_auto.Text = "label2";
            // 
            // bt_novi
            // 
            this.bt_novi.Location = new System.Drawing.Point(243, 115);
            this.bt_novi.Name = "bt_novi";
            this.bt_novi.Size = new System.Drawing.Size(75, 23);
            this.bt_novi.TabIndex = 6;
            this.bt_novi.Text = "Stvori auto";
            this.bt_novi.UseVisualStyleBackColor = true;
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(116, 115);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(100, 20);
            this.tb_naziv.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Novi auto:";
            // 
            // cb_auti
            // 
            this.cb_auti.FormattingEnabled = true;
            this.cb_auti.Location = new System.Drawing.Point(28, 20);
            this.cb_auti.Name = "cb_auti";
            this.cb_auti.Size = new System.Drawing.Size(206, 21);
            this.cb_auti.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 164);
            this.Controls.Add(this.cb_auti);
            this.Controls.Add(this.bt_novi);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_auto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_auto;
        private System.Windows.Forms.Button bt_novi;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_auti;
    }
}

