using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUnos forma = new FormUnos();
            forma.ShowDialog();
        }
    }
}
