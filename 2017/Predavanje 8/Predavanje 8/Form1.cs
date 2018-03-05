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
        //daj mi ručku na bazu da mogu raditi s njom
        PsiEntities baza = new PsiEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Evo što se prikazuje a evo što se pamti
            cb_vrsta.DisplayMember = "Naziv";
            cb_vrsta.ValueMember = "id";
            //Neka ti tablica iz baze bude izvor podataka
            cb_vrsta.DataSource = baza.Vrsta.ToList<Vrsta>();

            //Prikaži pse u GView-u
            prikaziPse();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Kreiraj novog psa prema zahtjevu
            Pas pas = new Pas();
            //Postavi naziv iz TB-a
            pas.Naziv = tb_pas.Text;
            //Vidi u Combo kojoj vrsti pripada
            pas.Vrsta = (Vrsta)cb_vrsta.SelectedItem;
            //Ovo još nije stavljeno u tablicu
            baza.Pas.Add(pas);
            //Još nije spremljeno u bazu, idemo
            baza.SaveChanges();
            //Prikaži pse
            prikaziPse();

        }

        void prikaziPse()
        {
            dgv_psi.DataSource = baza.Pas.ToList<Pas>();
        }
    }
}
