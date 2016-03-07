using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje7
{
    class Tigar : IZivotinja
    {
        private double _tezina;

        public void promijeniTezinu(double t)
        {
            //implementiraj interface i daj metodu za mijenjanje
            if (_tezina + t > MaxTezina.Tigar || _tezina + t < 0)
                throw new Exception("Kriva težina");
            else
                _tezina += t;
        }

        public double vratiTezinu()
        {
            return _tezina;
        }
    }
        //Maksimalna težina za životinje
    static class MaxTezina
    {
        public const double Tigar = 450;
        public const double Slon = 5000;
    }
}
