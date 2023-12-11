using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public ICollection<Contrato> Contratos { get; set; }
    }
}
