using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using WcfPtice;

namespace PticeServis
{
    public partial class Service1 : ServiceBase
    {
        ServiceHost svchost;
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Kreirajmo komponentu za izvođenje WCFservisa
            svchost = new ServiceHost(typeof(PticeServis.Service1));
            svchost.Open();
        }

        protected override void OnStop()
        {
            if (svchost != null)
                svchost.Close();
        }
    }
}
