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
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.HasOne(a => a.Pais)
                .WithMany(b => b.Departamentos)
                .HasForeignKey(a => a.IdPaisFk);
        }
    }
}