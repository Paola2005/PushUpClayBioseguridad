using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
        
namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IRol Roles { get; }
        IUser Users { get; }
        ICiudad Ciudades { get; }
        ICliente Clientes { get; }
        IContactoPersona ContactoPersonas { get; }
        IContrato Contratos { get; }
        IDepartamento Departamentos { get; }
        IDirPersona Direccion { get; }
        IEmpleado Empleados { get; }
        IEstado Etados { get; }
        IPais Paises { get; }
        IPersona Personas { get; }
        IProgramacion Programaciones { get; }
        ITipoContactos TiposContactos { get; }
        ITipoDireccion TipoDirecciones { get; }
        ITipoPersona TipoPersonas { get; }
        ITurnos Turnoss { get; }


        Task<int> SaveAsync();
    }
}
