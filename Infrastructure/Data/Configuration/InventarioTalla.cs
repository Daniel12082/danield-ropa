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
    public class InventarioTallaConfiguration : IEntityTypeConfiguration<InventarioTalla>
    {
        public void Configure(EntityTypeBuilder<InventarioTalla> builder)
        {
            builder.ToTable("InventarioTalla");
            builder.HasKey(t => new { t.Id, t.IdInventarioFk });
            builder.HasKey(t => new { t.Id, t.IdTallaFk });
            builder.HasOne(x => x.Inventario).WithMany(x => x.InventarioTallas).HasForeignKey(x => x.IdInventarioFk);
            builder.HasOne(x => x.Talla).WithMany(x => x.InventarioTallas).HasForeignKey(x => x.IdTallaFk);
        }
    }
}