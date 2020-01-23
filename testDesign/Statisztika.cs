using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class Statisztika
    {
        public string Név { get; set; }
        public int Elkészült { get; set; }
        public int Folyamatban { get; set; }
        public int Összesen { get; set; }
        public int Összeg { get; set; }

        public Statisztika(string termekNev, int kesz, int nemKesz, int osszesen, int osszeg)
        {
            this.Név = termekNev;
            this.Folyamatban = kesz;
            this.Elkészült = nemKesz;
            this.Összesen = osszesen;
            this.Összeg = osszeg;
        }
    }
}
