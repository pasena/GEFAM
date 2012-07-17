using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Estabelecimento
    {
        [Key]
        public int EstabelecimentoID { get; set; }

        [StringLength(250)]
        public string Nome { get; set; }
        
        [StringLength(250)]
        public string DIRES { get; set; }

        public int CNES { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
