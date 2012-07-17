using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class MedicamentoSolicitado
    {
        public int MedicamentoSolicitadoID { get; set; }
        public virtual Medicamento Medicamento { get; set; }
        public virtual ICollection<Dispensacao> Dispensacao { get; set; }
    }
}
