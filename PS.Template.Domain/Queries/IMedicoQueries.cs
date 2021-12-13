using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Template.AccessData.Queries
{
    public interface IMedicoQueries
    {
        Task<List<Medico>> GetAllMedico();
        Task<List<Medico>> GetMedicoById(int id);
        Task<List<Medico>> GetAllMedicoByEspecialidadId(int especialidadId);
        Task<List<Medico>> GetAllMedicoByPartidoId(int partidoId);
        Task<List<Medico>> GetAllMedicoByClinicaId(int id);
        Task<List<Medico>> GetAllMedicoByClinicaYespecialidad(int clinicaid,int especialidadId);

    }
}
