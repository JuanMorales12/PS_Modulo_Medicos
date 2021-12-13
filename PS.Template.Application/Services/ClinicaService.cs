using PS.Template.AccessData.Queries;
using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.Application.Services
{
    public class ClinicaService : IClinicaService
    {
        private readonly IGenericsRepository _repository;
        private readonly IClinicaQueries _query;
        public ClinicaService(IGenericsRepository repository,IClinicaQueries queries)
        {
            _repository = repository;
            _query = queries;
        }
        public Clinica CreateClinica(ClinicaDTO sala)
        {
            var entity = new Clinica
            {
                Clinica_desc = sala.Clinica_desc,
                Clinica_direccion = sala.Clinica_direccion,
                PartidoId = sala.PartidoId

            };

            _repository.Add<Clinica>(entity);
            return entity;
        }

        public async Task<List<ClinicaDTO>> GetAllClinica()
        {
            
            var listaDeClinicasDTO = new List<ClinicaDTO>();

            List<Clinica> listaDeClinicas = await _query.GetAllClinica();

            foreach(Clinica elem in listaDeClinicas)
            {
                var clinicaDTO = new ClinicaDTO
                {
                    ClinicaId = elem.ClinicaId,
                    Clinica_desc = elem.Clinica_desc,
                    Clinica_direccion = elem.Clinica_direccion,
                    PartidoId = elem.PartidoId,
                    Imagen = elem.Imagen
                };

                listaDeClinicasDTO.Add(clinicaDTO);

            };

            return listaDeClinicasDTO;

        }

        public async Task<Clinica> GetClinicaById(int id)
        {
            return await _query.GetClinicaById(id);
        }


    }
}
