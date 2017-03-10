using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_2_
{
    public partial class Prva : Form
    {
        public Prva()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = tb_unos.Text;
            //Idemo ovo prikazati korisniku
            MessageBox.Show(txt);
        }

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Kreiraj novu formu
            Druga forma = new Druga();
            //Ne vidi se još, idemo je prikazati
            forma.Show();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
