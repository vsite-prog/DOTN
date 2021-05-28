using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PorukaServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPoruka
    {
        // Po id-u daj mi jednu poruku
        [WebGet(ResponseFormat = WebMessageFormat.Xml, UriTemplate = "/poruka/{id}")]
        [OperationContract]
        Poruka JednaPoruka(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "/poruke")]
        List<Poruka> SvePoruke();

    }

   [DataContract]
    public class Poruka
    {
        // Konstruktor koji nije vidljiv za vanjske klijente
        public Poruka(int id, string salje, string prima, string tekst)
        {
            Id = id;
            Prima = prima;
            Salje = salje;
            Tekst = tekst;
        }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Salje { get; set; }

        [DataMember]
        public string Prima { get; set; }

        [DataMember]
        public string Tekst { get; set; }

    }
}
