using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TurnosConfiguration : IEntityTypeConfiguration<Turnos>
    {
        public void Configure(EntityTypeBuilder<Turnos> builder)
        {
            builder.ToTable("Turnos");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.NombreTurno)
        .IsRequired()
        .HasMaxLength(50);
        builder.Property(p=>p.HoraTurnoI);
        builder.Property(p=>p.HoraTurnoF);
        


        }
    }
}
