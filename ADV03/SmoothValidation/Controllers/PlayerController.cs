using Microsoft.AspNetCore.Mvc;
using SmoothValidation.Models;

namespace SmoothValidation.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Player player)
        {
            if(!ModelState.IsValid)
            {
                return View(player);
            }
            // Gelen Player nesne verisi doğrulama adımlarını başarı ile tamamlamışsa buraya gelinir.
            // Burada repository'ye kaydetme işlemleri yapılır. Örneğin konusu açısından şimdilik gerekli değil.
            return Ok();
        }
    }
}
