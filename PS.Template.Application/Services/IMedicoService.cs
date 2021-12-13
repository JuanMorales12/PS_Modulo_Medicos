using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.Application.Services
{
    public interface IMedicoService
    {
        Task<Medico> CreateMedico(MedicoDTO doctor);
        Task<Medico> UpdateMedico(MedicoDTO medicoDTO);
        Task<List<Medico>> GetAllMedico();
        Task<List<Medico>> GetMedicoById(int id);
        Task<List<Medico>> GetAllMedicoByEspecialidadId(int EspecialidadId);
        Task<List<Medico>> GetAllMedicoByPartidoId(int partidoId);
        Task<List<Medico>> GetAllMedicoByClinicaId(int id);
        Task<List<Medico>> GetAllMedicoByClinicaYespecialidad(int id,int id2);
    }
}
