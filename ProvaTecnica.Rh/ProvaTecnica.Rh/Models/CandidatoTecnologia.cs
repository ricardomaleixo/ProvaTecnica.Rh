using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProvaTecnica.Rh.Models
{
    [Table("CandidatoTecnologia")]
    public class CandidatoTecnologia
    {
       [Key]
       public int idCandidatoTecnologia { get; set; }

       public virtual Candidato Candidato { get; set; }

       [ForeignKey("Candidato")]
       public int idCandidato { get; set; }

        public virtual Vaga Vaga{ get; set; }
        
        public int idVaga{ get; set; }

        public virtual Tecnologia Tecnologia { get; set; }
        public int idTecnologia { get; set; }

    }
}