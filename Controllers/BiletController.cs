using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GestiuneBileteAvion.Models;
using GestiuneBileteAvion.ViewModel;

namespace GestiuneBileteAvion.Controllers
{
    public class BiletController : Controller
    {
        public ViewResult Index()
        {
            var bilet = GetBilete();
            return View(bilet);
        }

        public ActionResult DetaliiBilet(int id)
        {
            var client = GetBilete().SingleOrDefault(b => b.Id == id);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }

        private IEnumerable<Bilet> GetBilete()
        {
            return new List<Bilet>
            {
                new Bilet { Id = 1, LoculPlecarii = "Bucuresti", LoculSosirii = "Timisoara", Data = "12/03/2020", Pret = 120 },
                new Bilet { Id = 2, LoculPlecarii = "Timisoara", LoculSosirii = "Bucuresti", Data = "12/03/2020", Pret = 120 }
            };
        }
    }
}