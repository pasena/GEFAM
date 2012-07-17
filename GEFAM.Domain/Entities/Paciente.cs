using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace GEFAM.Domain.Entities
{
    public class Paciente
    {
        [Key]
        public int PacinteID { get; set; }

        [StringLength(150)]        
        public string Nome { get; set; }

        public int CPF { get; set; }

        public DateTime DataNascimento { get; set; }

        public int Sexo { get; set; }

        public int RacaCor { get; set; }

        [StringLength(150)]        
        public string NomeMae { get; set; }

        [StringLength(150)]        
        public string NomeResponsavel { get; set; }

        public int TelefoneContato { get; set; }

        public virtual Endereco Endereco { get; set; }
           
        public virtual ICollection<Solicitacao> Solicitacoes { get; set; }
   }
}
