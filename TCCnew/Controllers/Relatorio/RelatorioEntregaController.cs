using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Relatorios;

namespace TCCnew.Controllers.Relatorio
{
    public class RelatorioEntregaController : Controller
    {
        // GET: RelatorioEstoque
        public ActionResult Index()
        {
            var est = RelatorioEntrega.ListarEntrega();
            return View("~/Views/Relatorio/RelatorioEntregaView.cshtml", est);
        }
    }
}