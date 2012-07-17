using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class MedicamentoSolicitado
    {
        [Key]
        public int MedicamentoSolicitadoID { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual ICollection<Dispensacao> Dispensacao { get; set; }
    }
}
