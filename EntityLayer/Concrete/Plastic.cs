using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Plastic
    {
        public int PlasticID { get; set; } // Primary Key
        public string PlasticName { get; set; }
        public string Description { get; set; }
        public string ProductionProcess { get; set; }
        public decimal Cost { get; set; }
        public float EnvironmentalImpact { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
