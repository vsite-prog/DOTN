using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_6
{
    class Raketa
    {
        // Ako ide prebrzo raketa će izgoriti
        public event EventHandler Boooom;
        // Mogao bi biti događaj i pad brzine ispod nule ili exception

        public string Naziv { get; set; }

        double _brzina;
        public double Brzina
        {
            get
            {
                return _brzina;
            }

            set
            {
                // Ako idemo ubrzati iznad limita, booom
                if (value > 1000)
                {
                    onBooom();
                }
                else
                {
                    _brzina = value;
                }

            }
        }
        
        protected virtual void onBooom() // Ovo je uobičajeni modifikator pristupa za proceduru pokretanja
        {
            // Boooom?.Invoke(this, EventArgs.Empty); kraći način, ovo je isto OK
            if (Boooom != null) // Idemo vidjeti da li je itko uopće zainteresiran za ovaj događaj
            {
                Boooom(this, EventArgs.Empty); // Poziv događaja
            }        
        }

        public override string ToString()
        {
            return "Raketa naziva: " + Naziv;
        }
    }
}
