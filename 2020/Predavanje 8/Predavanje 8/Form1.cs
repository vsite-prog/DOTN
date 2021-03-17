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
            gv_slucajevi.DataSource = baza.Slucajevi.ToList<Slucajevi>();
        }
    }
}
