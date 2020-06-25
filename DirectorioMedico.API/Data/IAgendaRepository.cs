using System.Threading.Tasks;
using DirectorioMedico.API.Models;

namespace DirectorioMedico.API.Data
{
    public interface IAgendaRepository
    {
        void Add<Agenda>(Agenda agenda);

        void Delete<Agenda>(Agenda agenda);

        Task<bool> SaveAll();

        Task<Agenda> ObtenerEventos();
    }
}