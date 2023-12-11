using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Data
{
    public class PushUpClayBioseguridadContext : DbContext
    {
        public PushUpClayBioseguridadContext(DbContextOptions<PushUpClayBioseguridadContext> options) : base(options)
        {
        }
        public DbSet<Ciudad> Ciudades {get;set;}
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<ContactoPersona> ContactoPersonas {get;set;}
        public DbSet<Contrato> Contratos {get;set;}
        public DbSet<Departamento> Departamentos {get;set;}
        public DbSet<DirPersona> DirPersonas {get;set;}
        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<Estado> Estados {get;set;}
        public DbSet<Pais> Paises {get;set;}
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Programacion> Programacions {get;set;}
        public DbSet<TipoContactos> TipoContactos {get;set;}
        public DbSet<TipoDireccion> TipoDireccions {get;set;}
        public DbSet<TipoPersona> TipoPersonas {get;set;}
        public DbSet<Turnos> Turnoss {get;set;}
        public DbSet<User> Users {get;set;}
        public DbSet<Rol> Roles {get;set;}
        public DbSet<UserRol> UsersRoles {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }




        
    }
}
