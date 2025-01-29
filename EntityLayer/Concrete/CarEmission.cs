using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarEmission:BaseEntity
    {
        public int EmissionID { get; set; } // Primary Key
        public bool HasCar { get; set; }
        public string FuelType { get; set; }
        public double AnnualMileage { get; set; }
        public double AnnualEmission { get; set; }
        public DateTime CalculationDate { get; set; }

     
    }
}
