using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca
{
    class Stablo : Biljka
    {
        bool otpadajuListovi;

        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }

        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
    }
}
