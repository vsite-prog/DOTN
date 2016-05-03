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
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            ThreadStart del = pisiPoLabeli; //pokaži na našu metodu
            Thread t = new Thread(del); //pripremao nit za izvođenje
            t.Name = "Druga nit";
            // t.Start(); nemoj krenuti jer nisi thread safe, idemo s bg workerom
            //Startaj workera
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.RunWorkerAsync();
        }

        void pisiPoLabeli()
        {
            //sad smo u drugom threadu
            label1.Text = "";
            for (int i=0; i < 5; i++)
            {
                label1.Text += Thread.CurrentThread.Name + ": " + DateTime.Now.ToLongTimeString();
                Thread.Sleep(2000);
            }
            

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string txt = "";
            for (int i = 0; i < 5; i++)
            {
                txt += "\nBgWorker: " + DateTime.Now.ToLongTimeString();
                Thread.Sleep(2000);
                backgroundWorker1.ReportProgress(i * 20);
            }
            //vrati podatke
            e.Result = txt;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Ovo se izvršava na UI threadu 
            label1.Text += e.Result.ToString();

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            label1.Text += "\nNapredak: " + e.ProgressPercentage.ToString();
        }
    }
}
