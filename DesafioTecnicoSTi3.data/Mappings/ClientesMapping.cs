using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class ClientesMapping : IEntityTypeConfiguration<Clientes>
    {
        public void Configure(EntityTypeBuilder<Clientes> builder)
        {
            builder.HasKey(p => p.id);

            builder.Property(p => p.cnpj).HasColumnType("varchar(100)");
            builder.Property(p => p.cpf).HasColumnType("varchar(100)");
            builder.Property(p => p.nome).HasColumnType("varchar(100)");
            builder.Property(p => p.razaoSocial).HasColumnType("varchar(100)");
            builder.Property(p => p.email).HasColumnType("varchar(100)");
            builder.Property(p => p.dataNascimento).HasColumnType("varchar(100)");
        }
    }
}
