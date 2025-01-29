using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WaterManagementStrategy
    {
        public int Id { get; set; } // Primary Key
        public string Region { get; set; }
        public string StrategyName { get; set; }
        public string Description { get; set; }
        public DateTime ImplementationDate { get; set; }
    }
}
