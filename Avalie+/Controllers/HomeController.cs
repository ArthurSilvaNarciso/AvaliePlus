using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; // Garante que a p�gina s� pode ser acessada por usu�rios logados

namespace AvalieMais.Controllers
{
    [Authorize] // Exige que o usu�rio esteja autenticado para acessar o HomeController
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Username = User.Identity?.Name; // Passa o nome do usu�rio para a View
            return View();
        }
    }
}
