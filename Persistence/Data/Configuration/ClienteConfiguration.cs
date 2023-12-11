using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.HasOne(p=>p.Personas)
        .WithMany(p=>p.Clientes)
        .HasForeignKey(p=>p.IdPersona);
        }
    }
}
