using System.Collections.Generic;
using System.Threading.Tasks;
using DirectorioMedico.API.Helpers;
using DirectorioMedico.API.Models;

/*

Creado por asalguero
Fecha: 01/05/2020

*/

namespace DirectorioMedico.API.Data
{
    public interface IDirectorioRepository
    {
        void Add<T>(T entity) where T : class;

        void Delete<T>(T entity) where T : class;

        Task<bool> SaveAll();

        Task<PagedList<Doctor>> ObtenerDoctores(UserParams userParams);

        Task<Doctor> ObtenerDoctor(int id);
    }
}