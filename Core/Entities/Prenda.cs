
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Prenda : BaseEntity
    {
        public int IdPrenda { get; set; }
        public string Nombre { get; set; }
        public int ValorUnitCop { get; set; }
        public int ValorUnitUsd { get; set; }
        public Estado Estado { get; set; }
        public int IdEstadoFk { get; set; }
        public TipoProteccion TipoProteccion { get; set; }
        public int IdTipoProteccionFk { get; set; }
        public Genero Genero { get; set; }
        public int IdGeneroFk { get; set; }
        public ICollection<Inventario> Inventarios { get; set; }
        public ICollection<DetalleOrden> DetalleOrdenes { get; set; }
        public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    }
}
