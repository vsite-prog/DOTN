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
    public partial class Form2 : Form
    {
        int brojac;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brojac++;
            label1.Text = "kLIKNULI STE " + brojac.ToString() + ". put!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "Kliknuli ste 0. puta!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Zatvori formu i vrato odgovarajući rezult.
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Zatvori formu i vrato odgovarajući rezult.
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
