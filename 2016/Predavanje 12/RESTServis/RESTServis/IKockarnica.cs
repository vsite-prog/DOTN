using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RESTServis
{
    [ServiceContract]
    public interface IKockarnica
    {
        [OperationContract]
        [WebGet(UriTemplate ="sve/", ResponseFormat =WebMessageFormat.Xml)]
        List<Kockarnica> DajSve();

        [OperationContract]
        [WebGet(UriTemplate = "jedna/{value}", ResponseFormat = WebMessageFormat.Json)]
        Kockarnica DajJednu(string value);

        // TODO: Add your service operations here
    }

    [DataContract]
    public class Kockarnica
    {
        public Kockarnica(int id, string naziv, string grad)
        {
            Id = id;
            Naziv = naziv;
            Grad = grad;
        }

        [DataMember]
        public int Id
        {
            get; set;
        }

        [DataMember]
        public string Naziv
        {
            get;set;
        }


        [DataMember]
        public string Grad
        {
            get; set;
        }
    }
}
