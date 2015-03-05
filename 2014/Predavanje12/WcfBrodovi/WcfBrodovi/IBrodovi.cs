using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfBrodovi
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IBrodovi
    {
        [OperationContract]
        [WebGet(UriTemplate="/brod/{id}")]
        Brod DajBrod(string id);

        [OperationContract]
        [WebGet(UriTemplate="/brod/svi")]
        List<Brod> DajSve();

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfBrodovi.ContractType".
    [DataContract]
    public class Brod
    {
        //Konstruktor za listu
        public Brod(int id, string naziv, string luka, double nosivost)
        {
            this.Id = id;
            this.Naziv = naziv;
            this.Luka = luka;
            this.NosivTona = nosivost;
        }

        [DataMember]
        public int Id
        {
            get;
            set;
        }
        [DataMember]
        public string Naziv
        {
            get;set;
        }

        [DataMember]
        public string Luka
        {
            get;
            set;
        }

        [DataMember]
        public double NosivTona
        {
            get;
            set;
        }
    }
}
