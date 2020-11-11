using LineIN.BFO.Data.Mapping;
using LineIN.BFO.Models;
using Microsoft.EntityFrameworkCore;

namespace LineIN.BFO.Data
{
    public class DbContextBFO: DbContext
    {
        public DbContextBFO()
        {

        }

        public DbContextBFO(DbContextOptions<DbContextBFO> options) : base(options)
        {

        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=192.168.0.251\\SQLNOVATIETE;initial catalog=LineIN_BFO;user id=NovaTieteAdm;password=Trupyc@+Numc#;MultipleActiveResultSets=True");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ParticipanteMap());
            modelBuilder.ApplyConfiguration(new VendaMap());
            modelBuilder.ApplyConfiguration(new VendaParcelaMap());
        }

        public virtual DbSet<Participante> Participantes { get; set; }
        public virtual DbSet<Venda> Vendas { get; set; }
        public virtual DbSet<VendaParcela> VendasParcelas { get; set; }
    }
}
