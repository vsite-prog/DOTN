using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace Predavanje11
{
    public partial class Predavanje11 : ServiceBase
    {
        // Htjeli bi nešto logirati da znamo gdje je servis
        EventLog log;
        // Flag da li treba raditi
        bool aktivan;
        public Predavanje11()
        {
            InitializeComponent();            
            // Kreiraj novi tip log-a koji će biti vezan za našu aplikaciju
            if (!EventLog.SourceExists("DOTN"))
            {
                // Sad kreiraj novi source
                EventSourceCreationData sourceData = new EventSourceCreationData("DOTN", "Application");
                EventLog.CreateEventSource(sourceData);
            }

            // Sad kreiraj naš log koji će biti dio starndardnog loga
            log = new EventLog();
            log.Log = "Application";
            log.Source = "DOTN";    
        }

        protected override void OnStart(string[] args)
        {
            aktivan = true;
            // Ovdje bi trebalo izvršavati servis
            // Javi u log
            log.WriteEntry("Pokrenut u: " + DateTime.Now.ToLongTimeString());
            // Ova procedura mora završiti pa ćemo pokrenuti novu nit
            WaitCallback delegat = new WaitCallback(nestoRadim);
            ThreadPool.QueueUserWorkItem(delegat);     // Uzmi iz pool-a nekakvu nit i kreni raditi
        }

        protected override void OnStop()
        {
            // Zaustavi servis
            aktivan = false;
            // Javi u log
            log.WriteEntry("Zaustavljen u: " + DateTime.Now.ToLongTimeString());
        }

        void nestoRadim(object state) // Objekt nam nije bitan
        {
            int i = 0;
            while (aktivan)
            {
                i = i == Int32.MaxValue ? 1 : i + 1; // Kad dođeš do kraja idi opet od početka
                log.WriteEntry("Prolaz petlje broj : " + i.ToString());
                Thread.Sleep(2000); // Nešto radim 2 sekunde
            }
        }
    }
}
