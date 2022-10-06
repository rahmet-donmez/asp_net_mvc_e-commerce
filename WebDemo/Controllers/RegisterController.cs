using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using BusinessLayer.Validation;
using Entity.Concrete;
using BusinessLayer.EntityFramework;
using FluentValidation.Results;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace WebDemo.Controllers
{
    public class RegisterController : Controller
    {
        UserMan um=new UserMan(new EfUserRepo());
        
        [HttpGet]
        [AllowAnonymous]

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]

        public IActionResult Index(User user)
        {
            UserValidation pv = new UserValidation();
            ValidationResult result = pv.Validate(user);
            if (result.IsValid)
            {
                um.TAdd(user);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
           
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task< IActionResult> Login(User user)
        {
            Context context = new Context();
            var value = context.Users.FirstOrDefault(x => x.UserEmail == user.UserEmail
             && x.UserPassword == user.UserPassword);
            if (value != null)
            {
               /* var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,user.UserEmail)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                //await HttpContext.SignInAsync(principal);*/

               HttpContext.Session.SetString("UserEmail",user.UserEmail);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return RedirectToAction("Index", "Register");
            }


            /*Context context=new Context();
            var value=context.Users.FirstOrDefault(x =>x.UserEmail==user.UserEmail
             && x.UserPassword==user.UserPassword);
            if (value!=null)
            {
                HttpContext.Session.SetString("username", user.UserEmail);
                return RedirectToAction("Index", "User");
            }
            else
            {
                return View();
            }*/


        }
    }
}
