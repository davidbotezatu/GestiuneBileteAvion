using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestiuneBileteAvion.Models
{
    public class Bilet
    {
        public int Id { get; set; }
        public String LoculPlecarii { get; set; }
        public String LoculSosirii { get; set; }
        public String Data { get; set; }
        public float Pret { get; set; }
    }
}