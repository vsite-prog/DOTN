using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_7
{
    public partial class Form1 : Form
    {
        List<IZoo> pets = new List<IZoo>(); //Svi ljubimci mogu unutra i psi, zmije itd.
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            //Postavi izbor u CBox
            List<string> vrsta = new List<string>() { "Pas", "Hrčak", "Zmija" };
            cb_vrsta.DataSource = vrsta;
            
            button1.Click += (o, a) =>
            {
                //Kreiraj varijablu koja može primiti objekt koji ima interface
                IZoo pet;
                string odabir = cb_vrsta.SelectedItem.ToString();
                switch (odabir)
                {
                    case "Pas":
                        pet = new Pas();
                        break;
                    case "Hrčak":
                        pet = new Hrcak();
                        break;
                    default:
                        pet = new Zmija();
                        break;
                }

                pet.Naziv = tb_naziv.Text;
                //Postavi cijenu , pazi na iznimku
                try
                {
                    pet.PostaviCijenu(Decimal.Parse(tb_cijena.Text));
                } catch( ArgumentOutOfRangeException aex)
                {
                    MessageBox.Show("Loša cijena!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                } //Uhvatiti za vježbu i grešku u parsiranju

                pets.Add(pet);

                //Idemo ovo sortirati, možemo imamo IComparable
                pets.Sort();


                lb_pets.Text = "Ljubimci:";
                //Idemo petljom kroz listu
                foreach(IZoo p in pets)
                {
                    lb_pets.Text += "\n" + " Naziv: " + p.Naziv + " Cijena: " + p.Cijena.ToString();
                    //Idemo vidjeti je li riječ o psu
                    Pas pas = p as Pas; //Ovo je blagi cast, biti će null ako nije uspio
                    if(pas != null)
                        lb_pets.Text += " Sorta: " + pas.Sorta + " Boja: " + pas.Boja.ToString();
                }

            };
        }
    }
}
