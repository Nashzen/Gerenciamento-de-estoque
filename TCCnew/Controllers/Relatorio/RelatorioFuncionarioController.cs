using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Relatorios;

namespace TCCnew.Controllers.Relatorio
{
    public class RelatorioFuncionarioController : Controller
    {
        public ActionResult Index()
        {
            var funcionarios = RelatorioFuncionario.ListarFuncionarios();
            return View("~/Views/Relatorio/RelatorioFuncionarioView.cshtml", funcionarios);
        }
    }
}