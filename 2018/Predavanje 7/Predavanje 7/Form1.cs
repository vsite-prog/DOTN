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
        List<ILjubimac> ljubimci;
        public Form1()
        {
            InitializeComponent();
            ljubimci = new List<ILjubimac>();
            //Idemo napuniti Combo
            cb_vrsta.DataSource = new List<string>() {"Pas", "Mačka" , "Ribica"};
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILjubimac lj;
            // ovo ne ide, treb anam klasa ILjubimac lj = new ILjubimac();
            switch (cb_vrsta.SelectedItem.ToString())
            {
                case "Pas":
                    lj = new Pas();
                     break;
                case "Mačka":
                    lj = new Macka();
                    break;
                default: //Zato da smo sigurni da je lj postavljen
                    lj = new Ribica();
                    break;
            }
            //Tko god bio, idemo ga postaviti
            lj.Ime = tb_ime.Text;
            try //bacamo exception pa bi ga trebalo i uhvatiti
            {
                lj.PostaviCijenu(Decimal.Parse(tb_cijena.Text));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("Cijena nije OK");
                return;
            }

            ljubimci.Add(lj);

            //Sortirtaj listu
            ljubimci.Sort();


            //Mogli bi ih sada i prikazati
            lb_ljubimci.Text = "Ljubimci:";
            foreach(ILjubimac ljubimac in ljubimci)
            {
                lb_ljubimci.Text += "\n" + ljubimac.Ispisi();
                //Htio bih i pasminu
                Pas p = ljubimac as Pas; //Ako ovo nije pas imati ćemo null
                if (p != null)
                {
                    lb_ljubimci.Text += "pasmina : " + p.Pasmina;
                }
            }
        }
    }
}
