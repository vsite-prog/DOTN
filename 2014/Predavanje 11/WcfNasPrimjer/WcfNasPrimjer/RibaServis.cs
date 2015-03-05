using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfNasPrimjer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RibaServis : IRibarnica
    {
        //Ovo je nasa ribarnica
        List<Riba> sveRibe = new List<Riba>();

        //implementacija naseg servisa - metode DajSveRibe
        public List<Riba> DajSveRibe()
        {
            return sveRibe;
        }

        //Dodavanje ribe u listu
        public bool DodajRibu(Riba r)
        {
            if (r == null)
            {
                throw new ArgumentNullException("Nema ribe");
            }
            try {
                sveRibe.Add(r);
            }catch (Exception ex){
                return false;
            }
            return true;

        }
    }
}
