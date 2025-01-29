using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact:BaseEntity
    {
        public int ContactID { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime SentDate { get; set; }

    }
}
