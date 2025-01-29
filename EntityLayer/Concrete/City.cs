using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class City
    {
        public int CityID { get; set; } // Primary Key
        public string CityName { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public bool IsMapped { get; set; }

        public ICollection<RecyclingContainer> RecyclingContainers { get; set; }
    }
}
