namespace PresentationLayer.ViewModels
{
    public class CarbonFootprintViewModel
    {
        public double ElectricityConsumption { get; set; }
        public string ElectricitySource { get; set; }
        public double NaturalGasConsumption { get; set; }
        public double CarFuelConsumption { get; set; }
        public string CarFuelType { get; set; }
        public double OtherEmissions { get; set; }
        public double TotalFootprint { get; set; }

        // Lists for dropdown selections
        public List<string> ElectricitySources { get; } = new List<string>
        {
            "Fosil Yakıt",
            "Yenilenebilir Enerji",
            "Karma"
        };

        public List<string> FuelTypes { get; } = new List<string>
        {
            "Benzin",
            "Dizel",
            "LPG",
            "Elektrik"
        };
    }
}
