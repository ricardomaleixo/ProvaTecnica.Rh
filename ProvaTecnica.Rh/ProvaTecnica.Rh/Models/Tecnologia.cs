using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaTecnica.Rh.Models
{
    [Table("Tecnologia")]
    public class Tecnologia
    {
        [Key]
        public int idTecnologia { get; set; }

        [Display(Name = "Tecnologia")]
        [Required]
        public string nomeTecnologia { get; set; }

        public int peso { get; set; }

    }
}