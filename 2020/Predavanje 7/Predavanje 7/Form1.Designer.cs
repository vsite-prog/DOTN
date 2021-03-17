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
            this.cb_virus = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_broj = new System.Windows.Forms.TextBox();
            this.tb_drzava = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lb_lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_virus
            // 
            this.cb_virus.FormattingEnabled = true;
            this.cb_virus.Location = new System.Drawing.Point(73, 40);
            this.cb_virus.Name = "cb_virus";
            this.cb_virus.Size = new System.Drawing.Size(389, 24);
            this.cb_virus.TabIndex = 0;
            this.cb_virus.SelectedIndexChanged += new System.EventHandler(this.cb_virus_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj zaraženih:";
            // 
            // tb_broj
            // 
            this.tb_broj.Location = new System.Drawing.Point(194, 102);
            this.tb_broj.Name = "tb_broj";
            this.tb_broj.Size = new System.Drawing.Size(268, 22);
            this.tb_broj.TabIndex = 3;
            // 
            // tb_drzava
            // 
            this.tb_drzava.Location = new System.Drawing.Point(194, 168);
            this.tb_drzava.Name = "tb_drzava";
            this.tb_drzava.Size = new System.Drawing.Size(268, 22);
            this.tb_drzava.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Država:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Početak karantene:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(224, 241);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            // 
            // lb_lista
            // 
            this.lb_lista.AutoSize = true;
            this.lb_lista.Location = new System.Drawing.Point(653, 46);
            this.lb_lista.Name = "lb_lista";
            this.lb_lista.Size = new System.Drawing.Size(46, 17);
            this.lb_lista.TabIndex = 8;
            this.lb_lista.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 505);
            this.Controls.Add(this.lb_lista);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_drzava);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_broj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_virus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_virus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_broj;
        private System.Windows.Forms.TextBox tb_drzava;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lb_lista;
    }
}

