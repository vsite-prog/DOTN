namespace Predavanje_4
{
    partial class UnosForm
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
            this.tb_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_god = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_tip = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_opis = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registracija:";
            // 
            // tb_reg
            // 
            this.tb_reg.Location = new System.Drawing.Point(141, 32);
            this.tb_reg.Name = "tb_reg";
            this.tb_reg.Size = new System.Drawing.Size(144, 20);
            this.tb_reg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Godiste:";
            // 
            // tb_god
            // 
            this.tb_god.Location = new System.Drawing.Point(141, 70);
            this.tb_god.Name = "tb_god";
            this.tb_god.Size = new System.Drawing.Size(144, 20);
            this.tb_god.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip:";
            // 
            // cb_tip
            // 
            this.cb_tip.FormattingEnabled = true;
            this.cb_tip.Location = new System.Drawing.Point(141, 104);
            this.cb_tip.Name = "cb_tip";
            this.cb_tip.Size = new System.Drawing.Size(144, 21);
            this.cb_tip.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opis:";
            // 
            // tb_opis
            // 
            this.tb_opis.Location = new System.Drawing.Point(141, 138);
            this.tb_opis.Multiline = true;
            this.tb_opis.Name = "tb_opis";
            this.tb_opis.Size = new System.Drawing.Size(144, 68);
            this.tb_opis.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tb_opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_tip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_god);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_reg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "UnosForm";
            this.Text = "UnosForm";
            this.Load += new System.EventHandler(this.UnosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_god;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_tip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_opis;
        private System.Windows.Forms.Button button2;
    }
}