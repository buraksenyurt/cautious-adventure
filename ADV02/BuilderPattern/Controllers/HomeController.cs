using BuilderPattern.Models;
using BuilderPattern.Models.Concretes;
using BuilderPattern.Models.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace BuilderPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArmyDirector _armyDirector;

        public HomeController(ILogger<HomeController> logger, IArmyDirector armyDirector)
        {
            _logger = logger;
            _armyDirector = armyDirector;
        }

        public IActionResult Index()
        {
            GameCharactersModel model = new();

            var surgentBuilder = new SurgentCharacterBuilder();
            _armyDirector.SetCharacterBuilder(surgentBuilder);
            _armyDirector.BuildSurgent();
            model.SecondOfficer = surgentBuilder.GetCharacter();

            var captainBuilder = new CaptainCharacterBuilder();
            _armyDirector.SetCharacterBuilder(captainBuilder);
            _armyDirector.BuildCaptain();
            model.FirstOfficer = captainBuilder.GetCharacter();

            var medicBuilder = new SurgentCharacterBuilder();
            medicBuilder.BuildBody();
            model.MedicOfficer = medicBuilder.GetCharacter();

            return View(model);
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
