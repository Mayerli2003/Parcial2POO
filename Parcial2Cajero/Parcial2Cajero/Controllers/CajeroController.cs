using Parcial2Cajero.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Parcial2Cajero.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult IndexViews()
        {

            return View();
        }
        [HttpPost]
        public ActionResult IndexViews(Cajero p)
        {
            

            if (p.Dato % 5 == 0)
            {

                return Redirect("RetirarDinero");
            }

            return Redirect("Error");


        }
        [HttpGet]
        public ActionResult RetirarDinero()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Error()
        {

            return View();
        }
    }
}