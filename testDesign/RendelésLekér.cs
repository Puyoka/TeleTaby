using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class RendelésLekér
    {
        public int ID { get; set; }
        public TimeSpan Idő { get; set; }
        public string Termék { get; set; }
        public string Megjegyzés { get; set; }
        public string Púlt { get; set; }



        public RendelésLekér(int id, DateTime idő, string termék, string megjegyzés,string pult)
        {
            this.ID = id;
            this.Idő = idő.TimeOfDay;
            this.Termék = termék;
            this.Megjegyzés = megjegyzés;
            this.Púlt = pult;
        }

        public RendelésLekér(int id, TimeSpan idő, string termék, string megjegyzés,string pult)
        {
            this.ID = id;
            this.Idő = idő;
            this.Termék = termék;
            this.Megjegyzés = megjegyzés;
            this.Púlt = pult;
            
        }
    }
}
