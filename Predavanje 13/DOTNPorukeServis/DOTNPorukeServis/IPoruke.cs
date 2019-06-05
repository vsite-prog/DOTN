using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace DOTNPorukeServis
{
    // Ovo su metode našeg servisa
    [ServiceContract]
    public interface IPoruke
    {
        [WebGet(UriTemplate="jedna/{id}", ResponseFormat =WebMessageFormat.Json)]
        [OperationContract]
        Poruka DajJednuPoruku(string id);

        [WebGet(UriTemplate = "sve", ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        List<Poruka> DajSvePoruke();

        // TODO: Add your service operations here
    }

    // Specifikacija tipova podataka s kojima radimeo
    [DataContract]
    public class Poruka
    {
        // Metoda konstruktora koja nije dio ugovora
        public Poruka(int id, string prima, string salje, string sadrzaj)
        {
            Id = id;
            Prima = prima;
            Salje = salje;
            Sadrzaj = sadrzaj;
        }


        [DataMember]
        public int Id
        {
            get;set;
        }

        [DataMember]
        public string Prima
        {
            get; set;
        }

        [DataMember]
        public string Salje
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
