using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    class MentesRendeles
    {
        public int ID { get; set; }
        public DateTime Idő { get; set; }
        public int Összeg { get; set; }

        public MentesRendeles(int iD, DateTime idő, int összeg)
        {
            ID = iD;
            Idő = idő;
            Összeg = összeg;
        }
    }
}
