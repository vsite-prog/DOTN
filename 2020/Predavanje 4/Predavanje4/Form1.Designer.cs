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
            this.cb_zemlja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_godina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_napomena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_lista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zemlja:";
            // 
            // cb_zemlja
            // 
            this.cb_zemlja.FormattingEnabled = true;
            this.cb_zemlja.Location = new System.Drawing.Point(144, 45);
            this.cb_zemlja.Name = "cb_zemlja";
            this.cb_zemlja.Size = new System.Drawing.Size(284, 24);
            this.cb_zemlja.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Godina:";
            // 
            // tb_godina
            // 
            this.tb_godina.Location = new System.Drawing.Point(144, 92);
            this.tb_godina.Name = "tb_godina";
            this.tb_godina.Size = new System.Drawing.Size(284, 22);
            this.tb_godina.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Napomena:";
            // 
            // tb_napomena
            // 
            this.tb_napomena.Location = new System.Drawing.Point(144, 142);
            this.tb_napomena.Multiline = true;
            this.tb_napomena.Name = "tb_napomena";
            this.tb_napomena.Size = new System.Drawing.Size(287, 151);
            this.tb_napomena.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_lista
            // 
            this.lb_lista.AutoSize = true;
            this.lb_lista.Location = new System.Drawing.Point(38, 370);
            this.lb_lista.Name = "lb_lista";
            this.lb_lista.Size = new System.Drawing.Size(0, 17);
            this.lb_lista.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 681);
            this.Controls.Add(this.lb_lista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_napomena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_godina);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_zemlja);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_zemlja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_godina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_napomena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_lista;
    }
}

