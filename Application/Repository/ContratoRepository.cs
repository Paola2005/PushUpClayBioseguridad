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
    public class ContratoRepository : GenericRepository<Contrato>, IContrato
    {
        private readonly PushUpClayBioseguridadContext _context;

        public ContratoRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}


