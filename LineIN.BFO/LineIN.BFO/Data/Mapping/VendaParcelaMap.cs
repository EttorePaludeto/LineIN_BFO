using LineIN.BFO.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LineIN.BFO.Data.Mapping
{
    public class VendaParcelaMap : IEntityTypeConfiguration<VendaParcela>
    {
        public void Configure(EntityTypeBuilder<VendaParcela> builder)
        {
            builder.ToTable("VendaParcela");
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).HasColumnName("Id");
            builder.Property(i => i.NumeroParcela).HasColumnName("NumeroParcela");
            builder.Property(i => i.Vencimento).HasColumnName("Vencimento");
            builder.Property(i => i.Valor).HasColumnName("Valor");
        }
    }
}
