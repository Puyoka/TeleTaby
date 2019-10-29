using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    [Table(Name = "rendelés")]
    class Rendelés
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column]
        public DateTime idő { get; set; }
        [Column]
        public string felhasználóNév { get; set; }
        [Column]
        public int összeg { get; set; }
        [Column]
        public bool státusz { get; set; }

        public Rendelés()
        {
        }
    }
}
