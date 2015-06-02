using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfPtice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPtice
    {
        [WebGet(UriTemplate="daj/{value}")]
        [OperationContract]
        Ptica DajPticu(string value);

        [WebGet(UriTemplate = "dajSve", ResponseFormat=WebMessageFormat.Json)]
        [OperationContract]
        List<Ptica> DajSve();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfPtice.ContractType".
    [DataContract]
    public class Ptica
    {
        public Ptica(int sifra, string naziv, string vrsta)
        {
            this.Sifra = sifra;
            this.Naziv = naziv;
            this.Vrsta = vrsta;
        }

        [DataMember]
        public int Sifra
        {
              get;set;
        }

        [DataMember]
        public string Naziv
        {
            get;
            set;
        }

        [DataMember]
        public string Vrsta
        {
            get;
            set;
        }
    }
}
