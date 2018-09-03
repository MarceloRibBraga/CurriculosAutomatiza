using System;
using System.Collections.Generic;
using System.Text;
using CurriculoAutomatiza.Core.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CurriculoAutomatiza.Infraesctructure.EntityConfig
{
    public class AreasInteresseMap : IEntityTypeConfiguration<AreasInteresse>
    {
        public void Configure(EntityTypeBuilder<AreasInteresse> builder)
        {
            builder.HasOne(p => p.Profissional)
                .WithMany(p => p.AreasInteresses)
                .HasPrincipalKey(p => p.ProfissionalId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasKey(p => p.AreasInteresseId);

            builder.Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(500)")
                .IsRequired();

           
        }
    }
}
