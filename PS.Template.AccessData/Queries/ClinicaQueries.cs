using Microsoft.EntityFrameworkCore;
using PS.Template.AccessData;
using PS.Template.AccessData.Queries;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Template.AccessData.Queries
{
    public class ClinicaQueries : IClinicaQueries
    { 

        private readonly TemplateDbContext _context;

        public ClinicaQueries(TemplateDbContext context)
        {
            _context = context;
        }

        public async Task<List<Clinica>> GetAllClinica()
        { 

           var clinicas = await _context.Set<Clinica>().ToListAsync();
                                        
            return clinicas;
        }

        public async Task<Clinica> GetClinicaById(int id)
        {

            var clinica = await _context.Set<Clinica>()
                                        .Where(x => x.ClinicaId == id).FirstAsync();

            return clinica;
        }

    }
}
