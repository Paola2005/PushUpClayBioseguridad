using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Persona");
        builder.HasKey(e=>e.Id);
        builder.Property(e=>e.Id);

        builder.Property(p=>p.Nombre)
        .IsRequired()
        .HasMaxLength(50);

        builder.HasIndex(p=>p.IdPersona)
        .IsUnique();

        builder.Property(p=>p.FechaRegistro);

        builder.HasOne(p=>p.TiposPersonas)
        .WithMany(p=>p.Personas)
        .HasForeignKey(p=>p.IdTipoPersona);

        builder.HasOne(p=>p.Ciudades)
        .WithMany(p=>p.Personas)
        .HasForeignKey(p=>p.IdCiudad);

        }
    }
}
