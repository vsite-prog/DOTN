using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KazinoServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Kazino : IKazino
    {
        // Ovo nije baš za produkciju ali biće dobro za test (u principu ovo je ili odvojeni neki servis ili pisanje u bazu itd.)
        // Tko god pozove ovaj servis vidjeti će kompletnu listu
        static List<Karta> baceneKarte = new List<Karta>(); // Karte vraćene u špil
        List<Karta> podijeljeneKarte = new List<Karta>();
        public bool BacamKartu(Karta karta)
        {
            if(karta == null || karta.Broj > 13 || karta.Broj < 1)
            {
                return false; // Neispravni podaci su poslani servisu reagiramo sa statusom false, Exception, Logging?
            }
            baceneKarte.Add(karta);
            return true;
        }

        public Karta DijeliKartu()
        {
            // Idemo podijeliti neku kartu, možda da uzmemo Random nekakvu iz špila
            // Generator slučajnih brojeva
            Random random = new Random(DateTime.Now.Millisecond); // Nekakav slučajni početni broj , dalje iz njega generira
            int broj = random.Next(1, 14);
            random = new Random(DateTime.Now.Millisecond); // Ponovo inicijaliziraj generator
            int bojaKod = random.Next(1, 5);
            string boja;
            switch (bojaKod)
            {
                case 1:
                    boja = "Hertz";
                    break;
                case 2:
                    boja = "Karo";
                    break;
                case 3:
                    boja = "Pik";
                    break;
                default:
                    boja = "Tref";
                    break;
            }
            Karta karta = new Karta();
            karta.Broj = broj;
            karta.Boja = boja;

            podijeljeneKarte.Add(karta);
            return karta;
        }

        public List<Karta> SveBaceneKarte()
        {
            return baceneKarte;
        }
    }
}
