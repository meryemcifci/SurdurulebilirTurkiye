using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SupportProgram
    {
        public int Id { get; set; } // Primary Key
        public string ProgramName { get; set; }
        public string Description { get; set; }
        public string EligibilityCriteria { get; set; }
        public DateTime ApplicationDeadline { get; set; }
    }
}
