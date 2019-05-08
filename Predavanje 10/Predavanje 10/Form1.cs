using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Predavanje_10
{
    public partial class Form1 : Form
    {
        // Globalni objekt na kom rade i drugi threadovi
        Racun racun = new Racun();

        BackgroundWorker radnik;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.Name = "UI Nit";
            // Idemo kreirati pozadinskog radnika
            radnik = new BackgroundWorker();
            // javljaj mi napredak
            radnik.WorkerReportsProgress = true;
            // ajde kaži mu što da radi
            radnik.DoWork += (o, args) =>
            {
                // Mi smo ovdje u drugoj niti
                // Idemo ubrzati ovu priču zbog nepromjenljivosti stringa
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < 10; i++)
                {
                    builder.Append("Prolaz: ");
                    builder.Append(i + 1);
                    builder.Append(" Vrijeme: ");
                    builder.Append(DateTime.Now.ToLongTimeString());
                    builder.Append("\n");
                    Thread.Sleep(2000);
                    radnik.ReportProgress((i + 1) * 10);
                };

                // Idemo ovo spremiti u rezultat
                args.Result = builder.ToString();
            };

            // Gotovi smo idemo uzeti rezultat
            radnik.RunWorkerCompleted += (o, args) =>
            {
                // Ovo je u UI niti
                label1.Text = args.Result.ToString(); // ? zar ovo nije isto kao maloprije - nije!
            };

            radnik.ProgressChanged += (o, a) =>
            {
                // Isto UI nit
                progressBar1.Value = a.ProgressPercentage;
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Možemo čitati i pisati Naziv niti
            //label1.Text = Thread.CurrentThread.Name;
            // Hoćemo novi thread
            // Ali prvo trba delegat
            ThreadStart delegat = new ThreadStart(izvrsi);
            Thread thread = new Thread(delegat);
            // Idemo staviti ime
            thread.Name = "Druga nit";
            // Kreni
            thread.Start();
            // Ovako se kraće piše ali je isto kao i gore
            Thread thread2 = new Thread(izvrsi);
            // Idemo staviti ime
            thread2.Name = "Treca nit";
            thread2.Start(); // Mogao sam mu kazati join, izvrši me do kraja pa tek onda se vrati

            // Još smo u glavnoj niti 
            izvrsi();
        }

        void izvrsi()
        {
            //label1.Text = "Ime niti: " + Thread.CurrentThread.Name;
            for (int i = 0; i < 5; i++)
            {
                lock (racun)
                {
                    racun.Stanje += 15;
                    label1.Text += "\n" + Thread.CurrentThread.Name + "Stanje racuna: " + racun.Stanje;
                    //label1.Text += "\n" + Thread.CurrentThread.Name + ": " + DateTime.Now.ToLongTimeString();
                }
                Thread.Sleep(1000);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // pokreni rad u drugoj niti
            radnik.RunWorkerAsync();
        }
    }
    public class Racun
    {
        internal decimal Stanje;
    }
}
