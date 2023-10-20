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
    public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {
            builder.ToTable("DetalleVenta");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Venta).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdVentaFk);
            builder.HasOne(x => x.Inventario).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdProductoFk);
            builder.HasOne(x => x.Talla).WithMany(x => x.DetalleVentas).HasForeignKey(x => x.IdTallaFk);
            builder.Property(x => x.Cantidad).IsRequired();
            builder.Property(x => x.ValorUnit).IsRequired();
        }
    }
}