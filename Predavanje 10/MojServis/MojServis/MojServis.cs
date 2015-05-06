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

namespace MojServis
{
    public partial class MojServis : ServiceBase
    {
        private bool radi; //ovo je sinkronizaciju
        EventLog eventLog;
        public MojServis()
        {
            InitializeComponent();
            //Pripremi logiranje naših događaja
            eventLog = new EventLog();
            eventLog.Source = "MojServis";
            eventLog.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            //Ovo je stvarni kod koji izvodi naš servis
            //Hoćemo  novi thread
            radi = true;
            ThreadPool.QueueUserWorkItem(new WaitCallback(radiNesto));
            eventLog.WriteEntry("Startamao");

        }

        protected override void OnStop()
        {

            //Izvesti će se kad zaustavimo naš servis
            eventLog.WriteEntry("Zaustavljamo");
            radi = false;
        }

        private void radiNesto(object state)
        {
            //Ovaj thread treba zaustaviti
            while (true)
            {
                Thread.Sleep(2000);
                eventLog.WriteEntry("Vrijeme prolaza: " + DateTime.Now.ToLongTimeString());
            }
        }
    }
}
