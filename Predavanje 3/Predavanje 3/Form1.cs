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
            string unos = tb_unos.Text;
            MessageBox.Show(unos, "Povik",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kreiraj novi element kroz kod kao što se radi u designer
            Button b = new Button();
            //Gdje je na formi
            b.Location = new Point(60, 60);
            //Veličina
            b.Size = new Size(60, 30);
            b.Text = "Test";
            //Dodaj proceduru događaja
            b.Click += test_Click;

            //A sada ga dodaj u formu
            this.Controls.Add(b);

            //POstavi standardnu boju
            cb_boja.SelectedIndex = 0;

            //Dozvoli unos
            cb_unos.Checked = true;
        }

        private void test_Click(object sender, EventArgs e)
        {
            MessageBox.Show("testing");
        }

        private void cb_boja_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Idemo postaviti boju pozadine
            string boja = cb_boja.SelectedItem.ToString();
            //Switch naredba
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

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos forma = new Unos(studenti);
            //Idemo vidjeti kako smo se vratili 
            DialogResult dr = forma.ShowDialog();
            //Ako je unesen novi ispiši u labeli
            if (dr == DialogResult.OK)
            {
                foreach(string s in studenti)
                {
                    lb_studenti.Text += s + "\n";
                }
            }
        }

        private void cb_unos_CheckedChanged(object sender, EventArgs e)
        {
            //Ovisno cboxu hajde dozvoli unos studenata
            drugaFormaToolStripMenuItem.Enabled = cb_unos.Checked;
        }
    }
}
