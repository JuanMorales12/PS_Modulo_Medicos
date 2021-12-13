using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
    {
        public void Configure(EntityTypeBuilder<Especialidad> builder)
        {

            builder.HasKey(c => c.EspecialidadId);
            builder.Property(c => c.EspecialidadId)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.Especialidad_desc)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.HasData(
                      new
                      {
                          EspecialidadId = 1,
                          Especialidad_desc = "Traumatología"
                      },
                      new
                      {
                          EspecialidadId = 2,
                          Especialidad_desc = "Cardiología"
                      },
                      new
                      {
                          EspecialidadId = 3,
                          Especialidad_desc = "Dermatología"
                      });

        }
    }
}
