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

        [Display(Name = "De la")]
        [Required]
        [StringLength(50)]
        public String LoculPlecarii { get; set; }

        [Display(Name = "Pana la")]
        [Required]
        [StringLength(50)]
        public String LoculSosirii { get; set; }

        [Display(Name = "Data plecarii")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DataPlecarii { get; set; }

        [Required]
        public float Pret { get; set; }
    }
}