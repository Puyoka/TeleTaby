using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class LekérdezésHelper
    {
        public int id { get; set; }
        public TimeSpan idő { get; set; }
        public string termék { get; set; }
        public string megjegyzés { get; set; }
        public string felhasználó { get; set; }


        public LekérdezésHelper(int id, DateTime idő, string termék, string megjegyzés, string felhasználó)
        {
            this.id = id;
            this.idő = idő.TimeOfDay;
            this.termék = termék;
            this.megjegyzés = megjegyzés;
            this.felhasználó = felhasználó;            
        }

        public LekérdezésHelper(int id, TimeSpan idő, string termék, string megjegyzés, string felhasználó)
        {
            this.id = id;
            this.idő = idő;
            this.termék = termék;
            this.megjegyzés = megjegyzés;
            this.felhasználó = felhasználó;
        }
    }
}
