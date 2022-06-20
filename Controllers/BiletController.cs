using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
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

        public ViewResult Index(string localitate)
        {
            var bilete = from s in _context.Bilete
                select s;

            if (!String.IsNullOrEmpty(localitate))
            {
                bilete = bilete.Where(s => s.LoculPlecarii.Contains(localitate) || s.LoculSosirii.Contains(localitate));
            }

            return (View(bilete.ToList()));
        }

        public ActionResult BiletNou()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creare(Bilet bilet)
        {
            if (!ModelState.IsValid)
            {
                return View("BiletNou");
            }

            if (bilet.Id == 0)
            {
                _context.Bilete.Add(bilet);
            }
            else
            {
                var biletInDb = _context.Bilete.Single(b => b.Id == bilet.Id);

                biletInDb.LoculPlecarii = bilet.LoculPlecarii;
                biletInDb.LoculSosirii = bilet.LoculSosirii;
                biletInDb.DataPlecarii = bilet.DataPlecarii;
                biletInDb.Pret = bilet.Pret;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Bilet");
        }

        public ActionResult EditareBilet(int id)
        {
            var bilet = _context.Bilete.SingleOrDefault(b => b.Id == id);

            if (bilet == null)
                return HttpNotFound();

            return View(bilet);
        }
    }
}