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
    public class TipoDireccionRepository : GenericRepository<TipoDireccion>, ITipoDireccion
    {
        private readonly PushUpClayBioseguridadContext _context;

        public TipoDireccionRepository(PushUpClayBioseguridadContext context) : base(context)
        {
            _context = context;
        }
    }
}



