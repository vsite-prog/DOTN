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

namespace DOTNService2017
{
    public partial class DOTNService2017 : ServiceBase
    {
        EventLog log;
        bool radi;
        public DOTNService2017()
        {
            InitializeComponent();
            //Kreiraj pisač u log
            log = new EventLog();
            log.Log = "Application"; //Pisati ćemo u applicaton log
            log.Source = "DOTNService2017";

        }

        protected override void OnStart(string[] args)
        {
            //Idemo nešto raditi
            radi = true;
            //samo idemo u drugi thread
            //Prvo nam treba delegat na ono što će se izvoditi
            WaitCallback del = new WaitCallback(radim);
            ThreadPool.QueueUserWorkItem(del);
            log.WriteEntry("Krenuli smo, juhuuuu...");

        }

        protected override void OnStop()
        {
            //svemu dođe kraj
            log.WriteEntry("Gotovo je :-(");
            //Idemo te zaustaviti
            radi = false;
        }

        /**
         * Radim nešto metoda
         **/
        void radim(object o)
        {
            int i=0;
            while (radi)
            {
                i++;
                log.WriteEntry(i + ". prolaz petlje!");
                Thread.Sleep(2000);
            }

        }
    }
}
