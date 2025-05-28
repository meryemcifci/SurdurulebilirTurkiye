using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class GameController : Controller
    {
        //Oyunların hepsinin bulunduğu sayfa..
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CarbonFootprint()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/games/carbon-footprint-game/index.html");
            return PhysicalFile(filePath, "text/html");
        }

        public IActionResult EcoQuiz()
        {
            var filePath = Path.Combine
              (Directory.GetCurrentDirectory(), "wwwroot/games/eco-personality-quiz/index.html");
            return PhysicalFile(filePath, "text/html");
        }

        public IActionResult RecyclingGame()
        {
            var filePath = Path.Combine
              (Directory.GetCurrentDirectory(), "wwwroot/games/recycling-game/index.html");
            return PhysicalFile(filePath, "text/html");
        }

        public IActionResult TrueOrFalse()
        {
            var filePath = Path.Combine
              (Directory.GetCurrentDirectory(), "wwwroot/games/true-or-false/index.html");
            return PhysicalFile(filePath, "text/html");
        }

    }
}
