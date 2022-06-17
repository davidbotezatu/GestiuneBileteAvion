﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestiuneBileteAvion.Models
{
    public class Client
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nume { get; set; }

        [Required]
        [StringLength(50)]
        public string Prenume { get; set; }
        public string Adresa { get; set; }

        [Required]
        [StringLength(13)]
        public string Cnp { get; set; }

        [Required]
        public string TipClient { get; set; }
    }
}