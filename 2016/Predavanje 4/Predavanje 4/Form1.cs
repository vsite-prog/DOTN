using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_4
{
    public partial class Form1 : Form
    {
        List<Auto> automobili = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto a = new Auto(245);
            a.Naziv = tb_naziv.Text;
            TipVozila tip;
            if (Enum.TryParse<TipVozila>(cb_tip.Text, out tip))
            {
                a.Tip = tip;
            };

            a.Brzina = Double.Parse(tb_brzina.Text);
            //a.Tip = TipVozila.Cestovno; uesi kroz combo box
            if (a.Brzina == 0)
                return;
            automobili.Add(a);

            prikaziAute();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_tip.DataSource = Enum.GetNames(typeof(TipVozila));
        }

        private void prikaziAute()
        {
            lb_auti.Text = "Vozila:";
            foreach( Auto a in automobili)
            {
                lb_auti.Text += "\n NAziv: " + a.Naziv + " brzina: " + a.Brzina.ToString() + " tip: " + a.Tip.ToString();
            }
        }
    }
}
