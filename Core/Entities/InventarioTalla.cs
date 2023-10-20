
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InventarioTalla
    {
        public Inventario Inventario { get; set; }
        public int IdInventarioFk { get; set; }
        public Talla Talla { get; set; }
        public int IdTallaFk { get; set; }
        public int Cantidad { get; set; }
    }
}
