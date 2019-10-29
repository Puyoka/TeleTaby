using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    [Table(Name = "termék")]
    class Termék
    {
        [Column(IsDbGenerated = false, IsPrimaryKey = true)]
        public string név { get; set; }
        [Column(IsPrimaryKey = true)]
        public string mértékegység { get; set; }
        [Column]
        public int ár { get; set; }
        [Column]
        public string gyűjtőnév { get; set; }
        [Column]
        public int felhaszID { get; set; }


    }
}
