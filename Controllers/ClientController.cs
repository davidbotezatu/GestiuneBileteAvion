using GestiuneBileteAvion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;


namespace GestiuneBileteAvion.Controllers
{
    public class ClientController : Controller
    {
        private ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var clienti = _context.Clienti.ToList();
            return View(clienti);
        }


        public ViewResult ClientNou()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creare(Client client)
        {
            _context.Clienti.Add(client);
            _context.SaveChanges();

            return RedirectToAction("Index", "Client");
        }
    }
}