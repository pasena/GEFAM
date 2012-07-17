using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Profissional
    {
        [Key]
        public int ProfissionalID { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        public int CPF { get; set; }

        [StringLength(50)]
        public string CPFOrgaoExpedidor { get; set; }

        public int CNS { get; set; }

        [StringLength(50)]
        public string CNSOrgaoExpedidor { get; set; }
    }
}
