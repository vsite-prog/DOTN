using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_9
{
    public partial class Form1 : Form
    {
        // Baza 
        CoronaDBEntities db = new CoronaDBEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_drzava.DataSource = db.Drzave.ToList<Drzave>();
            cb_drzava.DisplayMember = "Ime";
            cb_drzava.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zaraza zaraza = new Zaraza();
            zaraza.BrojZarezenih = Int32.Parse(tb_zarazeni.Text);
            zaraza.BrojUmrlih = Int32.Parse(tb_umrli.Text);
            zaraza.BrojIzlijecenih = Int32.Parse(tb_izlijeceni.Text);
            // Državu možemo dodati kao id ili kao objekt Drzave
            zaraza.Drzave = (Drzave)cb_drzava.SelectedItem;
            // Dodaj
            db.Zaraza.Add(zaraza);

            // Idi sa SQLom u bazu
            db.SaveChanges();

            // Napuni grid sa podacima
            // dgv_corona.DataSource = db.Zaraza.ToList<Zaraza>(); 

          
            prikazi_podatke();
        }

        private void cb_drzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikazi_podatke();
        }



        void prikazi_podatke() {
            // Idemo sa Linq
            // Pročitaj koj aje država odabrana
            Drzave d = (Drzave)cb_drzava.SelectedItem;
            int drzavaId = d.Id; // Ova kolona je value u combo boxu pa smo mogli i kraće to napisati
                                 // Filtritaj po državi
            /*
             * Isto LINQ
            var zaraze = db.Zaraza
                .Where(z => z.DrzavaId == drzavaId)
                .ToList();
            */
            var zaraze = (
                         from z in db.Zaraza
                         where z.DrzavaId == drzavaId
                         select new {   Zaraženi = z.BrojZarezenih,
                                        Umrli = z.BrojUmrlih,
                                        Izliječeni = z.BrojIzlijecenih,
                                        Opis_Države = z.Drzave.Opis
                                     }
            ).ToList();

           dgv_corona.DataSource = zaraze;
        }

        private void preglednikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm forma = new BrowserForm();
            forma.ShowDialog();
        }
    }
}
