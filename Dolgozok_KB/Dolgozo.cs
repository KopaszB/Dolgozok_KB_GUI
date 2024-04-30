using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozok_KB
{
    class Dolgozo
    {
        string nev;
        string neme;
        string reszleg;
        int belepesev;
        int ber;

        public string Nev { get => nev; set => nev = value; }
        public string Neme { get => neme; set => neme = value; }
        public string Reszleg { get => reszleg; set => reszleg = value; }
        public int Belepesev { get => belepesev; set => belepesev = value; }
        public int Ber { get => ber; set => ber = value; }

        public Dolgozo(string nev, string neme, string reszleg, int belepesev, int ber)
        {
            this.Nev = nev;
            this.Neme = neme;
            this.Reszleg = reszleg;
            this.Belepesev = belepesev;
            this.Ber = ber;
        }

    }
}
