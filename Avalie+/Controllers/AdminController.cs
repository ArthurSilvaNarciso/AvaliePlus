using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

[Authorize(Roles = "Admin")] // Apenas usuários com a role "Admin"
public class AdminController : Controller
{
    // Redireciona automaticamente de /Admin para /Admin/Index
    [Route("Admin")]
    public IActionResult RedirectToIndex()
    {
        return RedirectToAction("Index");
    }

    public IActionResult Index()
    {
        return View(); // Carrega a View Index.cshtml da pasta Views/Admin
    }
}
