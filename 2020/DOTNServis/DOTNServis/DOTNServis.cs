using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;

namespace DOTNServis
{
    public partial class DOTNServis : ServiceBase
    {
        // Kontrolni flag
        bool zaustaviSe = false;
        // Mi ćemo pisati u Event Log
        EventLog log = new EventLog();
        public DOTNServis()
        {
            InitializeComponent();
            // Postavi logiranje samo jednom
            // Dodati ćemo novi izvor logova u application ako nismo prije
            if (!EventLog.SourceExists("DOTNServis"))
            {
                EventSourceCreationData logIzvorPodaci = new EventSourceCreationData("DOTNServis", "Application");
                EventLog.CreateEventSource(logIzvorPodaci);
            }
            log.Source = "DOTNServis";
            log.Log = "Application";
        }

        protected override void OnStart(string[] args)
        {
            // Zabilježi pokretanje
            log.WriteEntry($"Naš servis pokrenut u: {DateTime.Now.ToLongTimeString()} ");

            // Ovdje počinje rad našega servisa
            WaitCallback callbackDelegate = (state) =>  // lambda funkcija koja bi se trebala izvršavatu u drugoj niti 
           {
               int i = 0;
               while (!zaustaviSe) // Radi sve dok glavna nit ne postavi zastavicu na stani!
               {
                   i = i < Int32.MaxValue ? ++i : 1; // Ako si došao do maksimuma vrati se na jedinicu
                   // Logiraj prolaz
                   log.WriteEntry($"Prolaz broj; {i.ToString()} u: {DateTime.Now.ToLongTimeString()} ");
                   Thread.Sleep(3000); // Ne radi ništa, čekaj
               }
           };

            // Idemo pokrenuti ovaj naš delegat
            ThreadPool.QueueUserWorkItem(callbackDelegate);// Uzmi iz poola niti jednu i radi svoj posao
        }

        protected override void OnStop()
        {
            // Mi bi htjeli ovdje zaustaviti drugu nit
            zaustaviSe = true;
            // Zabilježi pokretanje
            log.WriteEntry($"Naš servis je završio u: {DateTime.Now.ToLongTimeString()} ");
        }
    }
}
