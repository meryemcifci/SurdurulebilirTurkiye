using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Services
{
    public interface ICarbonFootprintService
    {
        double CalculateElectricityFootprint(double consumption, string source);
        double CalculateNaturalGasFootprint(double consumption);
        double CalculateCarFootprint(double consumption, string fuelType);
        double CalculateOtherFootprint(double otherEmissions);
        double CalculateTotalFootprint(CarbonFootprintCalculation calculation);
        Task<CarbonFootprintCalculation> SaveCalculationAsync(CarbonFootprintCalculation calculation, string userId);
        Task<IEnumerable<CarbonFootprintCalculation>> GetUserCalculationsAsync(string userId);
        Task<CarbonFootprintCalculation> GetCalculationByIdAsync(int id);
    }
}
