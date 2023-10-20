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
    public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
    {
        public void Configure(EntityTypeBuilder<Prenda> builder)
        {
            builder.ToTable("Prenda");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdPrenda).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.Property(x => x.ValorUnitCop).IsRequired();
            builder.Property(x => x.ValorUnitUsd).IsRequired();
            builder.HasOne(x => x.Estado).WithMany(x => x.Prendas).HasForeignKey(x => x.IdEstadoFk);
            builder.HasOne(x => x.TipoProteccion).WithMany(x => x.Prendas).HasForeignKey(x => x.IdTipoProteccionFk);
            builder.HasOne(x => x.Genero).WithMany(x => x.Prendas).HasForeignKey(x => x.IdGeneroFk);
        }
    }
}