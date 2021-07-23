using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioTecnicoSTi3.data
{
    public class ConfigMapping : IEntityTypeConfiguration<Configuracoes>
    {
        public void Configure(EntityTypeBuilder<Configuracoes> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UrlAPI).HasColumnType("varchar(100)");
        }
    }
}
