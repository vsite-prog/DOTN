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
        List<Auto> auti = new List<Auto>();
        public Form1()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unosAutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Skraćeno napisano
            DialogResult dr = (new UnosForm(auti)).ShowDialog();
            //Dodan je novi auto 
            if(dr == DialogResult.OK)
            {
                label1.Text = "";
                foreach (Auto a in auti) //Ispiši sve automobili
                {
                    label1.Text += a.ToString() + "\n";
                }
            }
        }
    }
}
