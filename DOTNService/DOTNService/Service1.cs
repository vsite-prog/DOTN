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

namespace DOTNService
{
    public partial class Service1 : ServiceBase
    {
        bool aktivan;
        EventLog eventLog; //Piši u Windows event log
        public Service1()
        {
            InitializeComponent();
            eventLog = new EventLog();
            eventLog.Source = "DOTN Servis";
            eventLog.Log = "Application"; //Ide direktno u application log 
        }

        protected override void OnStart(string[] args)
        {
            aktivan = true;
            eventLog.WriteEntry("Servis se pokreće ...");
            WaitCallback del = pisem;
            ThreadPool.QueueUserWorkItem(del); //Uzmi iz CLR pool-a novi thread i kreni s izvođenjem
        }

        protected override void OnStop()
        {
            aktivan = false;
            eventLog.WriteEntry("Servis se zasutavlja ...");
        }

        void pisem(Object state)
        {
            while (aktivan) //U drugom threadu smo ali samo čitamo..
            {
                Thread.Sleep(3000);
                eventLog.WriteEntry("Servis radi, sad je " + DateTime.Now.ToLongTimeString());
            }
        }
    }
}
