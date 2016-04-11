namespace Predavanje_7
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
            this.cb_tip = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_cijena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_opis = new System.Windows.Forms.TextBox();
            this.lb_petshop = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tip:";
            // 
            // cb_tip
            // 
            this.cb_tip.FormattingEnabled = true;
            this.cb_tip.Items.AddRange(new object[] {
            "Pas",
            "Mačka",
            "Ribica"});
            this.cb_tip.Location = new System.Drawing.Point(99, 192);
            this.cb_tip.Name = "cb_tip";
            this.cb_tip.Size = new System.Drawing.Size(121, 21);
            this.cb_tip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(99, 227);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(121, 20);
            this.tb_naziv.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena:";
            // 
            // tb_cijena
            // 
            this.tb_cijena.Location = new System.Drawing.Point(99, 263);
            this.tb_cijena.Name = "tb_cijena";
            this.tb_cijena.Size = new System.Drawing.Size(121, 20);
            this.tb_cijena.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "OPis:";
            // 
            // tb_opis
            // 
            this.tb_opis.Location = new System.Drawing.Point(36, 313);
            this.tb_opis.Multiline = true;
            this.tb_opis.Name = "tb_opis";
            this.tb_opis.Size = new System.Drawing.Size(418, 58);
            this.tb_opis.TabIndex = 7;
            // 
            // lb_petshop
            // 
            this.lb_petshop.AutoSize = true;
            this.lb_petshop.Location = new System.Drawing.Point(27, 9);
            this.lb_petshop.Name = "lb_petshop";
            this.lb_petshop.Size = new System.Drawing.Size(0, 13);
            this.lb_petshop.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 402);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_petshop);
            this.Controls.Add(this.tb_opis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_cijena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_tip);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Pet shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_cijena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_opis;
        private System.Windows.Forms.Label lb_petshop;
        private System.Windows.Forms.Button button1;
    }
}

