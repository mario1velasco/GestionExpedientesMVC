using GestionExpedientesMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionExpedientesMVC.WebUI.Controllers
{
    public class JScriptController : Controller
    {
        private IExprsRepository repository;
        public JScriptController(IExprsRepository iRepository)
        {
            repository = iRepository;
        }
        // GET: JScript
        public ActionResult Index()
        {
            return View(repository.Expres);
        }

        [HttpPost]
        public ViewResult FiltrarID(int pResultado)
        {
            int resultado = pResultado;
            //NO FUNCIONA PORQUE AJAX SOLO VUELVE A LA MISMA VISTA
            return View("Index", repository.Expres.Where(p => p.ID == pResultado));

            //return View(repository.Expres.Where(p => p.ID == Convert.ToInt32(name)));

        }
    }
}