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
    public class EmpresaConfiguration : IEntityTypeConfiguration<Empresa>
    {
        public void Configure(EntityTypeBuilder<Empresa> builder)
        {
            builder.ToTable("Empresa");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Nit).IsUnique();
            builder.Property(x => x.RazonSocial).HasMaxLength(80).IsRequired();
            builder.Property(x => x.RepresentanteLegal).HasMaxLength(80).IsRequired();
            builder.Property(x => x.FechaCreacion).IsRequired();
            builder.HasOne(a => a.Municipio)
                .WithMany(b => b.Empresas)
                .HasForeignKey(a => a.IdMunicipioFk);
        }
    }
}