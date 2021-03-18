using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_4
{
    public partial class Form1 : Form
    {
        List<Corona> cijepljeni = new List<Corona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Procitaj iz enumeracije vrijednosti
            cb_proizvodaci.DataSource = Enum.GetNames(typeof(Proizvodaci));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Corona corona = new Corona();
            corona.Zemlja = tb_zemlja.Text;
            corona.BrojCijepljenih = Double.Parse(tb_broj.Text); // Ako ne unesemo broj, dobiti ćemo except, trebalo bi ga uhvatiti ili TryParse
            corona.Proizvodac = (Proizvodaci)Enum.Parse(typeof(Proizvodaci), cb_proizvodaci.SelectedItem.ToString());

            cijepljeni.Add(corona);

            lb_cijepljeni.Text = "Lista cijepljenja:\n";
            foreach (Corona cijepljenje in cijepljeni)
            {
                lb_cijepljeni.Text += $"Cijepivo: {cijepljenje.Naziv}, zemlja: {cijepljenje.Zemlja}, proizvođač: {cijepljenje.Proizvodac}, broj cijepljenih: {cijepljenje.BrojCijepljenih}!\n"; // Interpolirani string
            }
        
        }
    }
}
