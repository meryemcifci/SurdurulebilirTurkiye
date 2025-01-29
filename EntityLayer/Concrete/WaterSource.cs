using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class WaterSource
    {
        public int Id { get; set; } // Primary Key
        public string SourceName { get; set; }
        public string Region { get; set; }
        public float WaterLevel { get; set; }
        public int Year { get; set; }
        public float ChangeRate { get; set; }
        public string EnvironmentalImpact { get; set; }
    }
}
