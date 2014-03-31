using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje6
{
    public partial class Form1 : Form
    {
        List<Auto> sviAuti = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto a = new Auto();
            a.Pozor += PorukaPozor;
            a.Boom += (o, args) => { MessageBox.Show("Auto Boom"); };
            a.vlasnik = Vlasnistvo.Tvrtka;
            a.Registracija = tb_reg.Text;
            a.Brzina = Double.Parse(tb_brzina.Text);
            sviAuti.Add(a);
        }
        private void PorukaPozor(object o, EventArgs args)
        {
            Auto aut1 = (Auto) o;
            //Pokaži poruku o pregrijavanju
            MessageBox.Show("Auto ide prebrzo: " + aut1.Brzina.ToString());
        }
    }
}
