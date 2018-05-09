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
        Spremnik spremnik = new Spremnik();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            //Idemo u drugi thread
            ThreadStart delegat = new ThreadStart(pisi);
            Thread thread1 = new Thread(delegat);
            thread1.Name = "Nit 2";
            thread1.Start();

            ThreadStart delegat2 = pisi; //kraci način pisanja
            Thread thread2 = new Thread(pisi); //ovo je još i kraći ovo gore nam ne treba
            thread2.Name = "Nit 3"; //Ovo se postavlja samo jednom
            thread2.Start();


            //Prije UI niti malo pričekaj
            Thread.Sleep(2000);

            //Ovo je UI thread
            pisi();
        }

        void pisi()
        {
            //Ova procedura u biti mijenja zajednički resurs+
            for (int i=0; i< 10; i++)
            {
                lock (spremnik) //Ne daj drugim nitima da rade dok ja nisam gotov s prolazom
                {
                    spremnik.Broj += 2;
                    //Idemo malo usporiti
                    Thread.Sleep(1000); //u milisekundama
                    label1.Text += "\nProlaz: " + spremnik.Broj.ToString() + " " + Thread.CurrentThread.Name;
                } 
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ovo je UI nit
            Thread glavnaNit = Thread.CurrentThread;
            glavnaNit.Name = "Glavna nit";

            //Neka javlja kad je prešao neki milestone
            backgroundWorker1.WorkerReportsProgress = true;

            backgroundWorker1.DoWork += (o, eArgs) =>
            {
                //Sada smo u drugoj niti
                //Ova nit nešto radi, mi ćemo kreirati text da lsuži kao prmjer
                StringBuilder builder = new StringBuilder();
                builder.Append("Druga nit:");
                for (int i=1; i<11; i++)
                {
                    Thread.Sleep(1000); //jedna sekunda pauze
                    builder.Append("\nProlaz: ");
                    builder.Append(i);
                    builder.Append(" vrijeme: ");
                    builder.Append(DateTime.Now.ToLongTimeString());
                    backgroundWorker1.ReportProgress(i * 10);
                }
                eArgs.Result = builder.ToString(); //Vrati nam text koji si napravio
            };

            backgroundWorker1.RunWorkerCompleted += (o, eArgs) =>
            {
                //OPet smo nazad u UI niti
                label1.Text = eArgs.Result.ToString();
            };

            backgroundWorker1.ProgressChanged += (o, eArgs) =>
            {
                //Kao i kod završetka, ovdje smo se vratili u UI nit
                label2.Text = "Završeno  " + eArgs.ProgressPercentage.ToString() + "% !";
            };

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Kreni s izvođenjem
            backgroundWorker1.RunWorkerAsync();
        }
    }

    public class Spremnik
    {
        public int Broj { get; set; }
    }
}
