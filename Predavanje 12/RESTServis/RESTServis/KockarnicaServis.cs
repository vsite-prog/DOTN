using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RESTServis
{
    public class KockarnicaServis : IKockarnica
    {
        List<Kockarnica> sveKockarnice = new List<Kockarnica>()
    {
        new Kockarnica(1, "Star", "Las Vegas"),
        new Kockarnica(2, "Red Satr", "Macao"),
        new Kockarnica(3, "Lucky", "Monte Carlo"),
    };

        public Kockarnica DajJednu(string strValue)
        {
            int value = 0;
            if (strValue != null &&  Int32.TryParse(strValue, out value))
            {
                return sveKockarnice.Find(kockarnica => kockarnica.Id == value);
            } else
            {
                throw new ArgumentNullException();
            }
            
        }

        public List<Kockarnica> DajSve()
        {
            return sveKockarnice;
        }


      
    }
}
