using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class RecyclingContainer
    {
        public int Id { get; set; } // Primary Key
        public string ContainerLocation { get; set; }
        public string ContainerType { get; set; }

        public int CityID { get; set; } // Foreign Key
        public City City { get; set; } 
    }
}
