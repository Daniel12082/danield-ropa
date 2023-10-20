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
    public class InsumoPrendaConfiguration : IEntityTypeConfiguration<InsumoPrenda>
    {
        public void Configure(EntityTypeBuilder<InsumoPrenda> builder)
        {
            builder.ToTable("InsumoPrenda");
            builder.HasKey(t => new { t.IdPrendaFk, t.IdInsumoFk });
            builder.HasOne(x => x.Insumo).WithMany(x => x.InsumoPrendas).HasForeignKey(x => x.IdInsumoFk);
            builder.HasOne(x => x.Prenda).WithMany(x => x.InsumoPrendas).HasForeignKey(x => x.IdPrendaFk);
        }
    }
}