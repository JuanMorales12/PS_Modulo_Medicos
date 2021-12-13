using Microsoft.EntityFrameworkCore;
using PS.Template.Domain.Entities;
using PS.Template.Domain.EntitiesConfiguration;

namespace PS.Template.AccessData
{
    public class TemplateDbContext : DbContext
    {

        public TemplateDbContext(DbContextOptions<TemplateDbContext> options) : base(options)
        { }

        public DbSet<Medico> Medico { get; set; }

        public DbSet<Clinica> Clinica { get; set; }

        public DbSet<Especialidad> Especialidad { get; set; }

        public DbSet<Partido> Partido { get; set; }

     //   public DbSet<Medico_Clinica> Medico_Clinica { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Medico>(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration<Clinica>(new ClinicaConfiguration());
            modelBuilder.ApplyConfiguration<Especialidad>(new EspecialidadConfiguration());
            modelBuilder.ApplyConfiguration<Partido>(new PartidoConfiguration());

    //        modelBuilder.ApplyConfiguration<Medico_Clinica>(new Medico_ClinicaConfiguration());
        }

    }
}
