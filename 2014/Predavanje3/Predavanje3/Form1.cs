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

        public List<string> textovi = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); // zatvori
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_boja.SelectedItem = "default"; //defaultna boja
        }

        private void cb_boja_SelectedIndexChanged(object sender, EventArgs e)
        {
         /*   if (cb_boja.SelectedItem.ToString() == "plava")
                this.BackColor = System.Drawing.Color.Red; idemo sa Case-om  */
            string boja = cb_boja.SelectedItem.ToString();
            switch (boja)
            {
                case "crvena": //korisnik je odabrao
                    this.BackColor = Color.Red; //uključimo using
                    break;
                case "plava":
                    this.BackColor = Color.Blue;
                    break;
                case "zelena":
                    this.BackColor = Color.Green;
                    break;
                default:
                    this.BackColor = SystemColors.Window;
                    break;

            }
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForm forma = new UnosForm(textovi);
            DialogResult dr = forma.ShowDialog();
            if (dr == DialogResult.OK) //Ako je korisnik unio novi txt
            {
                lb_txt.Text = ""; //briši labelu
                foreach (string txt in textovi) //prođi kroz listu
                    lb_txt.Text += "\n" + txt; //prikaži textr u labeli 
            }
        }
    }
}
