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

namespace DOTN2018Servis
{
    public partial class DOTN2018 : ServiceBase
    {
        //Zaustavljanje flag
        bool zaustaviSe;
        EventLog eventLog; //Ovo je priključak za logiranje
        public DOTN2018()
        {
            InitializeComponent();
            eventLog = new EventLog();
            //Pišemo u standardni Application log
            eventLog.Log = "Application";
            eventLog.Source = "DOTN 2018";
        }

        protected override void OnStart(string[] args)
        {
            zaustaviSe = false;
            //Što radi servis
            WaitCallback delegat = new WaitCallback(nestoRadi);
            //Idemo pokrenuti novu nit
            ThreadPool.QueueUserWorkItem(delegat);
            eventLog.WriteEntry("Naš servis startan u: " + DateTime.Now.ToLongTimeString());
        }

        protected override void OnStop()
        {
            //POstavi flag na true
            zaustaviSe = true;
            eventLog.WriteEntry("Gotovo je! Servis baj baj...");
        }

        //Ovo je procedura koja nešto radi u svojoj niti
        void nestoRadi(object state) //Procedura može primiti bilo kakav objekt
        {
            int brojac = 0;

            while (!zaustaviSe) //dok nije bio OnStop
            {
                brojac++; //Ako ses ovo ne zaustavi s vremenom ćemo prekoračiti Max int
                string txt = "Prolaz broj: " + brojac.ToString();
                eventLog.WriteEntry(txt);
                Thread.Sleep(3000); //Čekaj 3 sekunde
            }
        }
    }
}
