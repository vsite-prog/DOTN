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
        NbaEntities baza = new NbaEntities(); //Referenca na baza
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Hoću spremiti Igrača, ništa SQL samo EF
            Igrac igrac = new Igrac();
            igrac.ime = tb_ime.Text;
            //Ne možemo staviti text jer se pazi na tip podataka
            igrac.vrijednost = Int32.Parse(tb_vrijednost.Text);
            // igrac.klubId = neki broj; nećemo ovako koristimo property klub
            Klub klub = (Klub)cb_klubovi.SelectedItem;
            //Dajem mu referencu na objekt a on će uzeti samo id
            igrac.Klub = klub;

            //Ovo treba spremiti
            baza.Igrac.Add(igrac);
            //Još nije spremljeno, samo je označena promjena
            baza.SaveChanges();
            //Prikaži igrače
            prikazi();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Želim postaviti klubove u combo
            cb_klubovi.DataSource = baza.Klub.ToList<Klub>();
            //POstavke CBox-a
            cb_klubovi.DisplayMember = "ime";
            cb_klubovi.ValueMember = "id";
            //Prikaži igrače
            prikazi();
            

        }

        void prikazi()
        {
            //Daj mi sve što imaš u kolekciji igrača
            //dgv_igraci.DataSource = baza.Igrac.ToList<Igrac>();
            //Nećemo prikazati sve nego samo igrače jednog kluba
            //Idemo s LINQ-om
            //prvo moramo naći selektirani klub
            //Klub klub = (Klub)cb_klubovi.SelectedItem; treba nam id da bi LINQ radio
            int klubId = ((Klub)cb_klubovi.SelectedItem).id;
            //i sada lista igrača..
            var igraci = from igrac in baza.Igrac
                         where igrac.klubId == klubId
                         select new { Ime = igrac.ime, Vrijednost = igrac.vrijednost };
            //Prikaži 
            dgv_igraci.DataSource = igraci.ToList();
        }

        private void zbogomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void browserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BrowserForm browserForm = new BrowserForm();
            browserForm.ShowDialog();
        }

        private void cb_klubovi_SelectedIndexChanged(object sender, EventArgs e)
        {
            prikazi();
        }
    }
}
