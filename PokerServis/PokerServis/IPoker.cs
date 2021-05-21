using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PokerServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPoker
    {
        [OperationContract]
        bool BaciKartu(Karta karta); // Baci kartu na stol kao igrač

        [OperationContract]
        Karta UzmiKartu(); // Uzmi kartu od djelitelja

        [OperationContract]
        List<Karta> dajSveNaStolu();
    }

    [DataContract]
    public class Karta
    {
        int _broj;
        string _boja;

        [DataMember]
        public int Broj // Broj karte 1 - 13
        {
            get { return _broj; }
            set { _broj = value; }
        }

        [DataMember]
        public string Boja // Srce, pik itd.
        {
            get { return _boja; }
            set { _boja = value; }
        }
    }
}
