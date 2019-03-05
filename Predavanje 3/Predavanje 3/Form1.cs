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
        List<string> lista = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pročitaj tekst iz TB-a
            string tekst = tb_ponovi.Text;
            // Pokaži nam popup, nije baš pametno ali nema veze
            MessageBox.Show(tekst, "Megafon", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Idemo kreirati još jedan button, do prvoga koji je identičan
            Button b = new Button();
            // Veličina ovog dugmeta, neka bude isti
            b.Size = new Size(75, 23);
            // Gdje se nalazi
            b.Location = new Point(440, 28);
            // Text promijeniti
            b.Text = "Opet ponovi";
            // Trebalo bi ga pokazati na formi
            this.Controls.Add(b);
            // neka izvrši istu proceduru kao i prvi
            b.Click += button1_Click;

            cb_pozadina.SelectedIndex = 3;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Nova boja
            string boja = cb_pozadina.SelectedItem.ToString();
            // Promijeni pozadinu
            switch (boja)
            {
                case "Crvena":
                    this.BackColor = Color.Red;
                    break;
                case "Plava":
                    this.BackColor = Color.Blue;
                    break;
                case "Zelena":
                    this.BackColor = Color.Green;
                    break;
                default:
                    this.BackColor = SystemColors.Window;
                    break;

            }
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MegafonForma forma = new MegafonForma(lista);
            // Prikaži je u modalnom načinu
            DialogResult rezultat = forma.ShowDialog();
            // Ako je potvrdio prikaži messagebox, ako ne, ništa
            if(rezultat == DialogResult.OK)
            {
                MessageBox.Show(lista.Last<string>(), "Megafon", MessageBoxButtons.YesNo, MessageBoxIcon.Stop); ;
            }
        }
    }
}
