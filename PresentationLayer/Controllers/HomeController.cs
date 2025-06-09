using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PresentationLayer.Models;
using SürdürülebilirTürkiye.DataAccessLayer;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly Context _context;

        public HomeController(ILogger<HomeController> logger, Context context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var goals = _context.SustainabilityGoals.ToList();
            return View(goals);
        }

        public async Task<IActionResult>GetDescription(int id)
        {
            //var goal = _context.SustainabilityGoals.FirstOrDefault(x => x.Id == id);
            //if (goal == null)
            //    return NotFound();

            //return PartialView("_GoalDescriptionPartial", goal);
            var goal = await _context.SustainabilityGoals.FindAsync(id);
            if (goal == null)
            {
                return Content("Açıklama bulunamadı.");
            }

            return PartialView("_GoalDescription", goal);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
