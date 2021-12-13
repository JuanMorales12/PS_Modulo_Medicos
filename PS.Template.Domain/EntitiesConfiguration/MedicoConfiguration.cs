using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {

            builder.HasKey(c => c.MedicoId);
            builder.Property(c => c.MedicoId)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.Nombre)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(c => c.Apellido)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(c => c.EspecialidadId)
                .IsRequired(true);

/*            builder.Property(c => c.PartidoId)
                .IsRequired(true);*/

            builder.Property(c => c.DNI)
                .HasMaxLength(8)
                .IsRequired(true);

            builder.Property(c => c.Telefono)
                .HasMaxLength(15)
                .IsRequired(true);

            builder.Property(c => c.Email)
               .HasMaxLength(20)
               .IsRequired(true);

            builder.Property(c => c.Matricula)
               .HasMaxLength(20)
               .IsRequired(true);


            builder.Property(c => c.ClinicaId)
               .IsRequired(true);

            builder.HasOne(Par => Par.Partido)
                .WithMany(pe => pe.Medicos);

            builder.HasData(
                      new
                      {
                          MedicoId = 1,
                          Apellido = "Perez",
                          ClinicaId = 1,
                          DNI = "11111111",
                          Email = "doctor1@gmail.com",
                          EspecialidadId = 1,
                          Matricula = "123564",
                          Nombre = "Juan",
                          PartidoId = 1,
                          Telefono = "123456789",
                          UsuarioId = 0
                      },
                      new
                      {
                          MedicoId = 2,
                          Apellido = "Medic",
                          ClinicaId = 1,
                          DNI = "11111123",
                          Email = "doctor2@gmail.com",
                          EspecialidadId = 2,
                          Matricula = "120000",
                          Nombre = "Tito",
                          PartidoId = 3,
                          Telefono = "123456666",
                          UsuarioId = 1
                      });

        }
    }
}
