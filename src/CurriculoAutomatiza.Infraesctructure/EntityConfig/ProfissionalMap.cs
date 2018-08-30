using System;
using System.Collections.Generic;
using System.Text;
using CurriculoAutomatiza.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoAutomatiza.Infraesctructure.EntityConfig
{
    public class ProfissionalMap : IEntityTypeConfiguration<Profissional>
    {
        public void Configure(EntityTypeBuilder<Profissional> builder)
        {

            builder.HasKey(p => p.ProfissionalId);

            builder.HasMany(p => p.AreasInteresses)
                .WithOne(p => p.Profissional)
                .HasPrincipalKey(p => p.ProfissionalId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Cpf)
                .HasColumnType("varchar(11)");

            builder.Property(p => p.Email)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Telefone)
                .HasColumnType("varchar(20)");

            builder.Property(p => p.Senha)
                .HasColumnType("varchar(10)")
                .IsRequired();
            }
    }
}
