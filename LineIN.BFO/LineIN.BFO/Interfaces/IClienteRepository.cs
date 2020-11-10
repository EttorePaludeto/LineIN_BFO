using LineIN.BFO.Models;

namespace LineIN.BFO.Interfaces
{
    public interface IClienteRepository: IRepository<Cliente>
    {
        void CriarListaFake();
    }
}
