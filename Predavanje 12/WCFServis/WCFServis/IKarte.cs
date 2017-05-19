using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServis
{
    // Ovo je ugovor za cijeli servis
    [ServiceContract]
    public interface IKarte
    {
        //Ovo za metode
        [OperationContract]
        Karta DajKartu();

        [OperationContract]
        bool BacamKartu(Karta k);

    }

    //A ovako će biti podaci poslani ili primljeni
    [DataContract]
    public class Karta
    {
        int _broj;

        [DataMember]
        public int Broj
        {
            get { return _broj; }
            set { _broj = value; }
        }

        [DataMember]
        public string Znak
        {
            get;set;
        }
    }
}
