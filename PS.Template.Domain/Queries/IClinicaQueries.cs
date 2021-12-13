using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PS.Template.AccessData.Queries
{
    public interface IClinicaQueries
    {
        Task<List<Clinica>> GetAllClinica();

        public Task<Clinica> GetClinicaById(int id);

    }
}
