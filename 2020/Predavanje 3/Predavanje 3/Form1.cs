using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_3
{
    public partial class Form1 : Form
    {
        List<string> studenti = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pročitaj tekst iz kućice
            string uneseno = tb_tekst.Text;
            DialogResult rezultat = MessageBox.Show(uneseno, "Poruka", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (rezultat == DialogResult.No)
            {
                lb_poruka.Text = "Zašto ne!";
            }
        }

        private void b2_click(object sender, EventArgs e)
        {
            DrugaForma f = new DrugaForma(studenti);
            // Idemo unijeti studente
            DialogResult rezultat = f.ShowDialog();
            if (rezultat == DialogResult.OK)
            {
                // Pokaži tog studenta koji je upisan
                string student = studenti.Last<string>();
                lb_poruka.Text = "Zadnji student je: " + student;
            } else
            {
                lb_poruka.Text = "Ništa nije upisano!";
            }
        }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sada bi trebali promijeniti boju pozadine
            string odabranaBoja = cb_boja.SelectedItem.ToString();
            // Sada ćemo vidjeti što treba obojat
            switch (odabranaBoja)
            {
                case "Crvena":
                    BackColor = Color.Red;
                    break;
                case "Plava":
                    BackColor = Color.Blue;
                    break;
                case "Zelena":
                    BackColor = Color.Green;
                    break;
                default:
                    BackColor = Color.Tomato; // U biti je verzija sive, naći na webu
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Idemo kreirti ručno jedno dugme
            Button b = new Button();
            b.Text = "Odi u drugu formu";
            b.Location = new Point(35, 190);
            b.Size = new Size(100, 20);

            // Treba ga dodati u formu
            Controls.Add(b);

            b.Click += b2_click;
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pOrukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Poruka!");
        }
    }
}
