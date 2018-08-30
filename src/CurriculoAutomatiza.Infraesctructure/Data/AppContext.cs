using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using CurriculoAutomatiza.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CurriculoAutomatiza.Infraesctructure.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options)
        : base(options)
        {
                
        }

        public DbSet<Profissional> Profissionais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Profissional>().ToTable("Profissional");
            #region Configuraçõe de Profissional

            modelBuilder.Entity<Profissional>()
                .HasKey(p => p.ProfissionalId);

            modelBuilder.Entity<Profissional>().Property(p => p.Nome)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Profissional>().Property(p => p.Cpf)
                .HasColumnType("varchar(11)");

            modelBuilder.Entity<Profissional>().Property(p => p.Email)
                .HasColumnType("varchar(200)")
                .IsRequired();

            modelBuilder.Entity<Profissional>().Property(p => p.Telefone)
                .HasColumnType("varchar(20)");

            modelBuilder.Entity<Profissional>().Property(p => p.Senha)
                .HasColumnType("varchar(10)")
                .IsRequired();

            #endregion
        }
    }
}
