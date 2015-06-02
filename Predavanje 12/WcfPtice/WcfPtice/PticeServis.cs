using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfPtice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class PticeServis : IPtice
    {
        List<Ptica> svePtice = new List<Ptica>()
        {
            new Ptica(11, "Klepetan", "Roda"),
            new Ptica(12, "Malena", "Roda"),
            new Ptica(11, "Aero", "Orao")

        };


        public Ptica DajPticu(string value)
        {
            //Ovo će baciti ex ako nije int!?
            int sifra = Int32.Parse(value);
            return svePtice.Find(p => p.Sifra == sifra);
        }

        public List<Ptica> DajSve()
        {
            return svePtice;
        }
    }
}
