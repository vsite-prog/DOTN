using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServis
{
  //Definiraj servis
    [ServiceContract]
    public interface IPoker
    {
        //Korisnik servisa traži kartu
        [OperationContract]
        Karta Uzimamkartu();
        //Baca kartu na stol
        [OperationContract]
        bool BacamKartu(Karta karta);

        // TODO: Add your service operations here
    }
    //Ovvo je definicija podataka koje servis vraća/prima
    [DataContract]
    public class Karta
    {
        [DataMember]
        public int Broj
        {
            get;set;
        }

        [DataMember]
        public string Boja
        {
            get;set;
        }
    }
}
