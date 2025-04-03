using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization; // Garante que a página só pode ser acessada por usuários logados

namespace AvalieMais.Controllers
{
    [Authorize] // Exige que o usuário esteja autenticado para acessar o HomeController
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Username = User.Identity?.Name; // Passa o nome do usuário para a View
            return View();
        }
    }
}
