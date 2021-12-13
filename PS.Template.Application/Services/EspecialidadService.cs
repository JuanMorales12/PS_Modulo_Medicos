using PS.Template.AccessData.Queries;
using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PS.Template.Application.Services
{
    public class EspecialidadService : IEspecialidadService
    {
        private readonly IGenericsRepository _repository;
        private readonly IEspecialidadQueries _query;
        public EspecialidadService(IGenericsRepository repository, IEspecialidadQueries query)
        {
            _repository = repository;
            _query = query;
        }

        public List<EspecialidadDTO> GetAllEspecialidades()
        {

            List<EspecialidadDTO> especialidadesDTO = new List<EspecialidadDTO>();
            List<Especialidad> especialidades;

            especialidades = _query.GetAllEspecialidades();

            foreach (Especialidad elem in especialidades)
            {
                EspecialidadDTO especialidadDTO = new EspecialidadDTO
                {
                    EspecialidadId = elem.EspecialidadId,
                    Especialidad_desc = elem.Especialidad_desc
                };

                especialidadesDTO.Add(especialidadDTO);
            }

            return especialidadesDTO;
        }

        public EspecialidadDTO GetEspecialidadById(int id)
        {

            Especialidad especialidad;

            especialidad = _query.GetEspecialidadById(id);

           EspecialidadDTO especialidadDTO = new EspecialidadDTO
           {
                    EspecialidadId = especialidad.EspecialidadId,
                    Especialidad_desc = especialidad.Especialidad_desc
           };

           return especialidadDTO;
        }
    }
}
