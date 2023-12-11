using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContratoConfiguration : IEntityTypeConfiguration<Contrato>
    {
        public void Configure(EntityTypeBuilder<Contrato> builder)
        {
            builder.ToTable("Contrato");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.FechaContrato);
        builder.Property(p=>p.FechaFin);

        builder.HasOne(p=>p.Clientes)
        .WithMany(p=>p.Contratos)
        .HasForeignKey(p=>p.IdCliente);

        builder.HasOne(p=>p.Empleados)
        .WithMany(p=>p.Contratos)
        .HasForeignKey(p=>p.IdEmpleado);

        builder.HasOne(p=>p.Estados)
        .WithMany(p=>p.Contratos)
        .HasForeignKey(p=>p.IdEstado);
        }
    }
}
