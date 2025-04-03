using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Necess�rio para acessar a sess�o

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
