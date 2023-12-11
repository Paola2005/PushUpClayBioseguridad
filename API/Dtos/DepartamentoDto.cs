using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
                public string NombreDepa { get; set; }
        public int  IdPais{ get; set; }

        public ICollection<Ciudad> Ciudades { get; set; }
    }
}
