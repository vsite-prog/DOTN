
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_zemlja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_broj = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_proizvodaci = new System.Windows.Forms.ComboBox();
            this.lb_cijepljeni = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Spremi cijepljenje";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_zemlja
            // 
            this.tb_zemlja.Location = new System.Drawing.Point(185, 39);
            this.tb_zemlja.Name = "tb_zemlja";
            this.tb_zemlja.Size = new System.Drawing.Size(229, 22);
            this.tb_zemlja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Unesi zemlju:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj cijepljenih:";
            // 
            // tb_broj
            // 
            this.tb_broj.Location = new System.Drawing.Point(185, 84);
            this.tb_broj.Name = "tb_broj";
            this.tb_broj.Size = new System.Drawing.Size(229, 22);
            this.tb_broj.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Broj cijepljenih:";
            // 
            // cb_proizvodaci
            // 
            this.cb_proizvodaci.FormattingEnabled = true;
            this.cb_proizvodaci.Location = new System.Drawing.Point(185, 130);
            this.cb_proizvodaci.Name = "cb_proizvodaci";
            this.cb_proizvodaci.Size = new System.Drawing.Size(229, 24);
            this.cb_proizvodaci.TabIndex = 6;
            // 
            // lb_cijepljeni
            // 
            this.lb_cijepljeni.AutoSize = true;
            this.lb_cijepljeni.Location = new System.Drawing.Point(74, 238);
            this.lb_cijepljeni.Name = "lb_cijepljeni";
            this.lb_cijepljeni.Size = new System.Drawing.Size(0, 17);
            this.lb_cijepljeni.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 512);
            this.Controls.Add(this.lb_cijepljeni);
            this.Controls.Add(this.cb_proizvodaci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_broj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_zemlja);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_zemlja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_broj;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_proizvodaci;
        private System.Windows.Forms.Label lb_cijepljeni;
    }
}

