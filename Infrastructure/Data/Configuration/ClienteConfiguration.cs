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
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.IdCliente).IsUnique();
            builder.Property(x => x.Nombre).HasMaxLength(80).IsRequired();
            builder.Property(x => x.FechaRegistro).IsRequired();
            builder.HasOne(a => a.TipoPersona)
                .WithMany(b => b.Clientes)
                .HasForeignKey(a => a.IdTipoPersonaFK);
            builder.HasOne(a => a.Municipio)
                .WithMany(b => b.Clientes)
                .HasForeignKey(a => a.IdMunicipioFk);
        }
    }
}