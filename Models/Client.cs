using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestiuneBileteAvion.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Adresa { get; set; }
        public string Cnp { get; set; }
        public string TipClient { get; set; }
    }
}