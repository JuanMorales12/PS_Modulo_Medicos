using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS.Template.AccessData.Queries
{
    public class MedicoQueries : IMedicoQueries
    {
        private readonly TemplateDbContext _context;

        public MedicoQueries(TemplateDbContext db)
        {
            _context = db;
        }

        public async Task<List<Medico>> GetAllMedicoByClinicaId(int id)
        {
            var medicos = await _context.Medico.Where(e => e.ClinicaId == id).ToListAsync();

           return medicos;

        }

        
        public async Task<List<Medico>> GetAllMedicoByEspecialidadId(int especialId)
        {
            var Medicos = await _context.Medico.Where(me => me.EspecialidadId == especialId).ToListAsync();
            
            return Medicos;
        }

        public async Task<List<Medico>> GetMedicoById(int id)
        {
            var Doctor = await _context.Medico.Where(a => a.MedicoId == id).ToListAsync();

            return Doctor;
        }

        public async Task<List<Medico>> GetAllMedicoByPartidoId(int partidoId)
        {
            var doctor = await _context.Medico.Where(a => a.PartidoId == partidoId).ToListAsync() ;
            return doctor;

        }

        public async Task<List<Medico>> GetAllMedico()
        {
            var Medicos = await _context.Medico.ToListAsync();
            return Medicos;
                                                                   
        }

        public async Task<List<Medico>> GetAllMedicoByClinicaYespecialidad(int id, int id2)
        {
            var medicos = await _context.Medico.Where(e => e.ClinicaId == id && e.EspecialidadId == id2).ToListAsync();

            return medicos;
        }
    }
}
