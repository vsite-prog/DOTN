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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_klubovi = new System.Windows.Forms.ComboBox();
            this.tb_ime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_vrijednost = new System.Windows.Forms.TextBox();
            this.dgv_igraci = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klub:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_klubovi
            // 
            this.cb_klubovi.FormattingEnabled = true;
            this.cb_klubovi.Location = new System.Drawing.Point(105, 29);
            this.cb_klubovi.Name = "cb_klubovi";
            this.cb_klubovi.Size = new System.Drawing.Size(121, 21);
            this.cb_klubovi.TabIndex = 2;
            // 
            // tb_ime
            // 
            this.tb_ime.Location = new System.Drawing.Point(105, 67);
            this.tb_ime.Name = "tb_ime";
            this.tb_ime.Size = new System.Drawing.Size(121, 20);
            this.tb_ime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ime igrača:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vrijednost:";
            // 
            // tb_vrijednost
            // 
            this.tb_vrijednost.Location = new System.Drawing.Point(105, 104);
            this.tb_vrijednost.Name = "tb_vrijednost";
            this.tb_vrijednost.Size = new System.Drawing.Size(121, 20);
            this.tb_vrijednost.TabIndex = 6;
            // 
            // dgv_igraci
            // 
            this.dgv_igraci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_igraci.Location = new System.Drawing.Point(268, 29);
            this.dgv_igraci.Name = "dgv_igraci";
            this.dgv_igraci.Size = new System.Drawing.Size(505, 362);
            this.dgv_igraci.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_igraci);
            this.Controls.Add(this.tb_vrijednost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ime);
            this.Controls.Add(this.cb_klubovi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_igraci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_klubovi;
        private System.Windows.Forms.TextBox tb_ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_vrijednost;
        private System.Windows.Forms.DataGridView dgv_igraci;
    }
}

