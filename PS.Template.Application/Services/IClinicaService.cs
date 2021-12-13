using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.Application.Services
{
    public interface IClinicaService
    {
        Clinica CreateClinica(ClinicaDTO sala);
        Task<List<ClinicaDTO>> GetAllClinica();
        Task <Clinica> GetClinicaById(int id);
    }
}
