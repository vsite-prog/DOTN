using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DOTNPorukeServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PorukeServis : IPoruke
    {
        // Hardkodiramo sve poruke
        List<Poruka> svePoruke = new List<Poruka>()
        {
            new Poruka(1, "Ti", "Ja", "Hi , bok"),
            new Poruka(2, "Ti", "Ja", "Hi , ponovo sam tu"),
            new Poruka(3, "Ja", "Ti","Hi , bok"),
            new Poruka(4, "Ja", "Ti","Hcvdagfsdfdsyy,bhfhf DAhu"),
        };

        public Poruka DajJednuPoruku(string pId)
        {
            int id = Int32.Parse(pId); // Ovdje će biti exception ako parse ne dobije broj
            return svePoruke.Find(poruuka => poruuka.Id == id);
        }

        public List<Poruka> DajSvePoruke()
        {
            return svePoruke;
        }
    }
}
