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
            this.button1.Text = "Pritisni me";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Pročitaj sadržaj textbox-a
            string txt = textBox1.Text;
            // Sada mi pokaži poruku
            MessageBox.Show(txt, "Upisano", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kreiraj novi objekt forme
            Form2 f = new Form2();
            // Reci windowsima da je prikažu 
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Kreiraj novi objekt forme
            Form2 f = new Form2();
            // Reci windowsima da je prikažu modalnu (kao dijalog)
            f.ShowDialog();
        }
    }
}
