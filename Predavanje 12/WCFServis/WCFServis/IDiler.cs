using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServis
{
    // Sada ide definicija ugovora našeg servisa
    [ServiceContract]
    public interface IDiler
    {
        [OperationContract]
        Karta DijeliKartu();

        [OperationContract]
        bool PrimiKartu(Karta k);

        // TODO: Add your service operations here
    }

    // Koristite donju klasu kao tip podataka koji će se razmijenjivati
   
    [DataContract]
    public class Karta
    {
        int _broj;
        string _stringValue;

        [DataMember]
        public int Broj
        {
            get { return _broj; }
            set { _broj = value; }
        }

        [DataMember]
        public string Tip
        {
            get { return _stringValue; }
            set { _stringValue = value; }
        }
    }
}
