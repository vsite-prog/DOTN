using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje5
{
    public partial class Form1 : Form
    {
        Auto a;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Click += (o, args) => { promijeniBrzinu(26.3); };
            a = new Auto();
            //Pretplati me na boom događaj
          /*  ne mogu samo ja imati pravo na događaj 
           * a.boom = promijeniBrzinu;
            a.boom = new Auto.Explodiraj(promijeniBrzinu);
           */
           a.boom += EksplodirajHandler;

            //REagiraj na pozor
           a.pozor += (o, args) =>
           {
               Auto auto = (Auto)o;
               lb_status.Text = "Eksplodirati će, vozite: " + auto.Brzina.ToString() + "km/h!";
           };

            tb_brzina.Text = "0";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            promijeniBrzinu(-25.5);

        }

        void promijeniBrzinu(double delta)
        {
            a.Brzina += delta;
            //Prikaži brzinu
            tb_brzina.Text = a.Brzina.ToString();
        }


        //Ovo je naš event handler za auto, idemo ga iskoristiti
        void EksplodirajHandler(double brzina)
        {
            MessageBox.Show("Boom išli ste čak: " + brzina.ToString() + " na sat!", "Eksplzija", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }
    }
}
