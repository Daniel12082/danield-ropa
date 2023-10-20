
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class InsumoPrenda
    {
        public Insumo Insumo { get; set; }
        public int IdInsumoFk { get; set; }
        public Prenda Prenda { get; set; }
        public int IdPrendaFk { get; set; }
        public int Cantidad { get; set; }
    }
}
