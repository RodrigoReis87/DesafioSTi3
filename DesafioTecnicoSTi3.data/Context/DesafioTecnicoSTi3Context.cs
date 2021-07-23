﻿using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace DesafioTecnicoSTi3.data.Context
{
    public class DesafioTecnicoSTi3Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3333;user=root;password=powerstock@STi3;database=DesafioDatabase; SSL Mode=none")
                .EnableSensitiveDataLogging()
                .EnableDetailedErrors()
                .LogTo(x => Debug.WriteLine(x));

            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Configuracoes> Configuracoes { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigMapping());

            base.OnModelCreating(modelBuilder);
        }



        public void AplicarMigracoes()
        {
            if (Database.GetPendingMigrations().Any())
            {
                Database.Migrate();
            }
        }
    }
}
