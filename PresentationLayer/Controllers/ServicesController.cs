using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Surdurulebilirlik()
        {
            return View();
        }
        public IActionResult CevreDostuPlastikler()
        {
            return View();
        }
        public IActionResult NeredeGeriDonusturebilirim()
        {
            return View();
        }
        public IActionResult KarbonAyakIzi()
        {
            return View();
        }
        public IActionResult SuKaynaklari()
        {
            return View();
        }
        public IActionResult BolgeselEkonomi()
        {
            return View();
        }
    }
}
