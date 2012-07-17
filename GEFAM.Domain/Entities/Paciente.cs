using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GEFAM.Domain.Entities
{
    public class Paciente
    {
        public int PacinteID { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int CNS { get; set; }
        public int NumeroAPAC { get; set; }
        public DateTime DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public RacaCorEnum RacaCor { get; set; }
        public string NomeMae { get; set; }
        public string NomeResponsavel { get; set; }
        public int TelefoneContato { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual DadosComplementares DadosComplementares { get; set; }

        public virtual ICollection<Solicitacao> Solicitacoes { get; set; }
   }
}
