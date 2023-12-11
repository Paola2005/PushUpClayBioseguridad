using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos
{
    public class TurnosDto
    {
        public int Id { get; set; }
                public string NombreTurno { get; set; }
        public TimeOnly HoraTurnoI { get; set; }
        public TimeOnly HoraTurnoF { get; set; }
        public ICollection<Programacion> Programaciones { get; set; }
    }
}
