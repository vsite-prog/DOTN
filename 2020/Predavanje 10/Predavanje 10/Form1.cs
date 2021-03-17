using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_10
{
    public partial class Form1 : Form
    {
        // referentna varijabla
        Brojac brojac = new Brojac();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart delegat = new ThreadStart(pisiULabelu);
            Thread thread = new Thread(delegat);
            thread.Name = "Druga nit";
            thread.Priority = ThreadPriority.Highest; // ne znamo hoće li ovo poslušati
            thread.Start();

            Thread nit3 = new Thread(pisiULabelu); // kraći način pisanja
            nit3.Name = "Treća nit";
            nit3.Start();

            // Sada smo u glavnoj niti ili UI thread
            pisiULabelu();
        }

        void pisiULabelu()
        {
            for (int i=1; i < 11; i++)
            {
                lock (brojac) // Stavi bravu na ovaj objekt da niti jedna druga nit ne mogu ništa raditi s njime dok ne završim
                {
                    brojac.Stanje++; // digni stanje za jedan
                    Thread.Sleep(1000); // Zaustavi na jednu sekundu
                    label1.Text += $"\nNit: {Thread.CurrentThread.Name}, stanje brojača; {i}";
                    // label1.Text += $"\nNit ime: {Thread.CurrentThread.Name}, {i}. prolaz!";

                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // U glavnoj smo niti
            Thread.CurrentThread.Name = "Glavna nit";
            // Thread.CurrentThread.Name = "Glavna nit"; Ako pokušamo ponovo mijenjati ime - exception!

            // Idemo osposobiti pozadinskog radnika
            backgroundWorker1.DoWork += (o, a) =>
            {
                StringBuilder graditeljTeksta = new StringBuilder(); // Ovo radimo da bi ubrzali stvari
                graditeljTeksta.Append("Prolazi kroz petlju");
                // Mi smo sada u drugom thread-u
                for (int i=1; i < 11; i++) {
                    graditeljTeksta.Append("\nProlaz br: ");
                    graditeljTeksta.Append(i);
                    graditeljTeksta.Append("!");
                    Thread.Sleep(500);
                    backgroundWorker1.ReportProgress(i * 10);

                }
                graditeljTeksta.Append("\nGotovo!");
                a.Result = graditeljTeksta.ToString(); // Result je ono što ovaj radnik vraća
            };

            // On će se javiti kada završi
            backgroundWorker1.RunWorkerCompleted += (o, a) =>
            {
                // Mi smo sada i dalje u UI niti
                label1.Text = a.Result.ToString();
            };

            backgroundWorker1.ProgressChanged += (o, a) =>
            {
                // Opet smo u glavnoj niti 
                progressBar1.Value = a.ProgressPercentage;
            };

            // POstavi radnika da redovito javlja napredak
            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }

    class Brojac
    {
        public int Stanje;
    }
}
