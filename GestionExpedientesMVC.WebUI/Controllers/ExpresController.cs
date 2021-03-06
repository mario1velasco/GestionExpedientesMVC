﻿using GestionExpedientesMVC.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionExpedientesMVC.WebUI.Controllers
{
    public class ExpresController : Controller
    {
        private IExprsRepository repository;
        public ExpresController(IExprsRepository iRepository)
        {
            repository = iRepository;
        }

        public ActionResult Index(int pResultado=0)
        {
            int resultado = pResultado;
            if (resultado == 0)
            {
                return View(repository.Expres);
            }
            else
            {
                return View(repository.Expres.Where(p => p.ID == resultado));
            }
            //return View(repository.Expres);
        }

        [HttpPost]
        public ViewResult Filtrado(int pResultado)
        {
            int resultado = pResultado;
            //NO FUNCIONA PORQUE AJAX SOLO VUELVE A LA MISMA VISTA
            return View("Index", repository.Expres.Where(p => p.ID == pResultado));

            //return View(repository.Expres.Where(p => p.ID == Convert.ToInt32(name)));

        }
    }
}