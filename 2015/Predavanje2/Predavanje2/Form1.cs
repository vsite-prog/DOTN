using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dobar dan", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kreiramo novu formu ali se još ne vidi
            Form drugaForma = new Form2();
            //Pokreni paralelno
            //drugaForma.Show();

           DialogResult dr =  drugaForma.ShowDialog();
            //Vidi što je vraćeno
           if (dr == System.Windows.Forms.DialogResult.OK)
               MessageBox.Show("Vraćeno je OK");
           else
               MessageBox.Show("Vraćeno je Cacel");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Application.Exit();

            //Zatvora formu
            this.Close();
        }
    }
}
