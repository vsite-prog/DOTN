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
            this.dgv_klubovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_naziv = new System.Windows.Forms.TextBox();
            this.tb_pos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bodovi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_lige = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klubovi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_klubovi
            // 
            this.dgv_klubovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_klubovi.Location = new System.Drawing.Point(52, 33);
            this.dgv_klubovi.Name = "dgv_klubovi";
            this.dgv_klubovi.Size = new System.Drawing.Size(721, 283);
            this.dgv_klubovi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv:";
            // 
            // tb_naziv
            // 
            this.tb_naziv.Location = new System.Drawing.Point(144, 378);
            this.tb_naziv.Name = "tb_naziv";
            this.tb_naziv.Size = new System.Drawing.Size(160, 20);
            this.tb_naziv.TabIndex = 2;
            // 
            // tb_pos
            // 
            this.tb_pos.Location = new System.Drawing.Point(144, 417);
            this.tb_pos.Name = "tb_pos";
            this.tb_pos.Size = new System.Drawing.Size(160, 20);
            this.tb_pos.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 420);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "POzicija:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tb_bodovi
            // 
            this.tb_bodovi.Location = new System.Drawing.Point(147, 458);
            this.tb_bodovi.Name = "tb_bodovi";
            this.tb_bodovi.Size = new System.Drawing.Size(160, 20);
            this.tb_bodovi.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bodovi:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Liga:";
            // 
            // cb_lige
            // 
            this.cb_lige.FormattingEnabled = true;
            this.cb_lige.Location = new System.Drawing.Point(144, 341);
            this.cb_lige.Name = "cb_lige";
            this.cb_lige.Size = new System.Drawing.Size(160, 21);
            this.cb_lige.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.cb_lige);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_bodovi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_naziv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_klubovi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_klubovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_klubovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_naziv;
        private System.Windows.Forms.TextBox tb_pos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bodovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_lige;
    }
}

