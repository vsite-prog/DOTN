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
        // Globalna varijabla
        Entities db;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ovo je kontekst baze podataka
            db = new Entities();

            prikaziKlubove();

            cb_lige.DataSource = db.Liga.ToList<Liga>();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Spremi Novi klub
            Klub klub = new Klub();
            klub.Naziv = tb_naziv.Text;
            klub.Pozicija = Int32.Parse(tb_pos.Text);
            klub.BrojBodova = Int32.Parse(tb_bodovi.Text);
            // Iz koje je lige klub
            klub.Liga = (Liga)cb_lige.SelectedItem;
            // Sad ga konačno spremi
            db.Klub.Add(klub);
            // Nije još spremljen
            db.SaveChanges();
            // Sada je, ažuriraj grid
            prikaziKlubove();
        }

         void prikaziKlubove()
        {
            // Idemo se spojiti na tablicu i prikazati podatke
            dgv_klubovi.DataSource = db.Klub.ToList<Klub>();
        }
    }
}
