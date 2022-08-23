using BusinessLayer.Concrete;
using BusinessLayer.EntityFramework;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Validation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;

namespace WebDemo.Controllers
{

    [AllowAnonymous]
    public class ProductController : Controller
    {
        ProductMan pm = new ProductMan(new EfProductRepo());
        public IActionResult Index()
        {
            var values = pm.ListAll();
            return View(values);
        }
        public IActionResult ProductDetails(int id)
        {
            var values = pm.GetById(id);
            return View(values);
        }

        public IActionResult ProductAdd(Product product)
        {
            ProductValidation pv = new ProductValidation();
            ValidationResult result = pv.Validate(product);
            if (result.IsValid)
            {
                pm.ProductAdd(product);
                return RedirectToAction("Index","User");

            }
            else
            {
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }
        public IActionResult ProductListByUserId(int id)
        {
            var values = pm.GetListProductUserId(id);
            return View(values);
        }
        public IActionResult ProductDetailsUser(int id)
        {
            var values = pm.GetById(id);
            return View(values);
        }

    }
}

