using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_5
{
    class Vozilo
    {
        public TipVozila Tip { 
            get;   set;
        }
    }
    
    enum TipVozila
    {
        Cestovno = 10,
        Morsko = 20,
        Zračno = 30
    }
    
}
