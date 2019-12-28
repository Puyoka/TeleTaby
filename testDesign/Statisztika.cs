using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class Statisztika
    {
        public string termekNev { get; set; }
        public int kesz { get; set; }
        public int nemKesz { get; set; }
        public int osszesen { get; set; }
        public int osszeg { get; set; }

        public Statisztika(string termekNev, int kesz, int nemKesz, int osszesen, int osszeg)
        {
            this.termekNev = termekNev;
            this.kesz = kesz;
            this.nemKesz = nemKesz;
            this.osszesen = osszesen;
            this.osszeg = osszeg;
        }
    }
}
