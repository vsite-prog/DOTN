using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_5
{
    public partial class Form1 : Form
    {
        //Glup primjer
        string Obradi<T>(T obradie)
        {
            return obradie.ToString();
        }

        List<Auto> sviAutomobili = new List<Auto>();

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
  /*
            a.boom += (s, args) =>
            {
                Auto a = (Auto)s;
                double v = Double.Parse(textBox1.Text) + a.Brzina; //Ovo nije lijepo
                MessageBox.Show("Brzina: " + v.ToString() + " nije dozvoljena", "Booooom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            };
            */
            
            bt_novi.Click += (o, args) =>
            {
                Auto a = new Auto();
                Obradi<Auto>(a); // Nema smisla ali evo kako se generics koriste
                a.Tip = TipVozila.Cestovno;
                a.boom += (s, ar) =>
                {
                    Auto auto = (Auto)s;
                    double v = Double.Parse(textBox1.Text) + auto.Brzina; //Ovo nije lijepo
                    MessageBox.Show("Auto:" + a.Naziv + "\nBrzina: " + v.ToString() + " nije dozvoljena", "Booooom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                };
                //Dodaj ga u generičku listu
                sviAutomobili.Add(a);
                //Neka generička lista bude izvor podataka za combo
                cb_auti.DataSource = null;
                cb_auti.DisplayMember = "Naziv";
                cb_auti.DataSource = sviAutomobili;
            };

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double delta = Double.Parse(textBox1.Text);
            Auto a = (Auto)cb_auti.SelectedItem;
            a.Brzina += delta;
        }

        private void autoBoomHandler (object obj, EventArgs args)
        {
           // MessageBox.Show("Brzina: " + brzina.ToString() + " nije dozvoljena", "Booooom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
