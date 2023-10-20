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
    public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedor");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.NitProveedor).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.HasOne(x => x.TipoPersona).WithMany().HasForeignKey(x => x.IdTipoPersonaFk);
            builder.HasOne(x => x.Municipio).WithMany().HasForeignKey(x => x.IdMunicipioFk);
        }
    }
}