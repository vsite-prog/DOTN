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
    public partial class GlavnaForma : Form
    {
        // Spremnik poruka
        List<string> poruke = new List<string>();
        public GlavnaForma()
        {
            InitializeComponent();
        }

        private void GlavnaForma_Load(object sender, EventArgs e)
        {
            // Dodaj dugme po želji
            Button b = new Button();
            b.Text = "Klikni i mene";
            b.Location = new Point(314, 120);
            b.Size = new Size(80, 20);
            b.Click += pokazi_poruku;
            // Ajde dodaj ga formi
            Controls.Add(b);
            tb_unos.Text = "Početni tekst";

            // Default bi bila neka versta sive u Windowsima
            cb_pozadina.SelectedIndex = 0;

        }

        private void pokazi_poruku(object sender, EventArgs e)
        {
            string odgovor;
            DialogResult r = MessageBox.Show("Odaberi da ili ne?", "Odabir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                odgovor = "Da";
            } else
            {
                odgovor = "Ne";
            }
            // Ljepše bi bilo odgovor = r == DialogResult.Yes ? "Da : "Ne;

            MessageBox.Show("Hvala što ste klikli " + odgovor);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Promjeni boju prema odabiru u combu
            string boja = this.cb_pozadina.SelectedItem.ToString(); //this je onako po defaultu i odnosi se na formu
            switch (boja)
            {
                case "Plava":
                    BackColor = Color.Blue;
                    break;
                case "Crvena":
                    BackColor = Color.Red;
                    break;
                case "Zelena":
                    BackColor = Color.Green;
                    break;
                default:
                    BackColor = Color.White;
                    break;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Predavanje 3");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Otvaramo drugu forrmu
            DrugaForma forma = new DrugaForma(poruke); // Pošalji spremnik
            // forma.Show(); Bolje je u modalnom načina
            DialogResult odgovor = forma.ShowDialog();

            if (odgovor == DialogResult.OK)
            {
                MessageBox.Show("Poruka broj: " + poruke.Count + " je: " + poruke.Last<string>());
            }
        }
    }
}
