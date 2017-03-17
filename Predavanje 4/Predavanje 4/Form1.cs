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
            this.Close();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForm form = new UnosForm(auti);
            DialogResult dr = form.ShowDialog();
            if (dr== DialogResult.OK)
            {
                lb_auti.Text = "Lista automobila:";
                //idi auto po auto i upiši ga u labelu
                foreach (Auto a in auti)
                {
                    lb_auti.Text += "\n" + a.ToString();
                }
            }
        }
    }
}
