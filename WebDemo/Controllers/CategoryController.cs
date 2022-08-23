using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebDemo.Controllers
{
    [AllowAnonymous]
    public class CategoryController : Controller
    {
        CategoryMan categoryMan = new CategoryMan(new EfCategoryRepo());
        public IActionResult Index()
        {
            var values = categoryMan.ListAll();
            return View(values);
        }
        
    }
}
