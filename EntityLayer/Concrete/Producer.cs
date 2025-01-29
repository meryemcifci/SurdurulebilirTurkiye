using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Producer
    {
        public int ProducerID { get; set; } // Primary Key
        public string ProducerName { get; set; }
        public string Location { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public bool SupportNeeded { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
