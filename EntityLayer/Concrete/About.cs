using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        
        public int AboutID { get; set; }
        public string Mission { get; set; }
        public string Vision { get; set; }
    }
}
