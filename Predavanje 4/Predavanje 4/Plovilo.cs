using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    // Generalna klasa svega što plovi na moru,, ne može se instancirati
    public abstract class Plovilo
    {
        // Ovo je spremnik podataka za godište
        private int _godiste;
        // Ovo je tip enumeracije
        public TipPlovila Tip { get; set; }
        // Godište plovila, ovdje getter i setter nisu defaultn-i
        public int Godiste
        {
            get
            {
                return _godiste;
            }
            set
            {
                if (value > DateTime.Now.Year || value < DateTime.Now.Year - 100)
                {
                    throw new Exception("Godište nije OK");
                } else
                {
                    _godiste = value;
                }
            }

        }
    }

    // Ovo možemo staviti u poseban file
    public enum TipPlovila
    {
        Motorno = 101,
        Vjetreno , // Ovaj je 102, a iza njega je 103
        Veslano
    }
}
