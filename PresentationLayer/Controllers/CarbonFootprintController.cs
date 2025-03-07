using BussinesLayer.Services;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentationLayer.ViewModels;
using System.Text;

namespace PresentationLayer.Controllers
{
    [Authorize]
    public class CarbonFootprintController : Controller
    {
        private readonly ICarbonFootprintService _carbonService;
        private readonly UserManager<User> _userManager;

        public CarbonFootprintController(
            ICarbonFootprintService carbonService,
            UserManager<User> userManager)
        {
            _carbonService = carbonService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Calculator()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return RedirectToAction("Login", "Account"); // Kullanıcı giriş yapmamışsa yönlendir
            }

            return View(new CarbonFootprintViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Calculate(CarbonFootprintViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Calculator", viewModel);
            }

            var calculation = new CarbonFootprintCalculation
            {
                ElectricityConsumption = viewModel.ElectricityConsumption,
                ElectricitySource = viewModel.ElectricitySource,
                NaturalGasConsumption = viewModel.NaturalGasConsumption,
                CarFuelConsumption = viewModel.CarFuelConsumption,
                CarFuelType = viewModel.CarFuelType,
                OtherEmissions = viewModel.OtherEmissions
            };

            var userId = _userManager.GetUserId(User);
            var savedCalculation = await _carbonService.SaveCalculationAsync(calculation, userId);

            return RedirectToAction("Results", new { id = savedCalculation.FootprintId });
        }

        public async Task<IActionResult> Results(int id)
        {
            var calculation = await _carbonService.GetCalculationByIdAsync(id);

            if (calculation == null || calculation.UserId != _userManager.GetUserId(User))
            {
                return NotFound();
            }

            return View(calculation);
        }

        public async Task<IActionResult> History()
        {
            var userId = _userManager.GetUserId(User);
            var calculations = await _carbonService.GetUserCalculationsAsync(userId);

            return View(calculations);
        }

        public async Task<IActionResult> Download(int id)
        {
            var calculation = await _carbonService.GetCalculationByIdAsync(id);

            if (calculation == null || calculation.UserId != _userManager.GetUserId(User))
            {
                return NotFound();
            }

            var content = new StringBuilder();
            content.AppendLine("Karbon Ayak İzi Hesaplama Sonuçları");
            content.AppendLine("====================================");
            content.AppendLine($"Hesaplama Tarihi: {calculation.CalculationDate}");
            content.AppendLine();
            content.AppendLine($"Elektrik Tüketimi: {calculation.ElectricityConsumption} kWh ({calculation.ElectricitySource})");
            content.AppendLine($"Doğalgaz Tüketimi: {calculation.NaturalGasConsumption} m³");
            content.AppendLine($"Araç Yakıt Tüketimi: {calculation.CarFuelConsumption} Lt ({calculation.CarFuelType})");
            content.AppendLine($"Diğer Emisyonlar: {calculation.OtherEmissions} kg CO2");
            content.AppendLine();
            content.AppendLine($"Toplam Karbon Ayak İzi: {calculation.TotalFootprint:F2} kg CO2");

            byte[] bytes = Encoding.UTF8.GetBytes(content.ToString());

            return File(bytes, "text/plain", $"karbon-ayak-izi-{DateTime.Now:yyyyMMdd}.txt");
        }

        public async Task<IActionResult> Share(int id)
        {
            var calculation = await _carbonService.GetCalculationByIdAsync(id);

            if (calculation == null || calculation.UserId != _userManager.GetUserId(User))
            {
                return NotFound();
            }

            // Generate sharing URL or code (simplified for example)
            var shareCode = Convert.ToBase64String(BitConverter.GetBytes(calculation.FootprintId));

            ViewBag.ShareUrl = Url.Action("SharedResult", "CarbonFootprint",
                new { code = shareCode }, Request.Scheme);

            return View(calculation);
        }

        [AllowAnonymous]
        public async Task<IActionResult> SharedResult(string code)
        {
            // Decode share code to get calculation ID (simplified)
            int id = BitConverter.ToInt32(Convert.FromBase64String(code), 0);

            var calculation = await _carbonService.GetCalculationByIdAsync(id);

            if (calculation == null)
            {
                return NotFound();
            }

            return View(calculation);
        }
    }
}
