using System.Threading.Tasks;
using DirectorioMedico.API.Models;

namespace DirectorioMedico.API.Data
{
    public class AgendaRepository : IAgendaRepository
    {
        private readonly DataContext _context;

        public void Add<Agenda>(Agenda agenda)
        {

        }

        public void Delete<Agenda>(Agenda agenda)
        {

        }

        public Task<bool> SaveAll()
        {

        }

        public Task<Agenda> ObtenerEventos()
        {
            
        }
    }
}