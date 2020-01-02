using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class MentesRendelesTetel
    {
        public int RendelésID { get; set; }
        public string Név { get; set; }
        public string Mértékegység { get; set; }
        public int Ár { get; set; }
        public string  Megjegyzés { get; set; }

        public MentesRendelesTetel(int rendelésID, string név, string mértékegység, int ár, string megjegyzés)
        {
            RendelésID = rendelésID;
            Név = név;
            Mértékegység = mértékegység;
            Ár = ár;
            Megjegyzés = megjegyzés;
        }
    }
}
