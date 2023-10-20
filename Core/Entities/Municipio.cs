
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Municipio : BaseEntity
    {
        public string Nombre { get; set; }
        public Departamento Departamento { get; set; }
        public int IdDepartamentoFk { get; set; }
        public ICollection<Empresa> Empresas { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
        public ICollection<Empleado> Empleados { get; set; }
    }
}
