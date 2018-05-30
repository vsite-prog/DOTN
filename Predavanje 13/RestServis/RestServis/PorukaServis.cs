using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RestServis
{
    //Ovo je kod našeg servisa
    public class PorukaServis : IPoruke
    {
        List<Poruka> poruke = new List<Poruka>()
        {
            new Poruka(1, "ja", "ti", "Dobar dan"),
            new Poruka(2, "ja", "on", "Dobar dan i tebi"),
            new Poruka(3, "on", "ja", "CocsDFDfs"),
        };
        public Poruka DajPoruku(string id)
        {
            try
            {
                int _id = Int32.Parse(id);
                return poruke.Find(p => p.Id == _id);
            } catch (Exception ex)
            {
                throw new ArgumentException($"Krivi id: {id}");
            }

        }

        public List<Poruka> DajSvePoruke()
        {
            return poruke;
        }
    }
}
