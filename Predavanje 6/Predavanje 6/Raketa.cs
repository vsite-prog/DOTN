using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_6
{
    class Raketa
    {
        // Idemo generirati događaj
        public event EventHandler Boom;

        public string Ime { get; set; }

        // Brzina rakete
        double _brzina; // Skrivena varijabla 
        public double Brzina
        {
            get => _brzina; // Vrsta lambde, predstavlja get metodu 

            set
            {
                if (value > 1000 || value < 0)
                {
                    // Okini nekakav događaj, eksplodirala
                    onBoom();

                }
                else
                {
                    _brzina = value;
                }
            }
        }

        protected virtual void onBoom()
        {
            //   Boom?.Invoke(this, EventArgs.Empty); - kraći način pisanja
            if (Boom != null)  // ima li ikoga na delegatu ako nitko nije preptplaćen nemoj ni okidati događaj
            {
                Boom(this, EventArgs.Empty);
            }
        }

        public override string ToString()
        {
            return $"Raketa {Ime} leti brzinom {Brzina}";
        }


    }
}
