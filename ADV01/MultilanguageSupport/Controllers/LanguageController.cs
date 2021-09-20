using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace MultilanguageSupport.Controllers
{
    public class LanguageController
        : Controller
    {
        /*
         Uygulamanın dilini değiştirmek için _Layout sayfasına eklediğimiz action bu metodu HTTP Post ile çağırır.
         İstemciye dönecek olan Cookie'ye seçilen Culture bilgisi eklenir.
         */ 
        [HttpPost]
        public IActionResult ChangeLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                    new CookieOptions
                    {
                        Expires = DateTimeOffset.UtcNow.AddDays(1)
                    }
            );
            return LocalRedirect(returnUrl);
        }
    }
}
