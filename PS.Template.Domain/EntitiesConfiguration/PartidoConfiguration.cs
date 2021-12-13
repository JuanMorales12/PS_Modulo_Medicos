using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.EntitiesConfiguration
{
    public class PartidoConfiguration : IEntityTypeConfiguration<Partido>
    {
        public void Configure(EntityTypeBuilder<Partido> builder)
        {

            builder.HasKey(c => c.PartidoId);
            builder.Property(c => c.PartidoId)
            .ValueGeneratedOnAdd();

            builder.Property(c => c.Partido_desc)
               .HasColumnType("varchar")
               .IsRequired(true)
               .HasMaxLength(50);

            builder.HasData(
                        new
                        {
                            PartidoId = 1,
                            Partido_desc = "Florencio Varela"
                        },
                        new
                        {
                            PartidoId = 2,
                            Partido_desc = "Quilmes"
                        },
                        new
                        {
                            PartidoId = 3,
                            Partido_desc = "Berazategui"
                        });

        }
    }
}
