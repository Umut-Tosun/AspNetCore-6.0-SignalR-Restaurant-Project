using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.WebUI.Controllers
{
    public class SignalRDefault : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
