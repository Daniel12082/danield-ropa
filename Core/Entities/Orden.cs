
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Orden
    {
        public int IdOrden { get; set; }
        public DateTime Fecha { get; set; }
        public Empleado Empleado { get; set; }
        public int IdEmpleadoFk { get; set; }
        public Cliente Cliente { get; set; }
        public int IdClienteFk { get; set; }
        public Estado Estado { get; set; }
        public int IdEstadoFk { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
    }
}
