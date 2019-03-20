using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_5
{
    // Ovo je tip delegat
    public delegate void PraznoStringDelegat(string s);
    public partial class Form1 : Form
    {
        Raketa r; // Naša raketa
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // neću direktno pisati u labelu već ću aktivirati delegat
            PraznoStringDelegat mojDelegat = new PraznoStringDelegat(PisiULabelu);

            // Kraći način kreiranja delegata
            // PraznoStringDelegat mojDelegat2 = PisiULabelu2;

            // mojDelegat = mojDelegat + mojDelegat2; ili kraće

            mojDelegat += PisiULabelu2;

            mojDelegat += PisiULabelu2;
            mojDelegat -= PisiULabelu2;

            /* Ovo je anonimna funkcija ali bolje ovo riješiti lambdom
            PraznoStringDelegat mojDelegat2 = delegate (string txt) {
                MessageBox.Show(txt, "Prikaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
            */

            mojDelegat += txt => MessageBox.Show(txt, "Prikaz", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) ;
            // sad ga aktiviraj
            mojDelegat(tb_tekst.Text);


        }

        // Ovo nam treba za poziv delegata
        void PisiULabelu(string txt)
        {
            lb_rezultat.Text = txt;
        }

        // Ovo nam treba za poziv delegata
        void PisiULabelu2(string txt)
        {
            lb_rezultat.Text += "\nEvo i dodatno: " + txt;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Idemo lansirati raketu
            r = new Raketa();
            r.Brzina = 100;
            r.MaxBrzina = 1000; // Iznad ovoga se raspada
            // Ajde u formi uhvati kreš event i daj neku poruku
            r.Crash += brzina => MessageBox.Show(brzina.ToString(), "Craaaaaash", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Ubrzaj raketu
            r.Brzina += Double.Parse(tb_brzina.Text);
        }
    }
}
