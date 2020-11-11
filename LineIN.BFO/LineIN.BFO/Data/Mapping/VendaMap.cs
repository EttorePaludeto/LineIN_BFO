using LineIN.BFO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LineIN.BFO.Data.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Venda");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.ParticipanteId).HasColumnName("ParticipanteId");
            builder.HasOne(i => i.Participante);
            builder.Property(i => i.SeuNumero).HasColumnName("SeuNumero");
            builder.Property(i => i.Data).HasColumnName("Data");
            builder.Property(i => i.Valor).HasColumnName("Valor");
            builder.HasMany(i => i.Parcelas);
                
        }
    }
}
