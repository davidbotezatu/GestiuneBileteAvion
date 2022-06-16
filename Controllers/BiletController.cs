using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestiuneBileteAvion.Models;

namespace GestiuneBileteAvion.Controllers
{
    public class BiletController : Controller
    {
        // GET: Oferta
        public ActionResult Lista()
        {
            var test = new Bilet() { LoculPlecarii = "Bucuresti" };
            return View(test);
        }
    }
}