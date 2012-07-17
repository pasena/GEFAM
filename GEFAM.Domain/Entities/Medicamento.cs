using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Medicamento
    {
        [Key]
        public int MedicamentoID { get; set; }

        public int Codigo { get; set; }

        [StringLength(250)]
        public string Nome { get; set; }

        [Required]
        public int CIDPrincipal { get; set; }

        public int CIDSecundario { get; set; }

        [StringLength(500)]
        public string Posologia { get; set; }
    }
}
