using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Necessário para acessar a sessão

namespace AvalieMais.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("User") == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View();
        }
    }
}
