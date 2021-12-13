using PS.Template.Domain.Commands;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using PS.Template.AccessData.Queries;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace PS.Template.Application.Services
{
    public class MedicoService : IMedicoService
    {
        private readonly IGenericsRepository _repository;
        private readonly IMedicoQueries _Queries;
        public MedicoService(IGenericsRepository repository, IMedicoQueries Queries )
        {
            _repository = repository;
            _Queries = Queries;
        }
        public async Task<Medico> CreateMedico(MedicoDTO doctor)
        {
            var entity = new Medico
            {
                Nombre = doctor.Nombre,
                UsuarioId = doctor.UsuarioId,
                Apellido = doctor.Apellido,
                DNI = doctor.DNI,
                Telefono = doctor.Telefono,
                Email = doctor.Email,
                Matricula = doctor.Matricula,
                EspecialidadId = doctor.EspecialidadId,
                ClinicaId = doctor.ClinicaId,
                PartidoId = doctor.PartidoId

            };

            await _repository.Add<Medico>(entity);
            return  entity;
        }

        public async Task<Medico> UpdateMedico(MedicoDTO medicoDTO)
        {

            List<Medico> Doctores = await _Queries.GetMedicoById(medicoDTO.MedicoId);
            Medico medicoActual = Doctores[0];

            if (medicoActual != null)
            {
                medicoActual.Nombre = medicoDTO.Nombre;
                medicoActual.UsuarioId = medicoDTO.UsuarioId;
                medicoActual.Apellido = medicoDTO.Apellido;
                medicoActual.DNI = medicoDTO.DNI;
                medicoActual.Telefono = medicoDTO.Telefono;
                medicoActual.Email = medicoDTO.Email;
                medicoActual.Matricula = medicoDTO.Matricula;
                medicoActual.EspecialidadId = medicoDTO.EspecialidadId;
                medicoActual.ClinicaId = medicoDTO.ClinicaId;
                medicoActual.PartidoId = medicoDTO.PartidoId;

                await _repository.Update<Medico>(medicoActual);
            }
                 
            return medicoActual;
        }


        public async Task<List<Medico>> GetAllMedico()
        {
            return await _Queries.GetAllMedico();
        }

        public async Task<List<Medico>> GetMedicoById(int id)
        {
            return await _Queries.GetMedicoById(id);
        }

        public async Task<List<Medico>> GetAllMedicoByEspecialidadId(int EspecialidadId)
        {
            return await  _Queries.GetAllMedicoByEspecialidadId(EspecialidadId);
        }

        public async Task<List<Medico>> GetAllMedicoByPartidoId(int partidoId)
        {
            return await _Queries.GetAllMedicoByPartidoId(partidoId);
        }

        public async Task<List<Medico>> GetAllMedicoByClinicaId(int id)
        {
            return await _Queries.GetAllMedicoByClinicaId(id);
        }

        public async Task<List<Medico>> GetAllMedicoByClinicaYespecialidad(int id, int id2)
        {
            return await _Queries.GetAllMedicoByClinicaYespecialidad(id, id2);
        }
    }
}
