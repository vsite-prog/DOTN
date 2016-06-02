using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Diler : IDiler
    {
        //Nije baš dobar način za spremenje...
        private static List<Karta> primljeneKarte = new List<Karta>();
        //NAš stol za dijeljenje šalje kartu klijentu
        public Karta DijeliKartu()
        {
            Karta karta = new Karta();
            //Generiraj slučajnu kartu, prvo broj 
            int broj;
            string tip= "";
            Random random = new Random(); //generiraj mi slučajne brojeve za broj i vrstu karte
            broj = random.Next(1, 14);
            switch(random.Next(1, 4))
            {
                case 1:
                    tip = "karo";
                    break;
                case 2:
                    tip = "srce";
                    break;
                case 3:
                    tip = "pik";
                    break;
                case 4:
                    tip = "djetelina";
                    break;
            }
            karta.Broj = broj;
            karta.Tip = tip;
            return karta;

        }


        public bool PrimiKartu(Karta k)
        {
            if (k == null) //Nije ništa poslano
            {
                throw new ArgumentNullException("Nema karte");
            } else
            {
                //Zaprimi kartu
                primljeneKarte.Add(k);
            }
            return true;
        }
    }
}
