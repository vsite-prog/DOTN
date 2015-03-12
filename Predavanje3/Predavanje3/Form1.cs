using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using  System.Drawing;

namespace Predavanje3
{
    public partial class Form1 : Form
    {
        List<string> sviGradovi;
        public Form1()
        {
            InitializeComponent();
            sviGradovi = new List<string>();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("POjam je: " + tb_pojam.Text );
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Predavanje 3 \n Verzija 1.0", "O programu", MessageBoxButtons.OK);
        }

        private void otvoriFormuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaUnos form = new FormaUnos(sviGradovi);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.OK) {
                lb_gradovi.Text = "Lista gradova:";
             /* vidi alternativu    for (int i = 0; i < sviGradovi.Count; i++)
                {
                    lb_gradovi.Text += "\n" + sviGradovi[i];
                }
              * */
                foreach (string grad in sviGradovi)
                {
                    //Grad je u priv. varijabli
                    lb_gradovi.Text += "\n" + grad;
                }
           
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (radioButton1.Checked)
                otvoriFormuToolStripMenuItem.Enabled = true;
            else
                otvoriFormuToolStripMenuItem.Enabled = false;
             * */
            otvoriFormuToolStripMenuItem.Enabled = radioButton1.Checked;

        }

        private void cb_boja_SelectedIndexChanged(object sender, EventArgs e)
        {
            string boja = cb_boja.SelectedItem.ToString();
            //POstavi boju pozadine
            switch (boja)
            {
                case "crveno":
                    this.BackColor = Color.Red;
                    break;
                case "zeleno":
                    this.BackColor = Color.Green;
                    break;
                default:
                    this.BackColor = SystemColors.Window;
                    break;
            }

        }
    }
}
