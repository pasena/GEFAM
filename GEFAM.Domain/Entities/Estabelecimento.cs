using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Estabelecimento
    {
        public int EstabelecimentoID { get; set; }
        public string Nome { get; set; }
        public string DIRES { get; set; }
        public int CNES { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
