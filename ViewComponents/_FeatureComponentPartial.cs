using Microsoft.AspNetCore.Mvc;
using MyPortolioUdemy.DAL.Context;

namespace MyPortolioUdemy.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyProtfolioContext protfolioContext = new MyProtfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = protfolioContext.Features.ToList();
            return View(values);
        }
    }
}
