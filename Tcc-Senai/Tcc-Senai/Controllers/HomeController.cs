using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TCC_Senai.Models;

namespace TCC_Senai.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        //Método para direcionar para a tela do login
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //Método para logar
        [HttpPost]
        public ActionResult Login(User login, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            var valid = (login.UserName == "leo" && login.Password == "123");

            if (valid)
            {
                FormsAuthentication.SetAuthCookie(login.UserName , login.IsActive);
                if (Url.IsLocalUrl(returnUrl))
                {
                    return Redirect(returnUrl);
                }
                else
                {
                    RedirectToAction("Home", "Login");
                }
            }
            else
            {
                ModelState.AddModelError("", "Login Invalido.");
            }
            return View(login);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}