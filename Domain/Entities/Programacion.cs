using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Programacion : BaseEntity
    {
        public int IdContrato { get; set; }
        public Contrato Contratos { get; set; }
        public int IdTurno { get; set; }
        public Turnos Turnoss { get; set; }
        public int IdEmpleado { get; set; }
        public Empleado Empleados { get; set; }
    }
}
