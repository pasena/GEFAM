using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class DadosComplementares
    {
        public int DadosComplementaresID { get; set; }
        public decimal Peso { get; set; }
        public decimal Altura { get; set; }

        public HemofiliaEnum? Hemofilia { get; set; }

        public InibidorEnum? Inibidor { get; set; }

        public decimal? Gestante { get; set; }

        public virtual Transplantado Transplantado { get; set; }
    }
}
