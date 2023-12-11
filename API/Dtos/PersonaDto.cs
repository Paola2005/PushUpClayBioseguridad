using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class PersonaDto
    {
        public int Id { get; set; }
                public int IdPersona { get; set; }
        public string Nombre { get; set; }
        public DateOnly FechaRegistro { get; set; }
        public int IdTipoPersona { get; set; }
        public int IdCiudad { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
        public ICollection<DirPersona> Direccion { get; set; }
        public ICollection<ContactoPersona> ContactosPersonas { get; set; }
    }
}
