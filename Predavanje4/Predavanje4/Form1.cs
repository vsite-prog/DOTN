using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje4
{
    public partial class Form1 : Form
    {
        List<Zivotinja> sveZivotinje = new List<Zivotinja>();
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_spremi_Click(object sender, EventArgs e)
        {
            ZOO zoo;
            Vrsta vrsta;

            /* proglasili smo živ. abstraktnom i nema više
            Zivotinja z = new Zivotinja();
            z.Ime = tb_ime.Text;
            //Pričotaj iz cb-a i upiši u lokalnu var
            Enum.TryParse<ZOO>(cb_zoo.SelectedItem.ToString(), out zoo );
            z.Zoo = zoo;
            Enum.TryParse<Vrsta>(cb_vrsta.SelectedItem.ToString(), out vrsta);
            z.Vrsta = vrsta;

            sveZivotinje.Add(z);
             * */
            Lav lav = new Lav();
            lav.Ime = tb_ime.Text;
            lav.Tezina = Double.Parse(tb_tezina.Text); //Bilo bi bolje TRy Parse
            lav.Brzina = Double.Parse(tb_brzina.Text);

            Enum.TryParse<ZOO>(cb_zoo.SelectedItem.ToString(), out zoo);
            lav.Zoo = zoo;
            sveZivotinje.Add(lav);

            prikaziZivotinje();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //POstavi vrijednosti za CB 
           // cb_vrsta.DataSource = Enum.GetValues(typeof(Vrsta));
            cb_zoo.DataSource = Enum.GetValues(typeof(ZOO));
        }

        void prikaziZivotinje()
        {
            label4.Text = "";
            foreach (Lav l in sveZivotinje)
            {
                label4.Text += l.ToString() + "\n";
            }
        }
    }
}
