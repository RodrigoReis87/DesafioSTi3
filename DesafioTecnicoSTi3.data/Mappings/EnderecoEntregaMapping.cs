using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class EnderecoEntregaMapping : IEntityTypeConfiguration<EnderecoEntrega>
    {
        public void Configure(EntityTypeBuilder<EnderecoEntrega> builder)
        {
            builder.HasKey(p => p.codigo);

            builder.Property(p => p.id).HasColumnType("varchar(100)");
            builder.Property(p => p.endereco).HasColumnType("varchar(100)");
            builder.Property(p => p.numero).HasColumnType("varchar(100)");
            builder.Property(p => p.cep).HasColumnType("varchar(100)");
            builder.Property(p => p.bairro).HasColumnType("varchar(100)");
            builder.Property(p => p.cidade).HasColumnType("varchar(100)");
            builder.Property(p => p.estado).HasColumnType("varchar(100)");
            builder.Property(p => p.complemento).HasColumnType("varchar(100)");
            builder.Property(p => p.referencia).HasColumnType("varchar(100)");
        }
    }
}