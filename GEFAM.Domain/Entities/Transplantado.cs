using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Transplantado
    {
        [Key]
        public int TranplantadoID { get; set; }

        public int Quantidade { get; set; }

        [StringLength(150)]
        public string Orgao { get; set; }

        public DateTime? DataTransplante { get; set; }
    }
}
