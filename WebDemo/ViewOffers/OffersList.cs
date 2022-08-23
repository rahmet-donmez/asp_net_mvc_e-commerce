using Microsoft.AspNetCore.Mvc;

namespace WebDemo.ViewComponets
{
    public class OffersList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
