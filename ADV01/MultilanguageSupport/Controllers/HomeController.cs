using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using MultilanguageSupport.Models;
using System.Diagnostics;

namespace MultilanguageSupport.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // Metin içeriklerine çoklu dil desteğini IStringLocalizer tipini Controller sınıfına enjekte ederek kullanabiliriz
        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(ILogger<HomeController> logger,IStringLocalizer<HomeController> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            // ViewData üstünden resx dosyalarındaki değerleri View tarafına taşıyabiliriz
            ViewData["PageTitle"] = _stringLocalizer["page.title"].Value;
            ViewData["PageDescription"] = _stringLocalizer["page.description"].Value;
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
