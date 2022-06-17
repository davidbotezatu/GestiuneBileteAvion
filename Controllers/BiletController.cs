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
        private ApplicationDbContext _context;

        public BiletController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var bilet = _context.Bilete.ToList();
            return View(bilet);
        }

        public ActionResult DetaliiBilet(int id)
        {
            var client = _context.Bilete.SingleOrDefault(b => b.Id == id);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }
    }
}