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

        private void button2_Click(object sender, EventArgs e)
        {
            //POkaži tekst koji je unesen
           DialogResult dr =  MessageBox.Show(tb_text.Text,"Uneseno",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
           if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("A šta da raadim...");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Otvaramo drugu formu
            Form2 f2 = new Form2();
            //f2.Show(); //Pokaži me u paraleli
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ovo nije najbolji način Application.Exit();
            this.Close();
        }
    }
}
