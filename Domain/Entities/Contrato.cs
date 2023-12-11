using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contrato : BaseEntity
    {
        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }
        public int IdEmpleado { get; set; }
        public Empleado Empleados { get; set; }
        public int IdEstado { get; set; }
        public Estado Estados { get; set; }
        public DateOnly FechaContrato { get; set; }
        public DateOnly FechaFin { get; set; }
        public ICollection<Programacion> Programaciones { get; set; }
    }
}
