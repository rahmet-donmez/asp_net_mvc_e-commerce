using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MyOffer()
        {
            return View();
        }
        public IActionResult MyProductOffer()
        {
            return View();
        }
        public IActionResult MyProducts()
        {
            return View();
        }
    }

}
