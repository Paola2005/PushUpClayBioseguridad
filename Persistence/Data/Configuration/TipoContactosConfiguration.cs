using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class TipoContactosConfiguration : IEntityTypeConfiguration<TipoContactos>
    {
        public void Configure(EntityTypeBuilder<TipoContactos> builder)
        {
            builder.ToTable("TipoContactos");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Descripcion)
        .IsRequired()
        .HasMaxLength(50);


        }
    }
}
