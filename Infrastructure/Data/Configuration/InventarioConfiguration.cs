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
    public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
    {
        public void Configure(EntityTypeBuilder<Inventario> builder)
        {
            builder.ToTable("Inventario");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.CodInv).IsUnique();
            builder.HasOne(x => x.Prenda).WithMany(x => x.Inventarios).HasForeignKey(x => x.IdPrendaFk);
            builder.Property(x => x.ValorVtaCop).IsRequired();
            builder.Property(x => x.ValorVtaUsd).IsRequired();
        }
    }
}