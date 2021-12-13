
using System.Collections.Generic;

namespace PS.Template.Domain.Entities
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Telefono { get; set; }
        public int? PartidoId { get; set; }
        public string Email { get; set; }        
        public string Matricula { get; set; }
        public int EspecialidadId { get; set; }
        public int ClinicaId { get; set; }

        public Partido Partido { get; set; }
        public Clinica Clinica { get; set; }

    }
}