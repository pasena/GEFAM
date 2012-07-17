using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Medicamento
    {
        public int MedicamentoID { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }

        public int CIDPrincipal { get; set; }
        public int CIDSecundario { get; set; }

        public string Posologia { get; set; }
    }
}
