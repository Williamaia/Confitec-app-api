using Confitec.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Confitec.Data.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Sobrenome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.DataNascimento)
               .IsRequired()
               .HasColumnType("datetime");

            builder.Property(p => p.Escolaridade)
               .IsRequired()
               .HasColumnType("integer");

            builder.ToTable("Usuarios");
        }
    }
}
