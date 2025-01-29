using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class NaturalGasCalculation : BaseEntity
    {
    
        public int CalculationID { get; set; } // Primary Key
        public decimal JanuaryBill { get; set; }
        public decimal AprilBill { get; set; }
        public decimal JulyBill { get; set; }
        public decimal OctoberBill { get; set; }
        public decimal AnnualEmission { get; set; }
        public DateTime CalculationDate { get; set; }


    }
}
