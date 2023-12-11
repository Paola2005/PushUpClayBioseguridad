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
    public class ProgramacionRepository : GenericRepository<Programacion>, IProgramacion
    {
        private readonly PushUpClayBioseguridadContext _context;

        public ProgramacionRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}



