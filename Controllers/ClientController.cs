using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestiuneBileteAvion.Controllers
{
    public class ClientController : Controller
    {
        // GET: Customer
        public ActionResult Lista()
        {
            return View();
        }
    }
}