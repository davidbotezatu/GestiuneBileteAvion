using GestiuneBileteAvion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


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

        public ActionResult DetaliiClient(int id)
        {
            var client = _context.Clienti.SingleOrDefault(c => c.Id == id);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }
    }
}