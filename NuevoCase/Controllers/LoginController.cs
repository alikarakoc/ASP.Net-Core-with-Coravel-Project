using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NuevoCase.Data;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Claims;

namespace NuevoCase.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.Name != null)
            {
                return new RedirectResult("/dashboard/index");
            }
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Login(string Username, string Password, bool Rememberme)
        {
            EfNuevoCase db = new EfNuevoCase();
            var user = db.Users.Where(x => x.Username == Username && x.Password == Password);
            if (user.Any())
            {
                dynamic result = new ExpandoObject();
                result.Status = true;
                result.Message = "Giriş başarılı...";
                var claims = new List<Claim> { new Claim(ClaimTypes.Name, Username) };
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                var props = new AuthenticationProperties();
                props.IsPersistent = Rememberme;
                HttpContext.SignInAsync(principal, props);
                return Json(result);
            }
            else
            {
                dynamic result = new ExpandoObject();
                result.Status = false;
                result.Message = "Kullanıcı adı veya şifre hatalı!";
                return Json(result);
            }
        }
    }
}