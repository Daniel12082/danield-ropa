using System;
using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;

namespace Infrastructure.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly danieldropaContext _context;
    private ICargoRepository _cargo;
    private IClienteRepository _cliente;
    private IColorRepository _color;
    private IDepartamentoRepository _departamento;
    private IDetalleOrdenRepository _detalleOrden;
    private IDetalleVentaRepository _detalleVenta;
    private IEmpleadoRepository _empleado;
    private IEmpresaRepository _empresa;
    private IEstadoRepository _estado;
    private IFormaPagoRepository _formaPago;
    private IGeneroRepository _genero;
    private IInsumoPrendaRepository _insumoPrenda;
    private IInsumoProveedorRepository _insumoProveedor;
    private IInsumoRepository _insumo;
    private IInventarioRepository _inventario;
    private InventarioTallaRepository _inventarioTalla;
    private IMunicipioRepository _municipio;
    private IOrdenRepository _orden;
    private IPaisRepository _pais;
    private IPrendaRepository _prenda;
    private IProveedorRepository _proveedor;
    private ITallaRepository _talla;
    private ITipoEstadoRepository _tipoEstado;
    private ITipoPersonaRepository _tipoPersona;
    private ITipoProteccionRepository _tipoProteccion;
    private IVentaRepository _venta;

    public UnitOfWork(danieldropaContext context)
    {
        _context = context;
    }

    public ICargoRepository Cargo {
        get {
            if (_cargo == null) {
                _cargo = new CargoRepository(_context);
            }
            return _cargo;
        }
    }
    public IClienteRepository Cliente {
        get {
            if (_cliente == null) {
                _cliente = new ClienteRepository(_context);
            }
            return _cliente;
        }
    }
    public IColorRepository Color {
        get {
            if (_color == null) {
                _color = new ColorRepository(_context);
            }
            return _color;
        }
    }
    public IDepartamentoRepository Departamento {
        get {
            if (_departamento == null) {
                _departamento = new DepartamentoRepository(_context);
            }
            return _departamento;
        }
    }
    public IDetalleOrdenRepository DetalleOrden {
        get {
            if (_detalleOrden == null) {
                _detalleOrden = new DetalleOrdenRepository(_context);
            }
            return _detalleOrden;
        }
    }
    public IDetalleVentaRepository DetalleVenta {
        get {
            if (_detalleVenta == null) {
                _detalleVenta = new DetalleVentaRepository(_context);
            }
            return _detalleVenta;
        }
    }
    public IEmpleadoRepository Empleado {
        get {
            if (_empleado == null) {
                _empleado = new EmpleadoRepository(_context);
            }
            return _empleado;
        }
    }
    public IEmpresaRepository Empresa {
        get {
            if (_empresa == null) {
                _empresa = new EmpresaRepository(_context);
            }
            return _empresa;
        }
    }
    public IEstadoRepository Estado {
        get {
            if (_estado == null) {
                _estado = new EstadoRepository(_context);
            }
            return _estado;
        }
    }
    public IFormaPagoRepository FormaPago {
        get {
            if (_formaPago == null) {
                _formaPago = new FormaPagoRepository(_context);
            }
            return _formaPago;
        }
    }
    public IGeneroRepository Genero {
        get {
            if (_genero == null) {
                _genero = new GeneroRepository(_context);
            }
            return _genero;
        }
    }
    public IInsumoPrendaRepository InsumoPrenda {
        get {
            if (_insumoPrenda == null) {
                _insumoPrenda = new InsumoPrendaRepository(_context);
            }
            return _insumoPrenda;
        }
    }
    public IInsumoProveedorRepository InsumoProveedor {
        get {
            if (_insumoProveedor == null) {
                _insumoProveedor = new InsumoProveedorRepository(_context);
            }
            return _insumoProveedor;
        }
    }
    public IInsumoRepository Insumo {
        get {
            if (_insumo == null) {
                _insumo = new InsumoRepository(_context);
            }
            return _insumo;
        }
    }
    public IInventarioRepository Inventario {
        get {
            if (_inventario == null) {
                _inventario = new InventarioRepository(_context);
            }
            return _inventario;
        }
    }
    public InventarioTallaRepository InventarioTalla {
        get {
            if (_inventarioTalla == null) {
                _inventarioTalla = new InventarioTallaRepository(_context);
            }
            return _inventarioTalla;
        }
    }
    public IMunicipioRepository Municipio {
        get {
            if (_municipio == null) {
                _municipio = new MunicipioRepository(_context);
            }
            return _municipio;
        }
    }
    public IOrdenRepository Orden {
        get {
            if (_orden == null) {
                _orden = new OrdenRepository(_context);
            }
            return _orden;
        }
    }
    public IPaisRepository Pais {
        get {
            if (_pais == null) {
                _pais = new PaisRepository(_context);
            }
            return _pais;
        }
    }
    public IPrendaRepository Prenda {
        get {
            if (_prenda == null) {
                _prenda = new PrendaRepository(_context);
            }
            return _prenda;
        }
    }
    public IProveedorRepository Proveedor {
        get {
            if (_proveedor == null) {
                _proveedor = new ProveedorRepository(_context);
            }
            return _proveedor;
        }
    }
    public ITallaRepository Talla {
        get {
            if (_talla == null) {
                _talla = new TallaRepository(_context);
            }
            return _talla;
        }
    }
    public ITipoEstadoRepository TipoEstado {
        get {
            if (_tipoEstado == null) {
                _tipoEstado = new TipoEstadoRepository(_context);
            }
            return _tipoEstado;
        }
    }
    public ITipoPersonaRepository TipoPersona {
        get {
            if (_tipoPersona == null) {
                _tipoPersona = new TipoPersonaRepository(_context);
            }
            return _tipoPersona;
        }
    }
    public ITipoProteccionRepository TipoProteccion {
        get {
            if (_tipoProteccion == null) {
                _tipoProteccion = new TipoProteccionRepository(_context);
            }
            return _tipoProteccion;
        }
    }
    public IVentaRepository Venta {
        get {
            if (_venta == null) {
                _venta = new VentaRepository(_context);
            }
            return _venta;
        }
    }

    public ICargoRepository Cargos {
        get {
            if (_cargo == null) {
                _cargo = new CargoRepository(_context);
            }
            return _cargo;
        }
    }

    public IClienteRepository Clientes {
        get {
            if (_cliente == null) {
                _cliente = new ClienteRepository(_context);
            }
            return _cliente;
        }
    }

    public IColorRepository Colores => throw new NotImplementedException();

    public IDepartamentoRepository Departamentos => throw new NotImplementedException();

    public IDetalleOrdenRepository DetalleOrdenes => throw new NotImplementedException();

    public IDetalleVentaRepository DetalleVentas => throw new NotImplementedException();

    public IEmpleadoRepository Empleados => throw new NotImplementedException();

    public IEmpresaRepository Empresas => throw new NotImplementedException();

    public IEstadoRepository Estados => throw new NotImplementedException();

    public IFormaPagoRepository FormasPago => throw new NotImplementedException();

    public IGeneroRepository Generos => throw new NotImplementedException();

    public IInventarioRepository Inventarios => throw new NotImplementedException();

    public IMunicipioRepository Municipios => throw new NotImplementedException();

    public IOrdenRepository Ordenes => throw new NotImplementedException();

    public IPaisRepository Paises => throw new NotImplementedException();

    public IPrendaRepository Prendas => throw new NotImplementedException();

    public IProveedorRepository Proveedores => throw new NotImplementedException();

    public ITallaRepository Tallas => throw new NotImplementedException();

    public ITipoEstadoRepository TiposEstado => throw new NotImplementedException();

    public ITipoPersonaRepository TiposPersona => throw new NotImplementedException();

    public ITipoProteccionRepository TiposProteccion => throw new NotImplementedException();

    public IVentaRepository Ventas => throw new NotImplementedException();

    public void Dispose()
    {
        _context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }
}
