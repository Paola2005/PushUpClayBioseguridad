using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class PersonaRepository : GenericRepository<Persona>, IPersona
    {
        private readonly PushUpClayBioseguridadContext _context;

        public PersonaRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}



