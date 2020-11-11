using LineIN.BFO.Data;
using LineIN.BFO.Interfaces;
using LineIN.BFO.Models;

namespace LineIN.BFO.Repositorys
{
    public class VendaRepository : Repository<Venda>, IVendaRepository
    {

        public VendaRepository(DbContextBFO context) : base(context)
        {

        }
    }
}
