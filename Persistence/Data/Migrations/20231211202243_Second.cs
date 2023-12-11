using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentosId",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Personas_PersonasId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersonas_Personas_PersonasId",
                table: "ContactoPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersonas_TipoContactos_TiposContactosId",
                table: "ContactoPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Clientes_ClientesId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Empleados_EmpleadosId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Contratos_Estados_EstadosId",
                table: "Contratos");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Paises_PaisesId",
                table: "Departamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_DirPersonas_Ciudades_CiudadesId",
                table: "DirPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_DirPersonas_Personas_PersonasId",
                table: "DirPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_DirPersonas_TipoDireccions_TiposDireccionesId",
                table: "DirPersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Personas_PersonasId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Ciudades_CiudadesId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_TipoPersonas_TiposPersonasId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacions_Contratos_ContratosId",
                table: "Programacions");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacions_Empleados_EmpleadosId",
                table: "Programacions");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacions_Turnoss_TurnossId",
                table: "Programacions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turnoss",
                table: "Turnoss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDireccions",
                table: "TipoDireccions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programacions",
                table: "Programacions");

            migrationBuilder.DropIndex(
                name: "IX_Programacions_ContratosId",
                table: "Programacions");

            migrationBuilder.DropIndex(
                name: "IX_Programacions_EmpleadosId",
                table: "Programacions");

            migrationBuilder.DropIndex(
                name: "IX_Programacions_TurnossId",
                table: "Programacions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personas",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CiudadesId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_TiposPersonasId",
                table: "Personas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Paises",
                table: "Paises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estados",
                table: "Estados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PersonasId",
                table: "Empleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DirPersonas",
                table: "DirPersonas");

            migrationBuilder.DropIndex(
                name: "IX_DirPersonas_CiudadesId",
                table: "DirPersonas");

            migrationBuilder.DropIndex(
                name: "IX_DirPersonas_PersonasId",
                table: "DirPersonas");

            migrationBuilder.DropIndex(
                name: "IX_DirPersonas_TiposDireccionesId",
                table: "DirPersonas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_PaisesId",
                table: "Departamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_ClientesId",
                table: "Contratos");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_EmpleadosId",
                table: "Contratos");

            migrationBuilder.DropIndex(
                name: "IX_Contratos_EstadosId",
                table: "Contratos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactoPersonas",
                table: "ContactoPersonas");

            migrationBuilder.DropIndex(
                name: "IX_ContactoPersonas_PersonasId",
                table: "ContactoPersonas");

            migrationBuilder.DropIndex(
                name: "IX_ContactoPersonas_TiposContactosId",
                table: "ContactoPersonas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_PersonasId",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DepartamentosId",
                table: "Ciudades");

            migrationBuilder.DropColumn(
                name: "ContratosId",
                table: "Programacions");

            migrationBuilder.DropColumn(
                name: "EmpleadosId",
                table: "Programacions");

            migrationBuilder.DropColumn(
                name: "TurnossId",
                table: "Programacions");

            migrationBuilder.DropColumn(
                name: "CiudadesId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "TiposPersonasId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "CiudadesId",
                table: "DirPersonas");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "DirPersonas");

            migrationBuilder.DropColumn(
                name: "TiposDireccionesId",
                table: "DirPersonas");

            migrationBuilder.DropColumn(
                name: "PaisesId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "ClientesId",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "EmpleadosId",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "EstadosId",
                table: "Contratos");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "ContactoPersonas");

            migrationBuilder.DropColumn(
                name: "TiposContactosId",
                table: "ContactoPersonas");

            migrationBuilder.DropColumn(
                name: "PersonasId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "DepartamentosId",
                table: "Ciudades");

            migrationBuilder.RenameTable(
                name: "Turnoss",
                newName: "Turnos");

            migrationBuilder.RenameTable(
                name: "TipoPersonas",
                newName: "TipoPersona");

            migrationBuilder.RenameTable(
                name: "TipoDireccions",
                newName: "TipoDireccion");

            migrationBuilder.RenameTable(
                name: "Programacions",
                newName: "Programacion");

            migrationBuilder.RenameTable(
                name: "Personas",
                newName: "Persona");

            migrationBuilder.RenameTable(
                name: "Paises",
                newName: "Pais");

            migrationBuilder.RenameTable(
                name: "Estados",
                newName: "Estado");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "DirPersonas",
                newName: "UbicacionPersona");

            migrationBuilder.RenameTable(
                name: "Departamentos",
                newName: "Departamento");

            migrationBuilder.RenameTable(
                name: "Contratos",
                newName: "Contrato");

            migrationBuilder.RenameTable(
                name: "ContactoPersonas",
                newName: "ContactoPersona");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Ciudades",
                newName: "Ciudad");

            migrationBuilder.UpdateData(
                table: "TipoContactos",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoContactos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Turnos",
                keyColumn: "NombreTurno",
                keyValue: null,
                column: "NombreTurno",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreTurno",
                table: "Turnos",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "TipoPersona",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoPersona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "TipoDireccion",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoDireccion",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Persona",
                keyColumn: "Nombre",
                keyValue: null,
                column: "Nombre",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Persona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Pais",
                keyColumn: "NombrePais",
                keyValue: null,
                column: "NombrePais",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "Pais",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Estado",
                keyColumn: "Descripcion",
                keyValue: null,
                column: "Descripcion",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Estado",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfStreet",
                table: "UbicacionPersona",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ThirdLetter",
                table: "UbicacionPersona",
                type: "varchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SecondLetter",
                table: "UbicacionPersona",
                type: "varchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SecondCardinal",
                table: "UbicacionPersona",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "UbicacionPersona",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Letter",
                table: "UbicacionPersona",
                type: "varchar(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                table: "UbicacionPersona",
                type: "varchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cardinal",
                table: "UbicacionPersona",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bis",
                table: "UbicacionPersona",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Departamento",
                keyColumn: "NombreDepa",
                keyValue: null,
                column: "NombreDepa",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepa",
                table: "Departamento",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "ContactoPersona",
                type: "varchar(255)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Ciudad",
                keyColumn: "NombreCiudad",
                keyValue: null,
                column: "NombreCiudad",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "Ciudad",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turnos",
                table: "Turnos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPersona",
                table: "TipoPersona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDireccion",
                table: "TipoDireccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programacion",
                table: "Programacion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persona",
                table: "Persona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pais",
                table: "Pais",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estado",
                table: "Estado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UbicacionPersona",
                table: "UbicacionPersona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactoPersona",
                table: "ContactoPersona",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userRol",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RolId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => new { x.UserId, x.RolId });
                    table.ForeignKey(
                        name: "FK_userRol_Roles_RolId",
                        column: x => x.RolId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRol_user_UserId",
                        column: x => x.UserId,
                        principalTable: "user",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Programacion_IdContrato",
                table: "Programacion",
                column: "IdContrato");

            migrationBuilder.CreateIndex(
                name: "IX_Programacion_IdEmpleado",
                table: "Programacion",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Programacion_IdTurno",
                table: "Programacion",
                column: "IdTurno");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdCiudad",
                table: "Persona",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdPersona",
                table: "Persona",
                column: "IdPersona",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persona_IdTipoPersona",
                table: "Persona",
                column: "IdTipoPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_UbicacionPersona_IdCiudad",
                table: "UbicacionPersona",
                column: "IdCiudad");

            migrationBuilder.CreateIndex(
                name: "IX_UbicacionPersona_IdPersona",
                table: "UbicacionPersona",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_UbicacionPersona_IdTipoDireccion",
                table: "UbicacionPersona",
                column: "IdTipoDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_Departamento_IdPais",
                table: "Departamento",
                column: "IdPais");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdCliente",
                table: "Contrato",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdEmpleado",
                table: "Contrato",
                column: "IdEmpleado");

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_IdEstado",
                table: "Contrato",
                column: "IdEstado");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersona_Descripcion",
                table: "ContactoPersona",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersona_IdPersona",
                table: "ContactoPersona",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersona_IdTipoContacto",
                table: "ContactoPersona",
                column: "IdTipoContacto");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente",
                column: "IdPersona");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudad_IdDepartamento",
                table: "Ciudad",
                column: "IdDepartamento");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_UserId",
                table: "RefreshToken",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_RolId",
                table: "userRol",
                column: "RolId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudad_Departamento_IdDepartamento",
                table: "Ciudad",
                column: "IdDepartamento",
                principalTable: "Departamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersona_Persona_IdPersona",
                table: "ContactoPersona",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersona_TipoContactos_IdTipoContacto",
                table: "ContactoPersona",
                column: "IdTipoContacto",
                principalTable: "TipoContactos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Cliente_IdCliente",
                table: "Contrato",
                column: "IdCliente",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Empleado_IdEmpleado",
                table: "Contrato",
                column: "IdEmpleado",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contrato_Estado_IdEstado",
                table: "Contrato",
                column: "IdEstado",
                principalTable: "Estado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamento_Pais_IdPais",
                table: "Departamento",
                column: "IdPais",
                principalTable: "Pais",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_Persona_IdPersona",
                table: "Empleado",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_Ciudad_IdCiudad",
                table: "Persona",
                column: "IdCiudad",
                principalTable: "Ciudad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Persona_TipoPersona_IdTipoPersona",
                table: "Persona",
                column: "IdTipoPersona",
                principalTable: "TipoPersona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacion_Contrato_IdContrato",
                table: "Programacion",
                column: "IdContrato",
                principalTable: "Contrato",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacion_Empleado_IdEmpleado",
                table: "Programacion",
                column: "IdEmpleado",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programacion_Turnos_IdTurno",
                table: "Programacion",
                column: "IdTurno",
                principalTable: "Turnos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UbicacionPersona_Ciudad_IdCiudad",
                table: "UbicacionPersona",
                column: "IdCiudad",
                principalTable: "Ciudad",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UbicacionPersona_Persona_IdPersona",
                table: "UbicacionPersona",
                column: "IdPersona",
                principalTable: "Persona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UbicacionPersona_TipoDireccion_IdTipoDireccion",
                table: "UbicacionPersona",
                column: "IdTipoDireccion",
                principalTable: "TipoDireccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudad_Departamento_IdDepartamento",
                table: "Ciudad");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Persona_IdPersona",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersona_Persona_IdPersona",
                table: "ContactoPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_ContactoPersona_TipoContactos_IdTipoContacto",
                table: "ContactoPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Cliente_IdCliente",
                table: "Contrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Empleado_IdEmpleado",
                table: "Contrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Contrato_Estado_IdEstado",
                table: "Contrato");

            migrationBuilder.DropForeignKey(
                name: "FK_Departamento_Pais_IdPais",
                table: "Departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_Persona_IdPersona",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_Ciudad_IdCiudad",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Persona_TipoPersona_IdTipoPersona",
                table: "Persona");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacion_Contrato_IdContrato",
                table: "Programacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacion_Empleado_IdEmpleado",
                table: "Programacion");

            migrationBuilder.DropForeignKey(
                name: "FK_Programacion_Turnos_IdTurno",
                table: "Programacion");

            migrationBuilder.DropForeignKey(
                name: "FK_UbicacionPersona_Ciudad_IdCiudad",
                table: "UbicacionPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_UbicacionPersona_Persona_IdPersona",
                table: "UbicacionPersona");

            migrationBuilder.DropForeignKey(
                name: "FK_UbicacionPersona_TipoDireccion_IdTipoDireccion",
                table: "UbicacionPersona");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "userRol");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UbicacionPersona",
                table: "UbicacionPersona");

            migrationBuilder.DropIndex(
                name: "IX_UbicacionPersona_IdCiudad",
                table: "UbicacionPersona");

            migrationBuilder.DropIndex(
                name: "IX_UbicacionPersona_IdPersona",
                table: "UbicacionPersona");

            migrationBuilder.DropIndex(
                name: "IX_UbicacionPersona_IdTipoDireccion",
                table: "UbicacionPersona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Turnos",
                table: "Turnos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoPersona",
                table: "TipoPersona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoDireccion",
                table: "TipoDireccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Programacion",
                table: "Programacion");

            migrationBuilder.DropIndex(
                name: "IX_Programacion_IdContrato",
                table: "Programacion");

            migrationBuilder.DropIndex(
                name: "IX_Programacion_IdEmpleado",
                table: "Programacion");

            migrationBuilder.DropIndex(
                name: "IX_Programacion_IdTurno",
                table: "Programacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdCiudad",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdPersona",
                table: "Persona");

            migrationBuilder.DropIndex(
                name: "IX_Persona_IdTipoPersona",
                table: "Persona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pais",
                table: "Pais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Estado",
                table: "Estado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropIndex(
                name: "IX_Empleado_IdPersona",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departamento",
                table: "Departamento");

            migrationBuilder.DropIndex(
                name: "IX_Departamento_IdPais",
                table: "Departamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato");

            migrationBuilder.DropIndex(
                name: "IX_Contrato_IdCliente",
                table: "Contrato");

            migrationBuilder.DropIndex(
                name: "IX_Contrato_IdEmpleado",
                table: "Contrato");

            migrationBuilder.DropIndex(
                name: "IX_Contrato_IdEstado",
                table: "Contrato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContactoPersona",
                table: "ContactoPersona");

            migrationBuilder.DropIndex(
                name: "IX_ContactoPersona_Descripcion",
                table: "ContactoPersona");

            migrationBuilder.DropIndex(
                name: "IX_ContactoPersona_IdPersona",
                table: "ContactoPersona");

            migrationBuilder.DropIndex(
                name: "IX_ContactoPersona_IdTipoContacto",
                table: "ContactoPersona");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_IdPersona",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ciudad",
                table: "Ciudad");

            migrationBuilder.DropIndex(
                name: "IX_Ciudad_IdDepartamento",
                table: "Ciudad");

            migrationBuilder.RenameTable(
                name: "UbicacionPersona",
                newName: "DirPersonas");

            migrationBuilder.RenameTable(
                name: "Turnos",
                newName: "Turnoss");

            migrationBuilder.RenameTable(
                name: "TipoPersona",
                newName: "TipoPersonas");

            migrationBuilder.RenameTable(
                name: "TipoDireccion",
                newName: "TipoDireccions");

            migrationBuilder.RenameTable(
                name: "Programacion",
                newName: "Programacions");

            migrationBuilder.RenameTable(
                name: "Persona",
                newName: "Personas");

            migrationBuilder.RenameTable(
                name: "Pais",
                newName: "Paises");

            migrationBuilder.RenameTable(
                name: "Estado",
                newName: "Estados");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "Empleados");

            migrationBuilder.RenameTable(
                name: "Departamento",
                newName: "Departamentos");

            migrationBuilder.RenameTable(
                name: "Contrato",
                newName: "Contratos");

            migrationBuilder.RenameTable(
                name: "ContactoPersona",
                newName: "ContactoPersonas");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Ciudad",
                newName: "Ciudades");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoContactos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfStreet",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "ThirdLetter",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SecondLetter",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SecondCardinal",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Letter",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(2)",
                oldMaxLength: 2,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Complement",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldMaxLength: 255,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Cardinal",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Bis",
                table: "DirPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CiudadesId",
                table: "DirPersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "DirPersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposDireccionesId",
                table: "DirPersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreTurno",
                table: "Turnoss",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "TipoDireccions",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "ContratosId",
                table: "Programacions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadosId",
                table: "Programacions",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TurnossId",
                table: "Programacions",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Personas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "CiudadesId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposPersonasId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombrePais",
                table: "Paises",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Estados",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepa",
                table: "Departamentos",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PaisesId",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClientesId",
                table: "Contratos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadosId",
                table: "Contratos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EstadosId",
                table: "Contratos",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "ContactoPersonas",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "ContactoPersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TiposContactosId",
                table: "ContactoPersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PersonasId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NombreCiudad",
                table: "Ciudades",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentosId",
                table: "Ciudades",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DirPersonas",
                table: "DirPersonas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Turnoss",
                table: "Turnoss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoPersonas",
                table: "TipoPersonas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoDireccions",
                table: "TipoDireccions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Programacions",
                table: "Programacions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personas",
                table: "Personas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Paises",
                table: "Paises",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Estados",
                table: "Estados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departamentos",
                table: "Departamentos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContactoPersonas",
                table: "ContactoPersonas",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ciudades",
                table: "Ciudades",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DirPersonas_CiudadesId",
                table: "DirPersonas",
                column: "CiudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_DirPersonas_PersonasId",
                table: "DirPersonas",
                column: "PersonasId");

            migrationBuilder.CreateIndex(
                name: "IX_DirPersonas_TiposDireccionesId",
                table: "DirPersonas",
                column: "TiposDireccionesId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacions_ContratosId",
                table: "Programacions",
                column: "ContratosId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacions_EmpleadosId",
                table: "Programacions",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Programacions_TurnossId",
                table: "Programacions",
                column: "TurnossId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_CiudadesId",
                table: "Personas",
                column: "CiudadesId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_TiposPersonasId",
                table: "Personas",
                column: "TiposPersonasId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PersonasId",
                table: "Empleados",
                column: "PersonasId");

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_PaisesId",
                table: "Departamentos",
                column: "PaisesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_ClientesId",
                table: "Contratos",
                column: "ClientesId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_EmpleadosId",
                table: "Contratos",
                column: "EmpleadosId");

            migrationBuilder.CreateIndex(
                name: "IX_Contratos_EstadosId",
                table: "Contratos",
                column: "EstadosId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_PersonasId",
                table: "ContactoPersonas",
                column: "PersonasId");

            migrationBuilder.CreateIndex(
                name: "IX_ContactoPersonas_TiposContactosId",
                table: "ContactoPersonas",
                column: "TiposContactosId");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_PersonasId",
                table: "Clientes",
                column: "PersonasId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DepartamentosId",
                table: "Ciudades",
                column: "DepartamentosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Departamentos_DepartamentosId",
                table: "Ciudades",
                column: "DepartamentosId",
                principalTable: "Departamentos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Personas_PersonasId",
                table: "Clientes",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersonas_Personas_PersonasId",
                table: "ContactoPersonas",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactoPersonas_TipoContactos_TiposContactosId",
                table: "ContactoPersonas",
                column: "TiposContactosId",
                principalTable: "TipoContactos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Clientes_ClientesId",
                table: "Contratos",
                column: "ClientesId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Empleados_EmpleadosId",
                table: "Contratos",
                column: "EmpleadosId",
                principalTable: "Empleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Contratos_Estados_EstadosId",
                table: "Contratos",
                column: "EstadosId",
                principalTable: "Estados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Paises_PaisesId",
                table: "Departamentos",
                column: "PaisesId",
                principalTable: "Paises",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirPersonas_Ciudades_CiudadesId",
                table: "DirPersonas",
                column: "CiudadesId",
                principalTable: "Ciudades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirPersonas_Personas_PersonasId",
                table: "DirPersonas",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DirPersonas_TipoDireccions_TiposDireccionesId",
                table: "DirPersonas",
                column: "TiposDireccionesId",
                principalTable: "TipoDireccions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Personas_PersonasId",
                table: "Empleados",
                column: "PersonasId",
                principalTable: "Personas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Ciudades_CiudadesId",
                table: "Personas",
                column: "CiudadesId",
                principalTable: "Ciudades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_TipoPersonas_TiposPersonasId",
                table: "Personas",
                column: "TiposPersonasId",
                principalTable: "TipoPersonas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programacions_Contratos_ContratosId",
                table: "Programacions",
                column: "ContratosId",
                principalTable: "Contratos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programacions_Empleados_EmpleadosId",
                table: "Programacions",
                column: "EmpleadosId",
                principalTable: "Empleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programacions_Turnoss_TurnossId",
                table: "Programacions",
                column: "TurnossId",
                principalTable: "Turnoss",
                principalColumn: "Id");
        }
    }
}
