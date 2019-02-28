using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pročitaj što je trenutno upisano
            string unos = tb_unos.Text;
            MessageBox.Show("Unijeli ste: " + unos, "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void oProgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prvi program v1.0", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void drugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Druga form = new Druga();
            form.Show();
        }

        private void drugaModalnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Druga form = new Druga();
            form.ShowDialog();
        }
    }
}
