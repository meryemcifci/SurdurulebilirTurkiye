using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarbonFootprintCalculation
    {
        [Key]
        public int FootprintId { get; set; }

        public string UserId { get; set; }

        [Display(Name = "Aylık Elektrik Tüketimi (kWh)")]
        public double ElectricityConsumption { get; set; }

        [Display(Name = "Elektrik Kaynağı")]
        public string ElectricitySource { get; set; }

        [Display(Name = "Aylık Doğalgaz Tüketimi (m³)")]
        public double NaturalGasConsumption { get; set; }

        [Display(Name = "Araç Yakıt Tüketimi (Lt)")]
        public double CarFuelConsumption { get; set; }

        [Display(Name = "Araç Yakıt Tipi")]
        public string CarFuelType { get; set; }

        [Display(Name = "Diğer Emisyon Kaynakları")]
        public double OtherEmissions { get; set; }

        [Display(Name = "Toplam Karbon Ayak İzi (kg CO2)")]
        public double TotalFootprint { get; set; }

        public DateTime CalculationDate { get; set; }
    }
}
