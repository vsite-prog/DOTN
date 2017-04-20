namespace Predavanje_8
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
            this.cb_vrsta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_psi = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_psi)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_vrsta
            // 
            this.cb_vrsta.FormattingEnabled = true;
            this.cb_vrsta.Location = new System.Drawing.Point(125, 36);
            this.cb_vrsta.Name = "cb_vrsta";
            this.cb_vrsta.Size = new System.Drawing.Size(184, 21);
            this.cb_vrsta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vrsta psa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv psa:";
            // 
            // tb_pas
            // 
            this.tb_pas.Location = new System.Drawing.Point(422, 33);
            this.tb_pas.Name = "tb_pas";
            this.tb_pas.Size = new System.Drawing.Size(174, 20);
            this.tb_pas.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Spremi novog psa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_psi
            // 
            this.dgv_psi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_psi.Location = new System.Drawing.Point(49, 148);
            this.dgv_psi.Name = "dgv_psi";
            this.dgv_psi.Size = new System.Drawing.Size(547, 243);
            this.dgv_psi.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 403);
            this.Controls.Add(this.dgv_psi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_vrsta);
            this.Name = "Form1";
            this.Text = "Psi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_psi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_vrsta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_psi;
    }
}

