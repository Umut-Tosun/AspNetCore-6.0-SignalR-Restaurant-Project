using Microsoft.AspNetCore.Mvc;

namespace SignalRProject.WebUI.ViewComponents.LayoutComponents
{
	public class _LayoutScriptsPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
