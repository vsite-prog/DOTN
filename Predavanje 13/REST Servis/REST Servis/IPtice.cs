using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_Servis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPtice
    {
        [WebGet(UriTemplate ="/ptice/sve", ResponseFormat = WebMessageFormat.Xml)]
        [OperationContract]
        List<Ptica> SvePtice();

        [WebGet(UriTemplate = "/ptica/{value}", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        Ptica JednaPtica(string value);

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "REST_Servis.ContractType".
    [DataContract]
    public class Ptica
    {
        public Ptica(int id, string naziv, string vrsta){
            Id = id;
            Vrsta = vrsta;
            Naziv = naziv;
        }


        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Naziv { get; set; }

        [DataMember]
        public string Vrsta { get; set; }
    }
}
