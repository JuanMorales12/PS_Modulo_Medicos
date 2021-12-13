
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Partido
    {
        public int PartidoId { get; set; }
        public string Partido_desc { get; set; }
        public IList<Clinica> Clinicas { get; set; }
        public IList<Medico> Medicos { get; set; }

    }
}
