using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WSPredavanje10
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
            //POstavi logger
            eventLog1.Source = "WSPredavanje10";
            eventLog1.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            eventLog1.WriteEntry("Idemo krenuli smo, jeeee...");
            //kreiraj novi thread i u njemu nešto radi
            ThreadPool.QueueUserWorkItem(new WaitCallback(bezveze));
        }

        protected override void OnStop()
        {
            //Ovdje moramo zaustaviti thread jer će i dalje biti u memoriji
            eventLog1.WriteEntry("Gotovo je, uuuuu...");
        }
        private void bezveze(object state)
        {
            int i = 0;
            while (true)
            {
                i++;
                //pricekaj malo
                Thread.Sleep(2000);
                //pisi u log
                eventLog1.WriteEntry(i.ToString()  + ". prolaz!");
            }
        }
    }
}
