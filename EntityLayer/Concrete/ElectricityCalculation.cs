using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ElectricityCalculation:BaseEntity
    {
        public int CalculationID { get; set; } // Primary Key
        public string NumberOfPeople { get; set; }
        public decimal ElectricBill { get; set; }
        public decimal AnnualEmission { get; set; }
        public DateTime CalculationDate { get; set; }

    }
}
