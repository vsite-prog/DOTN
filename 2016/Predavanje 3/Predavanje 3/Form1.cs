using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_3
{
    public partial class Form1 : Form
    {
        List<string> sviPojmovi = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void opisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Predavanje 3 v1.0 \n Author: DOTN kolegij", "O programu", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void drugaFormaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UnosForma forma = new UnosForma(sviPojmovi); //Još se ne prikazuje
            DialogResult result = forma.ShowDialog();
            if (result == DialogResult.OK)
            {
                lb_pojmovi.Text = "Svi pojmovi";
                foreach(string pojam in sviPojmovi)
                {
                    lb_pojmovi.Text += "\n pojam: " + pojam;
                }

            }

        }

        private void KlikPoruka(object s, EventArgs args)
        {
            // this.Controls["tb_poruka"].Text
            MessageBox.Show(tb_poruka.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            drugaFormaToolStripMenuItem.Enabled = radioButton1.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "crveno":
                    this.BackColor = Color.Red;
                    break;
                case "plavo":
                    this.BackColor = Color.Blue;
                    break;
                case "zeleno":
                    this.BackColor = Color.Green;
                    break;
            }
            
        }
    }
}
