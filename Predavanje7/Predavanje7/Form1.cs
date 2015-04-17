using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje7
{
    public partial class Form1 : Form
    {
        Tigar tigar = new Tigar();
        Slon slon = new Slon();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IZivotinja z = vratiZivotinju();
            z.promijeniTezinu(Double.Parse(tb_tezina.Text));
            label1.Text = "Težina: " + z.vratiTezinu().ToString();
        }

        IZivotinja vratiZivotinju(){
            if (comboBox1.SelectedItem.ToString() == "Tigar")
                return tigar as IZivotinja;
            else
                return slon;
        }

    }
}
