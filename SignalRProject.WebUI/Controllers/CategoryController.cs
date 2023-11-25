using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
