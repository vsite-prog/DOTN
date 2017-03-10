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
        List<ILjubimac> ljubimci = new List<ILjubimac>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ILjubimac ljubimac;
            //Kreiraj novu životinju u pet shopu
            switch (cb_tip.SelectedItem.ToString())
            {
                case "Pas":
                    ljubimac = new Pas();
                    break;
                case "Mačka":
                    ljubimac = new Macka();
                    break;
                default:
                    ljubimac = new Ribica();
                    break;
            }
            ljubimac.Naziv = tb_naziv.Text;
            ljubimac.PostaviCijenu(Decimal.Parse(tb_cijena.Text));
            ljubimac.Opis = tb_opis.Text;

            Pas p = ljubimac as Pas; //as stavlja null ako cast nije uspio
            if (p != null)
                MessageBox.Show("Hello psu: " + p.Naziv);
            else
                MessageBox.Show("Nije pas: " + ljubimac.Naziv);

            ljubimci.Add(ljubimac);
            //Sortiraj mi preko ICOMPERABLE
            ljubimci.Sort();
            lb_petshop.Text = "Životinje:\n";
            foreach(ILjubimac l in ljubimci)
            {
                lb_petshop.Text += l.Naziv + " " + l.DajCijenu().ToString() + "Kn\n";
     
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
