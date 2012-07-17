using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Dispensacao
    {
        public int DispensacaoID { get; set; }
        
        public decimal QuantidadeAutorizada { get; set; }
        public DateTime DataAutorizacao { get; set; }

        public decimal? QuantidadeDispensada { get; set; }
        public DateTime? DataDispensa { get; set; }
    }
}
