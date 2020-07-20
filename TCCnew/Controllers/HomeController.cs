using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models;
using TCCnew.Models.DAL;
using TCCnew.ViewModel;

namespace TCCnew.Controllers
{
    public class HomeController : Controller
    {
        private GamesContext db = new GamesContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Funcionario user)
        {
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Logout()
        {
            Session.Clear();
            Session.Abandon();
            Response.ClearHeaders();
            return RedirectToAction("Login", "Home");
        }

        public ActionResult About()
        {
            ViewBag.Title = "Contagem de funcionários";

            IQueryable<QuantidadeFuncionarios> data = from funcionario in db.Funcionarios
                                                      group funcionario by funcionario.IsAtivo into dateGroup
                                                      select new QuantidadeFuncionarios()
                                                      {
                                                          FuncionariosCount = dateGroup.Count()
                                                      };
            return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}