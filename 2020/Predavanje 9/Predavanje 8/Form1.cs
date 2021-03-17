using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_8
{
    public partial class Form1 : Form
    {
        // Kreiraj poveznicu na bazu
        Entities baza = new Entities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Spoji se na bazu i pročitaj objekte država
            cb_drzava.DataSource = baza.Drzave.ToList<Drzave>();
            cb_drzava.ValueMember = "Id";
            cb_drzava.DisplayMember = "Naziv"; // Prikaži u Combu

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Spremamo ono što je uneseno
            Slucajevi slucaj = new Slucajevi();
            slucaj.BrojZarazenih = Int32.Parse(tb_zarazeni.Text); // Bolje sa TryParse
            slucaj.BrojUmrlih = Int32.Parse(tb_umrli.Text);
            slucaj.BrojIzlijecenih = Int32.Parse(tb_ozdravljeni.Text);
            // Pročitaj mi iz Comba Državu
            slucaj.Drzave = (Drzave)cb_drzava.SelectedItem;
            // sada idemo spremiti u bazu
            baza.Slucajevi.Add(slucaj);
            // Ajde sada spremi u bazu
            baza.SaveChanges();
            // Ajde sad prikaži listu svih slučajeva u Gridu
            // Idemo sada po državama gv_slucajevi.DataSource = baza.Slucajevi.ToList<Slucajevi>();
            prikazi_slucajeve();
        }

        private void cb_drzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikazi_slucajeve();
        }

        void prikazi_slucajeve()
        {
            // Dohvati selektiranu državu kako bi prikazali njene slučajeve
            Drzave drzava = (Drzave)cb_drzava.SelectedItem;
            int drzavaId = drzava.Id;
            // LINQ ima dva načina
            // Prvi liči na standardi C# model
            /*
            var slucajevi = baza.Slucajevi
                .Where(s => s.DrzavaId == drzavaId)
                .ToList();
            */
            var slucajevi = from s in baza.Slucajevi
                            join d in baza.Drzave
                            on s.DrzavaId equals d.Id
                            where s.DrzavaId == drzavaId
                            select new { Zaraženi=s.BrojZarazenih, Umrli=s.BrojUmrlih, Izliječeni=s.BrojIzlijecenih, Država = d.Kratica };

            gv_slucajevi.DataSource = slucajevi.ToList();
        }

        private void pregledniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PreglednikForma forma = new PreglednikForma();
            forma.ShowDialog();
        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
