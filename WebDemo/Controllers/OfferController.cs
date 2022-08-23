using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Entity.Concrete;

namespace WebDemo.Controllers
{
    public class OfferController : Controller
    {
        OfferMan om = new OfferMan(new EfOfferRepo());

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult PartialAddOffer()
        {
            return PartialView();
        }
        [HttpPost]

        public IActionResult PartialAddOffer(Offer offer)
        {
            om.TAdd(offer);
            return RedirectToAction("Index", "User");
        }
        public IActionResult OfferListByProduct(int id)
        {
            var values=om.GetListOffer(id);
            return View(values);
        }
        public IActionResult OfferListByUser(int id)
        {
            var values = om.GetListOfferByUser(id);
            return View(values);
        }
    }
}
