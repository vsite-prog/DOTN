using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ChatServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ChatServis : IChat
    {
        List<Poruka> svePoruke = new List<Poruka>()
        {
            new Poruka(1, "Janko", "Marko", "Kako si"),
            new Poruka(2, "Marko", "Janko", "Dobro, kako si ti?"),
            new Poruka(3, "Janko", "Marko", "Nije loše, šta ima"),
            new Poruka(4, "Marko", "Janko", "Ništa, dosadan si.."),
        };
        public Poruka DajPoruku(string id)
        {
            try
            {
                int praviId = Int32.Parse(id);
                return svePoruke.Find(poruka => poruka.Id == praviId);
            } catch (Exception ex)
            {
                // Pukao je cast, zahtjev nije dobar 
                throw new ArgumentException("Id nije broj kakav očekujemo!");
            }

        }

        public List<Poruka> DajSvePoruke()
        {
            return svePoruke;
        }
    }
}
