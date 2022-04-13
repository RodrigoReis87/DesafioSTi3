using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections;
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

            #region Relacionamentos         
            
            builder.HasOne(p => p.cliente)
                .WithMany(x=>x.pedido)
                .HasConstraintName("FK_Pedido_Cliente")
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasMany(p => p.Item)
                .WithMany(x => x.Pedido)
                .UsingEntity<Dictionary<string, object>>(
                "Itens_pedido",
                itens => itens.HasOne<Item>()
                .WithMany()
                .HasForeignKey("PedidoId")
                .HasConstraintName("FK_Itens_pedido_PedidoId")
                .OnDelete(DeleteBehavior.Cascade),
                pedido => pedido.HasOne<Pedido>()
                .WithMany()
                .HasForeignKey("ItemId")
                .HasConstraintName("FK_Itens_pedido_ItemId")
                .OnDelete(DeleteBehavior.Cascade));

            builder.HasMany(p => p.pagamento)
                .WithMany(x => x.pedido)
                .UsingEntity<Dictionary<string, object>>(
                "Pagamento_pedido",
                pagamento => pagamento.HasOne<Pagamento>()
                .WithMany()
                .HasForeignKey("PagtoId")
                .HasConstraintName("FK_Pagamento_pedido_PagtoId")
                .OnDelete(DeleteBehavior.Cascade),
                pedido => pedido.HasOne<Pedido>()
                .WithMany()
                .HasForeignKey("PedidoId")
                .HasConstraintName("FK_Pagamento_pedido_PedidoId")
                .OnDelete(DeleteBehavior.Cascade));
            #endregion

        }
    }
}