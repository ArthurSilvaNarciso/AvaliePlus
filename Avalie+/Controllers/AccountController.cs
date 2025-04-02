using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http; // Necessário para acessar a sessão

namespace AvalieMais.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "123") // Exemplo de validação (substitua pelo banco de dados)
            {
                HttpContext.Session.SetString("User", username);
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Usuário ou senha inválidos!";
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            return RedirectToAction("Login");
        }
    }
}
