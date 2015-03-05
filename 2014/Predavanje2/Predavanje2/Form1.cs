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
            //kreiran objekt nove forme
            Form2 forma = new Form2();
            //forma.Show();
            //Pokaži modalno
            DialogResult res =  forma.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Kliknuli ste OK", "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
