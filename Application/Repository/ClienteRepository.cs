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
    public class ClienteRepository : GenericRepository<Cliente>, ICliente
    {
        private readonly PushUpClayBioseguridadContext _context;

        public ClienteRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}

