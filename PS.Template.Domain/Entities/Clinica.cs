
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Clinica
    {
        public int ClinicaId { get; set; }   
        public string Clinica_desc { get; set; }
        public string Clinica_direccion { get; set; }
        public int PartidoId { get; set; }
        public string Imagen { get; set; }

        public Partido Partido { get; set; }
        public IList<Medico> Medicos { get; set; }
        
    }
}
