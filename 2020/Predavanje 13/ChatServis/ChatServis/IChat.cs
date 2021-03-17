using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ChatServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IChat
    {
        [WebGet(UriTemplate ="poruka/{id}", ResponseFormat =WebMessageFormat.Json)]
        [OperationContract]
        Poruka DajPoruku(string id);

        [WebGet(UriTemplate = "sveporuke", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Poruka> DajSvePoruke();

        
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ChatServis.ContractType".
    [DataContract]
    public class Poruka
    {
        public Poruka(int id, string salje, string prima, string sadrzaj)
        {
            Id = id;
            Salje = salje;
            Prima = prima;
            Sadrzaj = sadrzaj;
        }

        [DataMember]
        public int Id
        {
            get;set;
        }

        [DataMember]
        public string Salje
        {
            get; set;
        }

        [DataMember]
        public string Prima
        {
            get; set;
        }

        [DataMember]
        public string Sadrzaj
        {
            get; set;
        }
    }
}
