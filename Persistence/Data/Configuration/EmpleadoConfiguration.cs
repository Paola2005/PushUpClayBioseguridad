using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.HasOne(p=>p.Personas)
        .WithMany(p=>p.Empleados)
        .HasForeignKey(p=>p.IdPersona);
        }
    }
}
