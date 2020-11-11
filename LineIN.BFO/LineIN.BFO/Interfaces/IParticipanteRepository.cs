using LineIN.BFO.Models;

namespace LineIN.BFO.Interfaces
{
    public interface IParticipanteRepository: IRepository<Participante>
    {
        void CriarListaFake();
    }
}
