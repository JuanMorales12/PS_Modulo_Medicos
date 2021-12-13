using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.DTOs
{
    public class ClinicaDTO
    {

        public int ClinicaId { get; set; }
        public string Clinica_desc { get; set; }
        public string Clinica_direccion { get; set; }
        public int PartidoId { get; set; }
        public string Imagen { get; set; }

    }
}
