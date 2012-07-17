using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class DadoComplementar
    {
        [Key]
        public int DadosComplementaresID { get; set; }

        public decimal Peso { get; set; }

        public decimal Altura { get; set; }

        public int? Hemofilia { get; set; }

        public int? Inibidor { get; set; }

        public decimal? Gestante { get; set; }

        public virtual Transplantado Transplantado { get; set; }
    }
}
