using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    class Cjepivo
    {
        public delegate void NestaloHandler(string poruka);

        public event NestaloHandler NestaloCjepiva;

        public event NestaloHandler JosMaloPaNestaloCjepiva;
        public string Naziv { get; set; }

        double _kolicina; 
        
        public double Kolicina { 
            get
            {
                return _kolicina;
            }                
            set
            {
                if (value < 0)
                {
                    // Nestalo cjepiva, naručujemo više nego što ima,  pukni event
                    NestaloCjepiva("Nema više, ne možemo isporučiti");
                } else if (value < 50)
                {
                     JosMaloPaNestaloCjepiva($"Ostalo je samo još {value} komada, naruči još!");
                    _kolicina = value;
                }                  
                 else
                {
                    _kolicina = value;
                }
            }
                    
         }
    }
}
