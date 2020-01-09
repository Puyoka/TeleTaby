using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDesign
{
    [Table(Name = "felhasználó")]
    class Felhasználó
    {
        [Column(IsDbGenerated = true, IsPrimaryKey = true)]
        public int ID { get; set; }
        [Column(IsPrimaryKey = true)]
        public string név { get; set; }
        [Column(IsPrimaryKey = true)]
        public string jelszó { get; set; }
        [Column]
        public int UI { get; set; }

        public Felhasználó()
        {
        }

        public Felhasználó(string név, string jelszó, int uI)
        {
            this.név = név;
            this.jelszó = jelszó;
            UI = uI;
        }
    }
}
