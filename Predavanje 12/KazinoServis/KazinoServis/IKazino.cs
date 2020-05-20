using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KazinoServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IKazino
    {
        [OperationContract]
        Karta DijeliKartu(); // Tražim od servisa kazina jednu poker kartu

        [OperationContract]
         bool BacamKartu(Karta karta); // Bacam kartu na stol, vraćam je u špil

        [OperationContract]
        List<Karta> SveBaceneKarte();

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "KazinoServis.ContractType".
    [DataContract]
    public class Karta // Ovo je naša klasa koja opisuje kartu u poker špilu
    {
        
        [DataMember]
        public int Broj
        {
            get;set;
        }

        [DataMember]
        public string Boja
        {
            get; set;
        }
    }
}
