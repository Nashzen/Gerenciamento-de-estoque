using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Relatorios;

namespace TCCnew.Controllers.Relatorio
{
    public class RelatorioEstoqueController : Controller
    {
        // GET: RelatorioEstoque
        public ActionResult Index()
        {
            var est = RelatorioEstoque.ListarEstoque();
            return View("~/Views/Relatorio/RelatorioEstoqueView.cshtml", est);
        }
    }
}