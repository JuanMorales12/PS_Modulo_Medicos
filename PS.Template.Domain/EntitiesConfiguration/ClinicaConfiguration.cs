using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class ClinicaConfiguration : IEntityTypeConfiguration<Clinica>
    {
        public void Configure(EntityTypeBuilder<Clinica> builder)
        {

            builder.HasKey(c => c.ClinicaId);
            builder.Property(c => c.ClinicaId)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.Clinica_desc)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.Property(c => c.PartidoId)
                .IsRequired(true);

           builder.HasOne(Par => Par.Partido)
                .WithMany(pe => pe.Clinicas);

            builder.HasData(
                new
                {
                    ClinicaId = 1,
                    Clinica_desc = "Hospital Interzonal El Cruce",
                    PartidoId = 1,
                    Imagen = "https://bit.ly/3w1u9nf"

                },
                new
                {
                    ClinicaId = 2,
                    Clinica_desc = "Clinica Modelo Quilmes",
                    PartidoId = 2,
                    Imagen = "https://bit.ly/3pUaCUF"
                },
                new
                {
                    ClinicaId = 3,
                    Clinica_desc = "Hospital Evita Pueblo",
                    PartidoId = 3,
                    Imagen = "https://bit.ly/3jTVMJU"
                },
                new
                {
                    ClinicaId = 4,
                    Clinica_desc = "Clinica Monte Grande",
                    PartidoId = 2,
                    Imagen = "https://bit.ly/3w66TEO"
                },
                new
                {
                    ClinicaId = 5,
                    Clinica_desc = "Clinica Ranelagh",
                    PartidoId = 1,
                    Imagen = "https://bit.ly/3ExrkgD"
                },
                new
                {
                    ClinicaId = 6,
                    Clinica_desc = "Sanatorio Modelo Adrogue",
                    PartidoId = 3,
                    Imagen = "https://bit.ly/3GGkRSH"
                }

                );
                
        }
    }
}
