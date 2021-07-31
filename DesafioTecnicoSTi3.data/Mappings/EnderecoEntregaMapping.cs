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
        }
    }
}