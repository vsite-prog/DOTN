using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestServis
{
   //Ovdje ide logika oko čitanja poruku
    [ServiceContract]
    public interface IPoruke
    {
        [WebGet(ResponseFormat = WebMessageFormat.Xml, UriTemplate = "jedna/{id}")]
        [OperationContract]
        Poruka DajPoruku(string id); //morali smo promijeniti u string

        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "sve")]
        [OperationContract]
        List<Poruka> DajSvePoruke();
    }

   //POdaci o poslanoj mail/chat poruci
    [DataContract]
    public class Poruka
    {
        //Ovo nije DataMember i klijent ne vidi ovaj kod
        public Poruka(int id, string salje, string prima , string tekst)
        {
            Id = id;
            this.Salje = salje; //ovo je u biti sve sa this kao ovdje
            Prima = prima;
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
