using DesafioTecnicoSTi3.data.Entidades;
using DesafioTecnicoSTi3.data.Mappings;
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
        public virtual DbSet<EnderecoEntrega> EnderecoEntregas { get; set; }
        public virtual DbSet<Item> Itens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ConfigMapping());
            modelBuilder.ApplyConfiguration(new ClientesMapping());
            modelBuilder.ApplyConfiguration(new EnderecoEntregaMapping());
            modelBuilder.ApplyConfiguration(new ItemMapping());
            modelBuilder.ApplyConfiguration(new PagamentoMapping());

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
