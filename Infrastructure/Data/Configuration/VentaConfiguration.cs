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
    public class VentaConfiguration : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("Venta");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fecha).IsRequired();
            builder.HasOne(x => x.Cliente)
                .WithMany(y => y.Ventas)
                .HasForeignKey(x => x.IdClienteFk);
            builder.HasOne(x => x.Empleado).WithMany(y => y.Ventas).HasForeignKey(x => x.IdEmpleadoFk);
            builder.HasOne(x => x.FormaPago).WithMany(y => y.Ventas).HasForeignKey(x => x.IdFormaPagoFk);
        }
    }
}