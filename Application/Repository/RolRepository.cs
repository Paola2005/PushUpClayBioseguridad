using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class RolRepository:GenericRepository<Rol>,IRol
    {
        private readonly PushUpClayBioseguridadContext _context;

    public RolRepository(PushUpClayBioseguridadContext context) : base(context)
    {
        _context = context;
    }
    }
    
}