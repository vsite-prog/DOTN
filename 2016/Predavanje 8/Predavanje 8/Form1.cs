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
        KladionicaEntities db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kreiraj novi par u odabranoj kladionici
            Parovi par = new Parovi();
            par.naziv = tb_naziv.Text;
            par.koeficijent = Double.Parse(tb_koeficijent.Text);
            par.klad_id = (int)comboBox1.SelectedValue;
            //Sad spremi u bazu
            db.Parovi.Add(par);
            //Ovdje je bio problem, Tracker nije pratio promjene...
            db.ChangeTracker.DetectChanges();
            //Sad stvarnmo spremi
            db.SaveChanges();
            prikaziGrid();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Definiraj što treba prikazati u combobox-u
            comboBox1.DisplayMember = "naziv";
            comboBox1.ValueMember = "id";
            db = new KladionicaEntities(); //Kreiraj kontekst baze

            //POstavi izvor podataka za ComboBox
            comboBox1.DataSource = db.Kladionica.ToList<Kladionica>();
            //prikaziGrid();
        }

        void prikaziGrid()
        {
            int kladionica_id = (int)comboBox1.SelectedValue;
            var lista = (from par in db.Parovi
                        where par.klad_id == kladionica_id
                        select new { Naziv = par.naziv, Koeficijent = par.koeficijent } ).ToList();

            dataGridView1.DataSource = lista;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikaziGrid();
        }
    }
}
