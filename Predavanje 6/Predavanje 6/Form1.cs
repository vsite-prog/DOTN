using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_6
{
    public partial class Form1 : Form
    {
        //Idemo generička lista
        List<Avion> sviAvioni = new List<Avion>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Sad smo definirali ono što je bilo u designer-u
            button1.Click += (o, args) => //Lambda je zgodna ovdje
            {
                ((Button)o).Text += "b";

                Greska<string>("Alo");
                Greska<int>(25);
                Greska<double>(3.3);
            };

            bt_spremi.Click += (o, a) =>
            {
                Avion avion = new Avion();
                avion.Naziv = tb_naziv.Text;
                avion.Brzina = Double.Parse(tb_brzina.Text);

                avion.Paaadam += (s, args)=>{
                    Avion av = (Avion)s;  //objekt koji je okinuo događaj
                    Greska<Avion>(av);

                };

                sviAvioni.Add(avion);
                cb_avioni.DataSource = null; //resetiraj combo
                cb_avioni.DataSource = sviAvioni; //prikaži listu
                cb_avioni.DisplayMember = "Naziv";



            };

            bt_ubrzaj.Click += (o, a) =>
            {
                //Ubrzaj avion selektiran u combu
                Avion avion = (Avion)cb_avioni.SelectedItem;
                avion.Brzina += 100;
            };
        }

        /*
        private void button1_Click(object sender, EventArgs e)
        {
            //ZAboravimo ovo idemo ovo riješiti lambdom
            //Dodajte slovo a na svaki klik buttona
            Button b = (Button)sender;
            b.Text += "a";
        }
        */

       //ja ću biti generic pa primam bilo što
        void Greska<T>(T par)
        {
            MessageBox.Show("Greška: " + par.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
