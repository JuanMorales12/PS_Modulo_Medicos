using PS.Template.AccessData;
using PS.Template.AccessData.Queries;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Template.AccessData.Queries
{
    public class EspecialidadQueries : IEspecialidadQueries
    { 

        private readonly TemplateDbContext _context;

        public EspecialidadQueries(TemplateDbContext context)
        {
            _context = context;
        }

        public List<Especialidad> GetAllEspecialidades()
        {
            List<Especialidad> especialidades;


            especialidades = _context.Set<Especialidad>().ToList();
                                        

            return especialidades;
        }

        public Especialidad GetEspecialidadById(int id)
        {
            Especialidad especialidad;


            especialidad = _context.Set<Especialidad>()
                                    .Where(x => x.EspecialidadId == id).First();


            return especialidad;
        }

    }
}
