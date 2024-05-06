using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.ViewComponents.LayoutViewComponents
{
	public class _LayoutFooterComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
