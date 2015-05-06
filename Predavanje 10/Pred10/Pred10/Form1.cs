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

namespace Pred10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Thread t = new Thread(new ThreadStart(promijeniLabelu));
            t.Start();
             * */
            //POkreni bg task
            backgroundWorker1.RunWorkerAsync();
        }

        private void promijeniLabelu() {
            //Ovo nije dobro
            label1.Text = "Promijenjeno iz drugog thread-a u: " + DateTime.Now.ToLongTimeString();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(3000);
            e.Result = DateTime.Now.ToLongTimeString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            label1.Text = "Promijenjeno iz drugog thread-a u: " + e.Result.ToString();
        }
    }
}
