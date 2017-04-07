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
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_cijena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_vrsta = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_pets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(70, 61);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(121, 20);
            this.tb_naziv.TabIndex = 1;
            // 
            // tb_cijena
            // 
            this.tb_cijena.Location = new System.Drawing.Point(70, 99);
            this.tb_cijena.Name = "tb_cijena";
            this.tb_cijena.Size = new System.Drawing.Size(121, 20);
            this.tb_cijena.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cijebna:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vrsta:";
            // 
            // cb_vrsta
            // 
            this.cb_vrsta.FormattingEnabled = true;
            this.cb_vrsta.Location = new System.Drawing.Point(70, 24);
            this.cb_vrsta.Name = "cb_vrsta";
            this.cb_vrsta.Size = new System.Drawing.Size(121, 21);
            this.cb_vrsta.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_pets
            // 
            this.lb_pets.AutoSize = true;
            this.lb_pets.Location = new System.Drawing.Point(234, 24);
            this.lb_pets.Name = "lb_pets";
            this.lb_pets.Size = new System.Drawing.Size(48, 13);
            this.lb_pets.TabIndex = 7;
            this.lb_pets.Text = "Ljubimci:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 274);
            this.Controls.Add(this.lb_pets);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_vrsta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_cijena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ZOO Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.TextBox tb_cijena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_vrsta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_pets;
    }
}

