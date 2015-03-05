using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfNasPrimjer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    //Interface koji će pokazati što naš servis nudi klijentima
    [ServiceContract]
    public interface IRibarnica
    {
        [OperationContract]
        List<Riba> DajSveRibe();

        [OperationContract]
        bool DodajRibu(Riba ribetina);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfNasPrimjer.ContractType".
    //Tip riba koji koristimo u aplikaciji
    [DataContract]
    public class Riba
    {
        [DataMember]
        public string Naziv
        {
            get; set;
        }

        [DataMember]
        public double Kolicina
        {
            get; set;
        }
    }
}
