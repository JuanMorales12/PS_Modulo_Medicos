using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public interface IEspecialidadService
    {
        public List<EspecialidadDTO> GetAllEspecialidades();

        public EspecialidadDTO GetEspecialidadById(int id);
    }
}
