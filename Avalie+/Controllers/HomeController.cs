using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(); // Isso usa o layout definido automaticamente.
    }

    public IActionResult Privacy()
    {
        return View(); // Isso tamb�m vai usar o layout.
    }
}
