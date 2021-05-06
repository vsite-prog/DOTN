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
        Rampa rampa = new Rampa(); // Referentni tip za zaključavanje
        public Form1()
        {
            InitializeComponent();
            Thread thread = Thread.CurrentThread; // Ovo je naša glavna nit
            //Idemo joj promijeniti ime
            thread.Name = "Glavna/UI nit";
            // label1.Text = Thread.CurrentThread.Name;

       
        }

        private void Radnik_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Radnik_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Thread novaNit = new Thread(); // TRaži nekakav kod, funkciju koja će se izvoditi
            ThreadStart delegatNiti = radiPoNiti; // Deleget za thread 
            /*
            Thread drugaNit = new Thread(radiPoNiti);
            drugaNit.Name = "Druga nit";
            drugaNit.Start(); // Izvrši nit i izađi kad si gotov
            */

            for (int i = 0; i < 4; i++)
            {
                Thread thread = new Thread(radiPoNiti); // new ThreadStart(radiPoNiti)
                thread.Name = " Nit " + (i + 1).ToString();
                thread.Priority = ThreadPriority.Lowest;
                if (i == 2) thread.Priority = ThreadPriority.Highest; // Možemo i sami postaviti prioritet
                thread.Start();
            }


            radiPoNiti();
        }

        void radiPoNiti()
        {
            lock (rampa) // Došao si do rampe, sada prođi, neka te drugi čekaji
            {
                rampa.Prolaz++; // Još jedan prolaz kroz rampu
                for (int i = 0; i < 5; i++)
                {
                    Thread.Sleep(1000); // 1 sekunda, ne radi ništa
                    label1.Text += $"\n{Thread.CurrentThread.Name} rampa prolaz: {rampa.Prolaz}, prolaz petlje broj: {i + 1} - {DateTime.Now.ToLongTimeString()} ";
                }
                //label1.Text += "\n" + Thread.CurrentThread.Name;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackgroundWorker radnik = new BackgroundWorker();
            // Ovo je drugi thread
            radnik.DoWork += (o, a) =>
            {
                StringBuilder graditelj = new StringBuilder(); // Kako bi biloi brže, umjesto stringa koristiti ću ovu komponento
                graditelj.AppendLine("Idemooo ");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(1000); // Čekaj sekundu
                    graditelj.Append(" Prolaz broj: ");
                    graditelj.Append(i + 1);
                    graditelj.Append(" Vrijeme: ");
                    graditelj.Append(DateTime.Now.ToLongTimeString());
                    graditelj.Append("\n");
                    radnik.ReportProgress((i + 1) * 10);
                }
                graditelj.AppendLine("Kraj, the end! ");
                // Vratiti ćemo podatke u glavnu nit
                a.Result = graditelj.ToString();
            };
            // Ovo je glavni thread
            radnik.RunWorkerCompleted += (o, a) =>
            {
                // Threadsafe iz druge niti tekst
                label1.Text = a.Result.ToString();
            };

            radnik.ProgressChanged += (o, a)=>{
                progressBar1.Value = a.ProgressPercentage;
            };
            radnik.WorkerReportsProgress = true;
            radnik.RunWorkerAsync(); // Izvršavaj se u drugoj niti
        }
    }
    class Rampa
    {
        public int Prolaz { get; set; }
    }
}
