using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje7
{
    class Slon:IZivotinja
    {
        private double _tezina;

        public void promijeniTezinu(double t)
        {
            //implementiraj interface i daj metodu za mijenjanje
            if (_tezina + t > MaxTezina.Slon || _tezina + t < 0)
                throw new Exception("Kriva težina");
            else
                _tezina += t;
        }

        //još jedan član interface-a
        public double vratiTezinu()
        {
            return _tezina;
        }
    }
}
