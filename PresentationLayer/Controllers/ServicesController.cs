using Microsoft.AspNetCore.Mvc;
using SürdürülebilirTürkiye.DataAccessLayer;

namespace PresentationLayer.Controllers
{
    public class ServicesController : Controller
    {
        private readonly Context _context;

        public ServicesController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Surdurulebilirlik()
        {
            return View();
        }
        public IActionResult Biyobozunur()
        {
            var plastics = _context.Plastics.Where(p => p.Description == "Biyobozunur").ToList();
            return View(plastics);
        }
        public IActionResult GeriDonusum()
        {
            var plastics = _context.Plastics.Where(p => p.Description == "GeriDonusum").ToList();
            return View(plastics);
        }
        public IActionResult DogaDostu()
        {
            var plastics = _context.Plastics.Where(p => p.Description == "DogaDostu").ToList();
            return View(plastics);
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
        
    }
}
