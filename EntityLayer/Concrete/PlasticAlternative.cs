using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PlasticAlternative
    {
        public int Id { get; set; } // Primary Key
        public string AlternativeName { get; set; }
        public string Description { get; set; }
        public float RecyclingRate { get; set; }

        public int PlasticID { get; set; } // Foreign Key
        public Plastic Plastic { get; set; }

    }
}
