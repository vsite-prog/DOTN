using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace REST_Servis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PticeServis : IPtice
    {
        //Daj neki spremnik ptičurina
        List<Ptica> ptice = new List<Ptica>()
        {
            new Ptica(1, "Kleopo", "Kos"),
            new Ptica(2, "malena", "Roda"),
            new Ptica(3, "Klepetan", "Roda")
        };

        public Ptica JednaPtica(string value)
        {
            //Ovo će pukniti ako nije int
            int id = Int32.Parse(value);
            //LINQ upit
            return ptice
                .Find(ptica => ptica.Id == id);
        }

        public List<Ptica> SvePtice()
        {
            return ptice;
        }
    }
}
