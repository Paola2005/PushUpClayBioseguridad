using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ProgramacionConfiguration : IEntityTypeConfiguration<Programacion>
    {
        public void Configure(EntityTypeBuilder<Programacion> builder)
        {
            builder.ToTable("Programacion");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.HasOne(p=>p.Contratos)
        .WithMany(p=>p.Programaciones)
        .HasForeignKey(p=>p.IdContrato);

        builder.HasOne(p=>p.Turnoss)
        .WithMany(p=>p.Programaciones)
        .HasForeignKey(p=>p.IdTurno);

        builder.HasOne(p=>p.Empleados)
        .WithMany(p=>p.Programaciones)
        .HasForeignKey(p=>p.IdEmpleado);
        }
    }
}
