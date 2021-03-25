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
    public partial class Form1 : Form
    {
        Cjepivo cjepivo;

        // Tip delegata za zbroji
        delegate int Operacija(int x, int y);
        delegate void Pisanje(string s);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cjepivo = new Cjepivo();
            cjepivo.Naziv = "Astra Zeneca";
            // Sada ćemo prijaviti i metodu obrade događaja
            cjepivo.NestaloCjepiva += s => MessageBox.Show(s, "Nestalo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            // Ako se ne registraramo ništa se ne dešava
            cjepivo.JosMaloPaNestaloCjepiva += s => MessageBox.Show(s, "Još malo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Idemo računati preko delegata
            Operacija o = new Operacija(zbroji);
            o = oduzmi; // Jednostavniji način pisanja


            string rezultat = o(Int32.Parse(tb_a.Text), Int32.Parse(tb_b.Text)).ToString();

            // Delegat koji negdje piše dobiveni tekst
            Pisanje p = delegate (string s) { label1.Text = s; }; // Imam novu anonimnu metodu koja nigdje drugdje ne postoji
            p += s => MessageBox.Show("Rezultat je: " + s); // Lambda anonimna funkcija
            p(rezultat);

            // Kraći prikaz sa lambdom, samo ilustracija
            racunaj((a, b) => a + b);
            racunaj((a, b) => a * b);
        }

        void racunaj(Operacija o)
        {
            // Sada bi nesto radili u ovoj funkciji sa dobivenom metodom
        }

        int zbroji(int a, int b)
        {
            return a + b;
        }

        int oduzmi(int a, int b)
        {
            return a - b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double kolicina;
            if(! Double.TryParse(tb_kolicina.Text, out kolicina)) // Vidi da li je broj
            {
                MessageBox.Show("Greška u parsu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                cjepivo.Kolicina += kolicina;
            }
            
        }
    }
}
