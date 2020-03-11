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
        List<Plovilo> sveStoPlovi = new List<Plovilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unosPlovilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForma f = new UnosForma(sveStoPlovi);
            DialogResult result = f.ShowDialog();
            if(result == DialogResult.OK)
            {
                label1.Text = "PLovila: \n";
                foreach( Plovilo p in sveStoPlovi)
                {
                    label1.Text += p.ToString() + "\n";
                }
            }
        }
    }
}
