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
    //Ovo je isto tip kao i klasa
    delegate void PrintDelegate(string s);

    public partial class Form1 : Form
    {
        Brod b;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // printaj(tb_unos.Text); Idemo ovo predstaviti kroz delegate
            PrintDelegate d = new PrintDelegate(pisiULabelu);
             d +=  txt => MessageBox.Show("Poruka :" + txt, "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            printaj(d);

        }

        void printaj(PrintDelegate d) //Pazite ovdje ide tip delegate
        {
            //Izvrši dobivenu funkciju
            d(tb_unos.Text);          
        }

        void pisiULabelu(string txt)
        {
            lb_print.Text = txt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Novi brod
            b = new Brod("Nema imena", 1000);
            // Ajde pretplati se na događaj potopa
            b.Potop += txt => MessageBox.Show("Poruka :" + txt, "Print", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.Ukrcano += Double.Parse(tb_ukrcaj.Text);
        }
    }
}
