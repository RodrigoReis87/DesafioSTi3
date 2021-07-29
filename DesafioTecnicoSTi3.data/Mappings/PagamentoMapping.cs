using DesafioTecnicoSTi3.data.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioTecnicoSTi3.data.Mappings
{
    public class PagamentoMapping : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.cod_pgto);

            builder.Property(p => p.id).HasColumnType("varchar(100)");
            builder.Property(p => p.parcela).HasColumnType("int(30)");
            builder.Property(p => p.valor).HasColumnType("decimal(15,2)");
            builder.Property(p => p.codigo).HasColumnType("varchar(100)");
            builder.Property(p => p.nome).HasColumnType("varchar(100)");
        }
    }
}
