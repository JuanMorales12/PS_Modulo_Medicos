using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PS.Template.Domain.DTOs
{
    public class MedicoDTO
    {
        public int MedicoId { get; set; }
        public int UsuarioId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DNI { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Matricula { get; set; }
        public int EspecialidadId { get; set; }
        public int ClinicaId { get; set; }

        public int PartidoId { get; set; }

    }
}
