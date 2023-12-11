using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class EmpleadoDto
    {
        public int Id { get; set; }
                public int IdPersona { get; set; }

        public ICollection<Contrato> Contratos { get; set; }
        public ICollection<Programacion> Programaciones { get; set; }
    }
}
