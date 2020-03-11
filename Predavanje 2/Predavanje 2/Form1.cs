using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button button2 = new System.Windows.Forms.Button();

            button2.Location = new System.Drawing.Point(400, 226);
            button2.Name = "button1";
            button2.Size = new System.Drawing.Size(100, 37);
            button2.TabIndex = 0;
            button2.Text = "Zatvori i mene";
            button2.UseVisualStyleBackColor = true;

            Controls.Add(button2);

            // 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Doviđenja!");
            // Application.Exit(); Nemojte ovo raditi, nasilno
            //  Bolje ovako
            this.Close(); // Može i bez this
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DrugaForma druga = new DrugaForma();
            // Otvorili smo je paralelno? druga.Show();
            DialogResult rezultat = druga.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                MessageBox.Show("Hvala što ste pristali!");
            }
            else
            {
                MessageBox.Show("Zašto niste OKali!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
