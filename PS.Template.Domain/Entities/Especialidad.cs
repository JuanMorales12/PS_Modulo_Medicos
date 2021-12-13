using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.Entities
{
    public class Especialidad
    {
        public int EspecialidadId { get; set; }
        public string Especialidad_desc { get; set; }

        public IList<Medico> Medicos { get; set; }
    }
}
