using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_6
{
    public partial class Form1 : Form
    {
        Avion avion = new Avion("Letimiš", 100);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poruka<string>("Kliknut");
            // Bi li to radilo sa broijevim
            poruka<double>(12.4);
            poruka<int>(14);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kreiraj novo dugme
            Button button = new Button();
            button.Location = new System.Drawing.Point(180, 29);
            button.Name = "button1";
            button.Size = new System.Drawing.Size(90, 23);
            button.TabIndex = 0;
            button.Text = "Klikni i mene";
            button.UseVisualStyleBackColor = true;

            // Dodaj u formu 
            this.Controls.Add(button);

            // Neka nešto radi na klik
            button.Click += button1_Click;

            // Idemo se odjaviti
            button.Click -= button1_Click;

            // Idemo reagirati s Lambdom
            button.Click += (o, args) =>
            {
                MessageBox.Show("Lambda Kliknut");

                // Za svako klikanje dodaj k u tekst
                ( (Button)o).Text += "k";

            };

            // Ovome ćemmo dodati dinamički
            button3.Click += (o, args) => { avion.Brzina -= 100; };

            // Idemo nešto napraviti sa događajem boooma
            avion.Boooooom += (o, args) =>
            {
                Avion a = (Avion)o;
                poruka<Avion>(a);
            };


        }

        private void button2_Click(object sender, EventArgs e)
        {
            avion.Brzina += 100;
        }

        // Generička funkcija
        void poruka<T>(T objekt)
        {
            MessageBox.Show(objekt.ToString(), "Poruka", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
