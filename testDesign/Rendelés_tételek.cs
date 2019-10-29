using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    [Table(Name = "rendelés_tételek")]
    class Rendelés_tételek
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int sorsz { get; set; }
        [Column]
        public int rendelésID { get; set; }
        [Column]
        public string termékNév { get; set; }
        [Column]
        public string megjegyzés { get; set; }
        [Column]
        public string felhasználóNév { get; set; }
        [Column]
        public bool státusz { get; set; }

        public Rendelés_tételek()
        {
        }
    }
}
