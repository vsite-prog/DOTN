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
        List<IArtikl> ducan = new List<IArtikl>();
        public Form1()
        {
            InitializeComponent();
            cb_artikl.DataSource = new List<string>() { "Mlijeko", "Kruh", "Novine" };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IArtikl artikl;
            switch (cb_artikl.SelectedItem.ToString())
            {
                case "Mlijeko":
                    Mlijeko m = new Mlijeko();
                    m.Litara = 1;
                    artikl = m; // Type safety
                    break;
                case "Kruh":
                    artikl = new Kruh();
                    break;
                default:
                    artikl = new Novine();
                    break;
            }

            // Bez obzira je li mlijeko, kruh ili nešto treće
            artikl.PostaviCijenu(Decimal.Parse(tb_cijena.Text));
            artikl.Naziv = tb_naziv.Text;

            ducan.Add(artikl);
            // Dodao novi artikl ajde poredeaj ih po cijeni, ali samo radi za liste koji imaju IComparable 
            ducan.Sort();

            lb_ducan.Text = "Lista artikala u dućanu:";
            // I sad kada si dodao, samo to prikaži u labeli
            foreach (IArtikl a in ducan)
            {
                lb_ducan.Text += PrikaziArtikl(a);
            }
        }

        string PrikaziArtikl (IArtikl artikl)
        {
            string retStr = String.Format("\nNaziv: {0} Cijena: {1}", artikl.Naziv, artikl.Cijena);
            // Ako je mlijeko prikaži i litre
            // Da bi to mogao cast-ati ću ga u Mlijeko
            // Nećemo ovako Mlijeko m = (Mlijeko)artikl;
            Mlijeko m = artikl as Mlijeko;
            // Nema exceptiona ako cast ne ide već samo ostaje null vrijednost
            if (m != null)
            {
                retStr += " Litara: " + m.Litara.ToString();
            }
            return retStr;
        }
    }
}
