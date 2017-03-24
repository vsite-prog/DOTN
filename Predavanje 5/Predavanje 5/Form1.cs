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
        //Globalna Varijabla
        Avion avion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            avion = new Avion("Strelko", 679.5);
            //registriraj me na događaj
            avion.crash += CrashPoruka;
        }

        //Ovo je event handler, procedura događaja
        void CrashPoruka( double brzina)
        {
            MessageBox.Show("Crash, brzina je trebala biti: " + brzina.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IspisDelegate del1 = mbox;
            //ili s lambdom
            del1 = txt => { MessageBox.Show(txt); };
            //MessageBox ispis
            avion.Ispisi(del1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IspisDelegate del1 = labela;
            //ili
            del1 = txt => { label1.Text = txt; };
            //Label ispis
            avion.Ispisi(del1);
        }

        //naša lokalna funkcija
        void labela(string txt)
        {
            label1.Text = txt;
        }

        void mbox(string txt)
        {
            MessageBox.Show(txt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Multicasting
            IspisDelegate del1 = labela;
            del1 += txt => { MessageBox.Show(txt); };
            //Isppisi sve
            avion.Ispisi(del1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            avion.Brzina += Double.Parse(textBox1.Text);
        }
    }
}
