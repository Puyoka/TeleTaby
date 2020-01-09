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
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column]
        public string név { get; set; }
        [Column]
        public string mértékegység { get; set; }
        [Column]
        public int ár { get; set; }
        [Column]
        public string gyűjtőnév { get; set; }
        [Column]
        public int felhaszID { get; set; }

        public Termék()
        {
        }

        public Termék(string név, string mértékegység, int ár, string gyűjtőnév, int felhaszID)
        {
            this.név = név;
            this.mértékegység = mértékegység;
            this.ár = ár;
            this.gyűjtőnév = gyűjtőnév;
            this.felhaszID = felhaszID;
        }
    }
}
