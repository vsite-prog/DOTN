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
        Auto a;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            a = new Auto();
            a.Naziv = "Merđo";
            a.Tip = TipVozila.Cestovno;
            lb_auto.Text = a.ToString(); //naša to string metoda
            // Registriraj Eventhandler za naš događaj
            a.boom += autoBoomHandler;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double brzina = Double.Parse(textBox1.Text);
            a.Brzina += brzina;
            lb_auto.Text = a.ToString(); //naša to string metoda
        }

        private void autoBoomHandler (double brzina)
        {
            MessageBox.Show("Brzina: " + brzina.ToString() + " nije dozvoljena", "Booooom", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
