using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DirPersonaConfiguration : IEntityTypeConfiguration<DirPersona>
    {
        public void Configure(EntityTypeBuilder<DirPersona> builder)
        {
            builder.ToTable("UbicacionPersona"); 
            builder.HasKey(e => e.Id);
            builder.Property(p => p.Id);

            builder.Property(p => p.TypeOfStreet)
                .HasMaxLength(50); 

            builder.Property(p => p.FirstNumber);

            builder.Property(p => p.Letter)
                .HasMaxLength(2); 

            builder.Property(p => p.Bis)
                .HasMaxLength(10); 

            builder.Property(p => p.SecondLetter)
                .HasMaxLength(2); 

            builder.Property(p => p.Cardinal)
                .HasMaxLength(10); 

            builder.Property(p => p.SecondNumber);

            builder.Property(p => p.ThirdLetter)
                .HasMaxLength(2); 

            builder.Property(p => p.ThirdNumber);

            builder.Property(p => p.SecondCardinal)
                .HasMaxLength(10); 

            builder.Property(p => p.Complement)
                .HasMaxLength(255); 

            builder.Property(p => p.PostalCode)
                .HasMaxLength(10); 

            builder.HasOne(p => p.Ciudades)
                .WithMany(p=>p.Direccion)
                .HasForeignKey(p => p.IdCiudad);

            builder.HasOne(p => p.Personas)
                .WithMany(p=>p.Direccion)
                .HasForeignKey(p => p.IdPersona);

            builder.HasOne(p => p.TiposDirecciones)
                .WithMany(p=>p.Direccion)
                .HasForeignKey(p => p.IdTipoDireccion);

        }
    }
}
