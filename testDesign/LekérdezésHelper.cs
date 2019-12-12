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
        


        public LekérdezésHelper(int id, DateTime idő, string termék, string megjegyzés)
        {
            this.id = id;
            this.idő = idő.TimeOfDay;
            this.termék = termék;
            this.megjegyzés = megjegyzés;
            
        }

        public LekérdezésHelper(int id, TimeSpan idő, string termék, string megjegyzés)
        {
            this.id = id;
            this.idő = idő;
            this.termék = termék;
            this.megjegyzés = megjegyzés;
            
        }
    }
}
