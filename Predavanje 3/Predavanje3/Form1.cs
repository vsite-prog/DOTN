using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje3
{
    public partial class Form1 : Form
    {
        //spremnik podataka za studente, ide u drugu formu
        List<string> sviStudenti = new List<string>();
        public Form1()
        {
            InitializeComponent();

            //Kreiraj novi button
            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(60, 23);
            button2.Text = "Otvori drugu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(button2_Click);
            this.Controls.Add(button2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Klik!!!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Idemo otvoriti drugu formu
            DrugaForma forma = new DrugaForma();
            // forma.Show(); Ovo nije baš lijepo, možemo biti u obje forme
            DialogResult dr = forma.ShowDialog();
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Obično se koristi za inicijalizaciju elemenata
            lb_load.Text = "Novi tekst!";

            cb_unos.Checked = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("DOTN program \n Predavanje 13 \n verzija 0.1", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Ovo nije poželjno, ubijamo proces
            //Application.Exit();
            this.Close();
       }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string boja = comboBox1.SelectedItem.ToString();
            //Promijeni boju pozadine na odabir
            switch (boja)
            {
                case "Standard":
                    this.BackColor = Color.Gray;
                    break;
                case "Crvena":
                    this.BackColor = Color.Red;
                    break;
                case "Zelena":
                    this.BackColor = Color.Green;
                    break;
                default:
                    this.BackColor = Color.Pink;
                    break;

            }
        }

        private void Unos_CheckedChanged(object sender, EventArgs e)
        {
            drugaFormaToolStripMenuItem.Enabled = cb_unos.Checked;
        }

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Idemo otvoriti drugu formu
            DrugaForma forma = new DrugaForma(sviStudenti);
            // forma.Show(); Ovo nije baš lijepo, možemo biti u obje forme
            DialogResult dr = forma.ShowDialog();
            if(dr == DialogResult.OK)
            {
                //pročitaj iz liste sve studente i prikaži ih u labeli
                lb_load.Text = "Studenti:";
                //prođi pedtljom kroz listu
                foreach(string student in sviStudenti)
                {
                    lb_load.Text += "\n" + student;
                }
            }
        }
    }
}
