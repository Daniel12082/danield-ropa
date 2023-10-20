using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleado");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdEmp).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.HasOne(x => x.Cargo).WithMany(x => x.Empleados).HasForeignKey(x => x.IdCargoFk);
            builder.Property(x => x.FechaIngreso).IsRequired();
            builder.HasOne(x => x.Municipio).WithMany().HasForeignKey(x => x.IdMunicipioFk);
        }
    }
}