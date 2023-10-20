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
    public class EstadoConfiguration : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.ToTable("Estado");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Descripcion).HasMaxLength(80).IsRequired();
            builder.HasOne(x => x.TipoEstado).WithMany(x => x.Estados).HasForeignKey(x => x.IdTipoEstadoFk);
        }
    }
}