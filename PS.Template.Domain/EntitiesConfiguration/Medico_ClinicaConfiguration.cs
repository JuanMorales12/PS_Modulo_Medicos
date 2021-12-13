using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Template.Domain.EntitiesConfiguration
{
  /*  public class Medico_ClinicaConfiguration : IEntityTypeConfiguration<Medico_Clinica>
    {
        public void Configure(EntityTypeBuilder<Medico_Clinica> builder)
        {

            builder.HasKey(c => new { c.Medico_id, c.Clinica_id });

            builder.Property(c => c.MedicoId)
                   .IsRequired(true);

            builder.Property(c => c.ClinicaId)
                   .IsRequired(true);



        }
    }*/
}
