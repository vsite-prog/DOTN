using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje4
{
    class Covid : Virus
    {
        public Covid() : base("sars-cov-2")
        {
            // Prazno ali izvršavamo konstruktor od klase koju nasljeđujemo
        }

        int _godina; // stvarni spremnik podataka, private
        public int Godina
        {
            get
            {
                return _godina;
            }
            set
            {
                if (value < 2019 || value > DateTime.Now.Year )  // Value predstavlja vrijednost koju pokušavamo pridružiti svojstvu
                {
                    // Ovo nije dobro, greška
                    throw new Exception("Godina nije ispravna");
                }
                // Postavi vrijednost
                _godina = value;
            }
        }

        // On kreira skrivenu varijablu
        public string Napomena { get; set; }

        public override string ToString()
        {
            return $"Virus: {Name} , Zemlja: {Zemlja} , Godina: {Godina}   , Napomena: {Napomena}  "; // ovo je formatirani ili interpolirani string
           //  return base.ToString(); ovako bi pozvali metodu klase koju nasljeđujeGodinamo
        }
    }
}
