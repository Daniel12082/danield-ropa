
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoProveedor
    {
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }
        public Proveedor Proveedor { get; set; }
        public int IdProveedorFk { get; set; }

    }
}
