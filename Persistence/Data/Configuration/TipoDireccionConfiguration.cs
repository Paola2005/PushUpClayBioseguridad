using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoDireccionConfiguration : IEntityTypeConfiguration<TipoDireccion>
    {
        public void Configure(EntityTypeBuilder<TipoDireccion> builder)
        {
            builder.ToTable("TipoDireccion");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Descripcion)
        .IsRequired()
        .HasMaxLength(50);


        }
    }
}
