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
    public class DirPersonaRepository : GenericRepository<DirPersona>, IDirPersona
    {
        private readonly PushUpClayBioseguridadContext _context;

        public DirPersonaRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}



