using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using CurriculoAutomatiza.Core.Entity;
using CurriculoAutomatiza.Infraesctructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace CurriculoAutomatiza.Infraesctructure.Data
{
    public class AutomatizaCurriculoDbContext : DbContext
    {
        public AutomatizaCurriculoDbContext(DbContextOptions<AutomatizaCurriculoDbContext> options)
        : base(options)
        {
                
        }

        public DbSet<Profissional> Profissionais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Profissional>().ToTable("Profissional");
            modelBuilder.ApplyConfiguration(new ProfissionalMap());

            modelBuilder.Entity<AreasInteresse>().ToTable("AreasInteresse");
            modelBuilder.ApplyConfiguration(new AreasInteresseMap());

        }
    }
}
