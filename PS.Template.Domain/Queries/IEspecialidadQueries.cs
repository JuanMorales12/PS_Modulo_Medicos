using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Template.AccessData.Queries
{
    public interface IEspecialidadQueries
    {
        public List<Especialidad> GetAllEspecialidades();

        public Especialidad GetEspecialidadById(int id);

    }
}
