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
    public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
    {
        public void Configure(EntityTypeBuilder<DetalleOrden> builder)
        {
            builder.ToTable("DetalleOrden");

            builder.HasKey(x => x.Id);

            builder.HasOne(a => a.Orden)
                .WithMany(b => b.DetalleOrdenes)
                .HasForeignKey(a => a.IdOrdenFk);
            builder.HasOne(a => a.Prenda)
                .WithMany(b => b.DetalleOrdenes)
                .HasForeignKey(a => a.IdPrendaFk);
            builder.Property(x => x.CantidadProducir).IsRequired();
            builder.HasOne(a => a.Color)
                .WithMany(b => b.DetalleOrdenes)
                .HasForeignKey(a => a.IdColorFk);
            builder.Property(x=> x.CantidadProducida).IsRequired();
            builder.HasOne(a => a.Estado)
                .WithMany(b => b.DetalleOrdenes)
                .HasForeignKey(a => a.IdEstadoFk);
        }
    }
}