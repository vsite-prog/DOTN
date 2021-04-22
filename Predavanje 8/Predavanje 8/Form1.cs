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
        CoronaDBEntities db = new CoronaDBEntities();
        public Form1()
        {
            InitializeComponent();
            button1.Click += (o, a) =>
            {
                // Spremanje podataka
                Zaraza z = new Zaraza(); // Novi podaci o zarazi
                z.BrojZarezenih = Int32.Parse(tb_zarazeni.Text);
                z.BrojIzlijecenih = Int32.Parse(tb_izlijeceni.Text);
                z.BrojUmrlih = Int32.Parse(tb_umrli.Text);
                z.Drzave = cb_drzava.SelectedItem as Drzave; // U combu su objekti država
                                                             // Sada idemo to i spremiti u bazu podataka
                db.Zaraza.Add(z);
                // Ovo sada nije još u bazi podataka
                db.SaveChanges();
                // Sada je
                // Pokaži podatke u našem gridu
                dgv_corona.DataSource = db.Zaraza.ToList<Zaraza>();
                
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_drzava.DataSource = db.Drzave.ToList<Drzave>(); // Spoji sa listom država iz baze podataka
            cb_drzava.DisplayMember = "Ime";
            // cb_drzava.ValueMember = "Id"; ovo ćemo sami uzeti
        }

    }
}
