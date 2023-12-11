using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Empleado : BaseEntity
    {
        public int IdPersona { get; set; }
        public Persona Personas { get; set; }
        public ICollection<Contrato> Contratos { get; set; }
        public ICollection<Programacion> Programaciones { get; set; }
    
    }
}
