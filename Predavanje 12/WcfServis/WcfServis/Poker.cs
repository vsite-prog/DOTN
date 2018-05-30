using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Poker : IPoker
    {
        public bool BacamKartu(Karta karta)
        {
            //pamti bačene karte
            List<Karta> kartaskiStol = new List<Karta>();
            try
            {
                if (karta == null || karta.Boja == null || karta.Broj == 0)
                {
                    throw new ArgumentNullException(); //ovo nije dobro 
                }
                kartaskiStol.Add(karta);
                return true;
            }
            catch (ArgumentNullException ex)
            {
                //Ovdje bi nešto naravili, logiral ili sl.
                return false;
            }
        }

        public Karta Uzimamkartu()
        {
            Karta karta = new Karta();
            //Generiraj slučajno neku kartu
            Random random = new Random(DateTime.Now.Millisecond); //Uzmi svaki put drugi početni broj
            karta.Broj = random.Next(1, 13);
            switch (random.Next(1, 4))
            {
                case 1:
                    karta.Boja = "Pik";
                    break;
                case 2:
                    karta.Boja = "Tref";
                    break;
                case 3:
                    karta.Boja = "Hertz";
                    break;
                default:
                    karta.Boja = "Karo";
                    break;
            }
            return karta;
            
        }
    }
}
