﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarbonFootprintCategory:BaseEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<EnvironmentalImpact> EnvironmentalImpacts { get; set; }
    }
}
