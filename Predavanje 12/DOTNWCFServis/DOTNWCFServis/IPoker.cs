using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DOTNWCFServis
{
    // Poker stol ima dvije metode baci kartu i primi kartu
    [ServiceContract]
    public interface IPoker
    {
        [OperationContract]
        bool BaciKartu(Karta karta);

        // TRažim od stola da mi da novu kartu
        [OperationContract]
        Karta PrimiKartu();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "DOTNWCFServis.ContractType".
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
