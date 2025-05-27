using Microsoft.AspNetCore.Mvc;

namespace PresentationLayer.Controllers
{
    public class GameController : Controller
    {
            public IActionResult CarbonFootprint() => PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/games/carbon-footprint-game/index.html"), "text/html");

            public IActionResult EcoQuiz() => PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/games/eco-personality-quiz/index.html"), "text/html");

            public IActionResult RecyclingGame() => PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/games/recycling-game/index.html"), "text/html");

            public IActionResult TrueOrFalse() => PhysicalFile(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/games/true-or-false/index.html"), "text/html");
        

    }
}
