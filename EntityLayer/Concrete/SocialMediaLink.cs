using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SocialMediaLink
    {
        public int Id { get; set; } // Primary Key
        public string Platform { get; set; }
        public string Url { get; set; }
    }
}
