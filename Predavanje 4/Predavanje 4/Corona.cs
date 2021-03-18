using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanje_4
{
    class Corona: Cjepivo
    {
        public Corona() : base("Corona virus cjepivo")
        {
            // this.Naziv = "dsdfsa"; neće ići
        }

        public string Zemlja { get; set; }

        double _broj;
        public double BrojCijepljenih {
            get
            {
                return _broj;
            }
            set
            {
                if (value < 0 || value > 1e9)
                    throw new ArgumentOutOfRangeException("Krivi broj");
                _broj = value;
            }
         }
    }
}
