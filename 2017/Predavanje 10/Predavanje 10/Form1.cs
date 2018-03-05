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
  
        class Brojac
        {
            public int Vrijednost { get; set; }
        }

        //Globalna varijabla, pristup njoj nije thread safe
        Brojac brojac = new Brojac(); 
        public Form1()
        {
            InitializeComponent();

            Thread t = Thread.CurrentThread; //Dohvatili smo tekuću nit
            t.Name = "Glavna, UI nit";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Idemo kreirati drugu nit
            //Prvo kreiraj delegat na kod koji želimo izvesti
            ThreadStart del = pisiULabelu;
            Thread t = new Thread(del);
            //Dajte mi ime
            t.Name = "Druga nit";
            //Imamo novu nit ali ona još nije pokrenuta idemo vidjeti
            t.Start();
            Thread.Sleep(5000);
            pisiULabelu();
        }

        void pisiULabelu()
        {
            lock (brojac)
            {
                for (int i = 0; i < 10; i++)
                {
                    brojac.Vrijednost += 3;
                    Thread.Sleep(500); //Zaustavi izvođenje ovog thread-a 
                    lb_text.Text += "\n" + Thread.CurrentThread.Name + " Prolaz: " + brojac.Vrijednost.ToString();
                }
            }

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //Ovo je druga nit!!!
            //Idemo biti malo brži
            StringBuilder sb = new StringBuilder();
            //Nešto radi
            for (int i=0; i< 10; i++)
            {
                //Javi u glavnu nit koiko smo gotovi
                backgroundWorker1.ReportProgress(i*10);
                Thread.Sleep(2000);
                sb.Append("\nProlaz u: ");
                sb.Append(DateTime.Now.ToLongTimeString());
            }

            //Pošalji rezultat u glavnu nit
            e.Result = sb.ToString();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Ovo je UI nit!!!
            lb_status.Text = "Završeno je: " + e.ProgressPercentage + "% posla u BG Workeru";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Ovo je UI nit!!!
            lb_status.Text = "Gotovo je s obradom u drugoj niti!";
            lb_status.ForeColor = Color.Red;

            //idemo sada prikazati rezultat
            lb_text.Text = e.Result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Neka naš BGW javlja koliko je gotov
            backgroundWorker1.WorkerReportsProgress = true;
            //Idemo pokrenuti BG Worker
            backgroundWorker1.RunWorkerAsync();
        }
    }
}
