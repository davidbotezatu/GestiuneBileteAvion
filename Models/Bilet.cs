using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GestiuneBileteAvion.Models
{
    public class Bilet
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public String LoculPlecarii { get; set; }

        [Required]
        [StringLength(50)]
        public String LoculSosirii { get; set; }

        [Required]
        public DateTime DataPlecarii { get; set; }

        [NotMapped]
        public string DataPlecariiShort => DataPlecarii.ToShortDateString();

        [Required]
        public float Pret { get; set; }
    }
}