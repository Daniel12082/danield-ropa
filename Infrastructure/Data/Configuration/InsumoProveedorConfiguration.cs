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
    public class InsumoProveedorConfiguration : IEntityTypeConfiguration<InsumoProveedor>
    {
        public void Configure(EntityTypeBuilder<InsumoProveedor> builder)
        {
            builder.ToTable("InsumoProveedor");
            builder.HasKey(t => new { t.IdProveedorFk, t.IdInsumoFk });
            builder.HasOne(x => x.Insumo).WithMany(x => x.InsumoProveedores).HasForeignKey(x => x.IdInsumoFk);
            builder.HasOne(x => x.Proveedor).WithMany(x => x.InsumoProveedores).HasForeignKey(x => x.IdProveedorFk);
        }
    }
}