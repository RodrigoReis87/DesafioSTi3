using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(p => p.codigo_item);

            builder.Property(p => p.id).HasColumnType("varchar(100)");
            builder.Property(p => p.idProduto).HasColumnType("varchar(100)");
            builder.Property(p => p.nome).HasColumnType("varchar(100)");
            builder.Property(p => p.quantidade).HasColumnType("varchar(100)");
            builder.Property(p => p.valorUnitario).HasColumnType("decimal(15,2)");
        }
    }
}
