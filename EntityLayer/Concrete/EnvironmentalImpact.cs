using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class EnvironmentalImpact:BaseEntity
    {
        public int ImpactID { get; set; } // Primary Key
        public int ProductID { get; set; } // Foreign Key
        public Product Product { get; set; }
        public string ImpactType { get; set; }
        public float ImpactValue { get; set; }
        public DateTime MeasurementDate { get; set; }

        public int CategoryID { get; set; } // Foreign Key
        public CarbonFootprintCategory Category { get; set; }
    }
}
