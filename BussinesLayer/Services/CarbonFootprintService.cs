using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using SürdürülebilirTürkiye.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Services
{
    public class CarbonFootprintService:ICarbonFootprintService
    {
        private readonly Context _context;

        public CarbonFootprintService(Context context)
        {
            _context = context;
        }

        public double CalculateElectricityFootprint(double consumption, string source)
        {
            // Emission factors (kg CO2 per kWh)
            double emissionFactor = source switch
            {
                "Fosil Yakıt" => 0.5, // Higher emissions for fossil fuels
                "Yenilenebilir Enerji" => 0.1, // Lower for renewables
                "Karma" => 0.3, // Medium for mixed sources
                _ => 0.4 // Default value
            };

            return consumption * emissionFactor;
        }

        public double CalculateNaturalGasFootprint(double consumption)
        {
            // Natural gas emission factor (kg CO2 per m³)
            const double emissionFactor = 2.1;
            return consumption * emissionFactor;
        }

        public double CalculateCarFootprint(double consumption, string fuelType)
        {
            // Emission factors (kg CO2 per liter)
            double emissionFactor = fuelType switch
            {
                "Benzin" => 2.3,
                "Dizel" => 2.7,
                "LPG" => 1.6,
                "Elektrik" => 0, // Electric cars have zero direct emissions
                _ => 2.3 // Default to gasoline
            };

            return consumption * emissionFactor;
        }

        public double CalculateOtherFootprint(double otherEmissions)
        {
            return otherEmissions;
        }

        public double CalculateTotalFootprint(CarbonFootprintCalculation calculation)
        {
            double electricityFootprint = CalculateElectricityFootprint(calculation.ElectricityConsumption, calculation.ElectricitySource);
            double naturalGasFootprint = CalculateNaturalGasFootprint(calculation.NaturalGasConsumption);
            double carFootprint = CalculateCarFootprint(calculation.CarFuelConsumption, calculation.CarFuelType);
            double otherFootprint = CalculateOtherFootprint(calculation.OtherEmissions);

            return electricityFootprint + naturalGasFootprint + carFootprint + otherFootprint;
        }

        public async Task<CarbonFootprintCalculation> SaveCalculationAsync(CarbonFootprintCalculation calculation, string userId)
        {
            calculation.UserId = userId;
            calculation.CalculationDate = DateTime.Now;
            calculation.TotalFootprint = CalculateTotalFootprint(calculation);

            _context.CarbonFootprintCalculations.Add(calculation);
            await _context.SaveChangesAsync();

            return calculation;
        }

        public async Task<IEnumerable<CarbonFootprintCalculation>> GetUserCalculationsAsync(string userId)
        {
            return await _context.CarbonFootprintCalculations
                .Where(c => c.UserId == userId)
                .OrderByDescending(c => c.CalculationDate)
                .ToListAsync();
        }

        public async Task<CarbonFootprintCalculation> GetCalculationByIdAsync(int id)
        {
            return await _context.CarbonFootprintCalculations.FindAsync(id);
        }
    }
}
