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
    public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
    {
        public void Configure(EntityTypeBuilder<Orden> builder)
        {
            builder.ToTable("Orden");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Fecha).IsRequired();
            builder.HasOne(a => a.Empleado)
                .WithMany(b => b.Ordenes)
                .HasForeignKey(a => a.IdEmpleadoFk);
            builder.HasOne(a => a.Cliente)
                .WithMany(b => b.Ordenes)
                .HasForeignKey(a => a.IdClienteFk);
            builder.HasOne(a => a.Estado)
                .WithMany(b => b.Ordenes)
                .HasForeignKey(a => a.IdEstadoFk);
        }
    }
}