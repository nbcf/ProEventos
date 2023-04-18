using ProEventos.API.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProEventos.API.Repository
{
    public interface IEventoRepository
    {
        Task<IEnumerable<EventoDTO>> FindAll();
        Task<EventoDTO> FindById(long id);
        Task<EventoDTO> Create(EventoDTO vo);
        Task<EventoDTO> Update(EventoDTO vo);
        Task<bool> Delete(long id);
    }
}
