using GestiuneBileteAvion.Models;
using GestiuneBileteAvion.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace GestiuneBileteAvion.Controllers
{
    public class ClientController : Controller
    {

        public ViewResult Index()
        {
            var clienti = GetClienti();
            return View(clienti);
        }

        public ActionResult DetaliiClient(int id)
        {
            var client = GetClienti().SingleOrDefault(c => c.Id == id);

            if (client == null)
            {
                return HttpNotFound();
            }

            return View(client);
        }

        private IEnumerable<Client> GetClienti()
        {
            return new List<Client>
            {
                new Client { Id = 1, Nume = "Client 1" },
                new Client { Id = 2, Nume = "Client 2" }
            };
        }
    }
}