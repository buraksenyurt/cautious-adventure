using EasyMapping.Models;
using EasyMapping.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace EasyMapping.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlayerService _playerService;

        public HomeController(ILogger<HomeController> logger,IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
            // Oyuncularla ilgili servisi enjekte ediyoruz ve Index metodunda kullanarak oyuncu listesini dönüyoruz. İşte o noktada AutoMapper iş başında oluyor.
        }

        public IActionResult Index()
        {
            return View(_playerService.GetPlayers());
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
