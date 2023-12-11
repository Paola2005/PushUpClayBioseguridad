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
    public class ContactoPersonaRepository : GenericRepository<ContactoPersona>, IContactoPersona
    {
        private readonly PushUpClayBioseguridadContext _context;

        public ContactoPersonaRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}

