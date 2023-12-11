using Application.Repository;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly PushUpClayBioseguridadContext _context;
    private ICiudad _ciudad;
    private ICliente _cliente;
    private IContactoPersona _contactospersons;
    private IContrato _contratos;
    private IDepartamento _departamento;
    private IDirPersona _direccionperson;
    private IEmpleado _empleado;
    private IEstado _estado;
    private IPais _pais;
    private IPersona _persona;
    private IProgramacion _programacion;
    private ITipoContactos _tipocontacto;
    private ITipoDireccion _tipodireccion;
    private ITipoPersona _tipopersona;
    private ITurnos _turno;
    private IUser _user;
    private IRol _rol;

    public ICiudad Ciudades 
    {
        get
        {
            if (_ciudad == null)
            {
                _ciudad = new CiudadRepository(_context);
            }
            return _ciudad;
        }
    } 
    public ICliente Clientes 
    {
        get
        {
            if (_cliente == null)
            {
                _cliente = new ClienteRepository(_context);
            }
            return _cliente;
        }
    } 
    public IContactoPersona ContactoPersonas 
    {
        get
        {
            if (_contactospersons == null)
            {
                _contactospersons = new ContactoPersonaRepository(_context);
            }
            return _contactospersons;
        }
    } 
    public IContrato Contratos 
    {
        get
        {
            if (_contratos == null)
            {
                _contratos = new ContratoRepository(_context);
            }
            return _contratos;
        }
    } 
    public IDepartamento Departamentos 
    {
        get
        {
            if (_departamento == null)
            {
                _departamento = new DepartamentoRepository(_context);
            }
            return _departamento;
        }
    } 
    public IDirPersona Direccion 
    {
        get
        {
            if (_direccionperson == null)
            {
                _direccionperson = new DirPersonaRepository(_context);
            }
            return _direccionperson;
        }
    } 
    public IEmpleado Empleados 
    {
        get
        {
            if (_empleado == null)
            {
                _empleado = new EmpleadoRepository(_context);
            }
            return _empleado;
        }
    } 
    public IEstado Etados 
    {
        get
        {
            if (_estado == null)
            {
                _estado = new EstadoRepository(_context);
            }
            return _estado;
        }
    } 
    public IPais Paises 
    {
        get
        {
            if (_pais == null)
            {
                _pais = new PaisRepository(_context);
            }
            return _pais;
        }
    } 
    public IPersona Personas 
    {
        get
        {
            if (_persona == null)
            {
                _persona = new PersonaRepository(_context);
            }
            return _persona;
        }
    } 
    public IProgramacion Programaciones 
    {
        get
        {
            if (_programacion == null)
            {
                _programacion = new ProgramacionRepository(_context);
            }
            return _programacion;
        }
    } 
    public ITipoContactos TiposContactos 
    {
        get
        {
            if (_tipocontacto == null)
            {
                _tipocontacto = new TipoContactosRepository(_context);
            }
            return _tipocontacto;
        }
    } 
    public ITipoDireccion TipoDirecciones 
    {
        get
        {
            if (_tipodireccion == null)
            {
                _tipodireccion = new TipoDireccionRepository(_context);
            }
            return _tipodireccion;
        }
    } 
    public ITipoPersona TipoPersonas 
    {
        get
        {
            if (_tipopersona == null)
            {
                _tipopersona = new TipoPersonaRepository(_context);
            }
            return _tipopersona;
        }
    } 
    public ITurnos Turnoss 
    {
        get
        {
            if (_turno == null)
            {
                _turno = new TurnosRepository(_context);
            }
            return _turno;
        }
    }

    public IRol Roles 
    {
        get
        {
            if (_rol == null)
            {
                _rol = new RolRepository(_context);
            }
            return _rol;
        }
    }

    public IUser Users 
    {
        get
        {
            if (_user == null)
            {
                _user = new UserRepository(_context);
            }
            return _user;
        }
    }

    public UnitOfWork(PushUpClayBioseguridadContext context)
    {
        _context = context;
    }
    


    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
