using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServis
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Dijelitelj : IDijeli
    {
        List<Karta> poslaneKarte = new List<Karta>();
        public Karta DajKartu() {
            //Vrati slučajno izmiješanu kartu

            Random r = new Random();
            int broj = r.Next(1, 15);

            string tip;
            switch (r.Next(1,5))
            {
                case 1:
                    tip = "karo";
                    break;
                case 2:
                    tip = "hertz";
                    break;
                case 3:
                    tip = "pik";
                    break;
                default:
                    tip = "tref;";
                    break;
            }

            Karta k = new Karta();
            k.Broj = broj;
            k.Tip = tip;

            return k;
            }

            public  bool PrimiKartu(Karta karta){
                if (karta != null){
                    poslaneKarte.Add(karta);
                    return true;
                } else {
                    return false;
                }
            }
        }
}
