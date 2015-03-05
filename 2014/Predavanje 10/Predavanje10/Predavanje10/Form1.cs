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

namespace Predavanje10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Pokreni asonkronu operaciju u DoWork
            backgroundWorker1.RunWorkerAsync();
            /*
            Thread t = new Thread(new ThreadStart(bezveze));
            t.Start();
             * */
            
        }
        private void bezveze()
        {
            //UI thread ovo neće dopustiti
            label1.Text = Thread.CurrentThread.Name + ": promijenila!";
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = Thread.CurrentThread.Name + ": promijenila!";
        }
    }
}
