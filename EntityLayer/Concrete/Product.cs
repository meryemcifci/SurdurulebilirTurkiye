using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {

        public int ProductID { get; set; } // Primary Key
        public string ProductName { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float ImpactScore { get; set; }
        public string LifecycleStage { get; set; }
        public DateTime AddedDate { get; set; }
        public string Availability { get; set; }

        public int ProducerID { get; set; } // Foreign Key
        public Producer Producer { get; set; }

    }
}
