using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PorukaServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PorukaServis : IPoruka
    {
        List<Poruka> listaPoruka = new List<Poruka>()
        {
            new Poruka(1, "Ja", "Ti", "Helooou"),
            new Poruka(2, "Ti", "Ja", "Šta helooou?"),
            new Poruka(3, "Ja", "Ti", "Što se radi?"),
            new Poruka(4, "Ti", "Ja", "Uči se DOTN!!!"),
        };
        public Poruka JednaPoruka(string id)
        {
            int broj;

            if(Int32.TryParse(id, out broj))
            {
                // Pronađi element u listi
                return listaPoruka.First<Poruka>(poruka => poruka.Id == broj);
            } else
            {
                return null; // nije broj
            }
        }

        public List<Poruka> SvePoruke()
        {
            return listaPoruka;
        }
    }
}
