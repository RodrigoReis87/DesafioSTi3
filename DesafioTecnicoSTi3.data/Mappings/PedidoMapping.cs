using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class PedidoMapping : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.cod_pedido);
            builder.Property(p => p.id).HasColumnType("varchar(100)");
            builder.Property(p => p.numero).HasColumnType("varchar(30)");
            builder.Property(p => p.dataCriacao).HasColumnType("datetime");
            builder.Property(p => p.dataAlteracao).HasColumnType("datetime");
            builder.Property(p => p.status).HasColumnType("varchar(30)");
            builder.Property(p => p.desconto).HasColumnType("double(6,2)");
            builder.Property(p => p.frete).HasColumnType("double(6,2)");
            builder.Property(p => p.subTotal).HasColumnType("double(6,2)");
            builder.Property(p => p.valorTotal).HasColumnType("double(6,2)");
            builder.HasOne(p => p.cliente).WithMany(x=>x.pedido).HasConstraintName("FK_Pedido_Cliente").OnDelete(DeleteBehavior.NoAction);
            builder.HasMany(p => p.itens).WithMany(x => x.pedido);
            builder.HasMany(p => p.pagamento);
        }
    }
}