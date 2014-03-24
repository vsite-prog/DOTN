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

        private void button1_Click(object sender, EventArgs e)
        {
            double deltaBrzine = Double.Parse(textBox1.Text);
            //Ubrzaj auto
            a.Brzina += deltaBrzine;

        }
        public void auto_Boom(object sender, EventArgs e)
        {
            //Malo ružno ljepše bi bio exception...
            MessageBox.Show("Brzina nije u intervalu", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kreiraj novi automobil
            a = new Auto();
            // REgistriraj Boom Handler
            a.Boom += auto_Boom;

        }
    }
}
