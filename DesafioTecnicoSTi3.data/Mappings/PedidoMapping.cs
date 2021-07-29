using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.cod_pedido);

            builder.Property(p => p.id).HasColumnType("varchar(100)");
            builder.Property(p => p.numero).HasColumnType("varchar(100)");
            builder.Property(p => p.dataAlteracao).HasColumnType("datetime");
            builder.Property(p => p.dataCriacao).HasColumnType("datetime");
            builder.Property(p => p.status).HasColumnType("varchar(20)");
            builder.Property(p => p.desconto).HasColumnType("double");
            builder.Property(p => p.frete).HasColumnType("double");
            builder.Property(p => p.subTotal).HasColumnType("double");
            builder.Property(p => p.valorTotal).HasColumnType("double");
        }
    }
}
