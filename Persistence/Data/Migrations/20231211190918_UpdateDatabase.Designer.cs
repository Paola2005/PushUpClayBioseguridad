﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence.Data;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(PushUpClayBioseguridadContext))]
    [Migration("20231211190918_UpdateDatabase")]
    partial class UpdateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentosId")
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("NombreCiudad")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentosId");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int?>("PersonasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonasId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContacto")
                        .HasColumnType("int");

                    b.Property<int?>("PersonasId")
                        .HasColumnType("int");

                    b.Property<int?>("TiposContactosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonasId");

                    b.HasIndex("TiposContactosId");

                    b.ToTable("ContactoPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClientesId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadosId")
                        .HasColumnType("int");

                    b.Property<int?>("EstadosId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaContrato")
                        .HasColumnType("date");

                    b.Property<DateOnly>("FechaFin")
                        .HasColumnType("date");

                    b.Property<int>("IdCliente")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdEstado")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClientesId");

                    b.HasIndex("EmpleadosId");

                    b.HasIndex("EstadosId");

                    b.ToTable("Contratos");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("NombreDepa")
                        .HasColumnType("longtext");

                    b.Property<int?>("PaisesId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisesId");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.DirPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Bis")
                        .HasColumnType("longtext");

                    b.Property<string>("Cardinal")
                        .HasColumnType("longtext");

                    b.Property<int?>("CiudadesId")
                        .HasColumnType("int");

                    b.Property<string>("Complement")
                        .HasColumnType("longtext");

                    b.Property<int>("FirstNumber")
                        .HasColumnType("int");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDireccion")
                        .HasColumnType("int");

                    b.Property<string>("Letter")
                        .HasColumnType("longtext");

                    b.Property<int?>("PersonasId")
                        .HasColumnType("int");

                    b.Property<string>("PostalCode")
                        .HasColumnType("longtext");

                    b.Property<string>("SecondCardinal")
                        .HasColumnType("longtext");

                    b.Property<string>("SecondLetter")
                        .HasColumnType("longtext");

                    b.Property<int>("SecondNumber")
                        .HasColumnType("int");

                    b.Property<string>("ThirdLetter")
                        .HasColumnType("longtext");

                    b.Property<int>("ThirdNumber")
                        .HasColumnType("int");

                    b.Property<int?>("TiposDireccionesId")
                        .HasColumnType("int");

                    b.Property<string>("TypeOfStreet")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CiudadesId");

                    b.HasIndex("PersonasId");

                    b.HasIndex("TiposDireccionesId");

                    b.ToTable("DirPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int?>("PersonasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonasId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NombrePais")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Paises");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CiudadesId")
                        .HasColumnType("int");

                    b.Property<DateOnly>("FechaRegistro")
                        .HasColumnType("date");

                    b.Property<int>("IdCiudad")
                        .HasColumnType("int");

                    b.Property<int>("IdPersona")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersona")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext");

                    b.Property<int?>("TiposPersonasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadesId");

                    b.HasIndex("TiposPersonasId");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ContratosId")
                        .HasColumnType("int");

                    b.Property<int?>("EmpleadosId")
                        .HasColumnType("int");

                    b.Property<int>("IdContrato")
                        .HasColumnType("int");

                    b.Property<int>("IdEmpleado")
                        .HasColumnType("int");

                    b.Property<int>("IdTurno")
                        .HasColumnType("int");

                    b.Property<int?>("TurnossId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ContratosId");

                    b.HasIndex("EmpleadosId");

                    b.HasIndex("TurnossId");

                    b.ToTable("Programacions");
                });

            modelBuilder.Entity("Domain.Entities.TipoContactos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoContactos");
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoDireccions");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TipoPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Turnos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<TimeOnly>("HoraTurnoF")
                        .HasColumnType("time(6)");

                    b.Property<TimeOnly>("HoraTurnoI")
                        .HasColumnType("time(6)");

                    b.Property<string>("NombreTurno")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Turnoss");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamentos")
                        .WithMany("Ciudades")
                        .HasForeignKey("DepartamentosId");

                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("Clientes")
                        .HasForeignKey("PersonasId");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.ContactoPersona", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("PersonasId");

                    b.HasOne("Domain.Entities.TipoContactos", "TiposContactos")
                        .WithMany("ContactosPersonas")
                        .HasForeignKey("TiposContactosId");

                    b.Navigation("Personas");

                    b.Navigation("TiposContactos");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Clientes")
                        .WithMany("Contratos")
                        .HasForeignKey("ClientesId");

                    b.HasOne("Domain.Entities.Empleado", "Empleados")
                        .WithMany("Contratos")
                        .HasForeignKey("EmpleadosId");

                    b.HasOne("Domain.Entities.Estado", "Estados")
                        .WithMany("Contratos")
                        .HasForeignKey("EstadosId");

                    b.Navigation("Clientes");

                    b.Navigation("Empleados");

                    b.Navigation("Estados");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Paises")
                        .WithMany("Departamentos")
                        .HasForeignKey("PaisesId");

                    b.Navigation("Paises");
                });

            modelBuilder.Entity("Domain.Entities.DirPersona", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudades")
                        .WithMany("Direccion")
                        .HasForeignKey("CiudadesId");

                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("Direccion")
                        .HasForeignKey("PersonasId");

                    b.HasOne("Domain.Entities.TipoDireccion", "TiposDirecciones")
                        .WithMany("Direccion")
                        .HasForeignKey("TiposDireccionesId");

                    b.Navigation("Ciudades");

                    b.Navigation("Personas");

                    b.Navigation("TiposDirecciones");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Personas")
                        .WithMany("Empleados")
                        .HasForeignKey("PersonasId");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudades")
                        .WithMany("Personas")
                        .HasForeignKey("CiudadesId");

                    b.HasOne("Domain.Entities.TipoPersona", "TiposPersonas")
                        .WithMany("Personas")
                        .HasForeignKey("TiposPersonasId");

                    b.Navigation("Ciudades");

                    b.Navigation("TiposPersonas");
                });

            modelBuilder.Entity("Domain.Entities.Programacion", b =>
                {
                    b.HasOne("Domain.Entities.Contrato", "Contratos")
                        .WithMany("Programaciones")
                        .HasForeignKey("ContratosId");

                    b.HasOne("Domain.Entities.Empleado", "Empleados")
                        .WithMany("Programaciones")
                        .HasForeignKey("EmpleadosId");

                    b.HasOne("Domain.Entities.Turnos", "Turnoss")
                        .WithMany("Programaciones")
                        .HasForeignKey("TurnossId");

                    b.Navigation("Contratos");

                    b.Navigation("Empleados");

                    b.Navigation("Turnoss");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("Direccion");

                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("Domain.Entities.Contrato", b =>
                {
                    b.Navigation("Programaciones");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Empleado", b =>
                {
                    b.Navigation("Contratos");

                    b.Navigation("Programaciones");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Contratos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("Clientes");

                    b.Navigation("ContactosPersonas");

                    b.Navigation("Direccion");

                    b.Navigation("Empleados");
                });

            modelBuilder.Entity("Domain.Entities.TipoContactos", b =>
                {
                    b.Navigation("ContactosPersonas");
                });

            modelBuilder.Entity("Domain.Entities.TipoDireccion", b =>
                {
                    b.Navigation("Direccion");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Turnos", b =>
                {
                    b.Navigation("Programaciones");
                });
#pragma warning restore 612, 618
        }
    }
}