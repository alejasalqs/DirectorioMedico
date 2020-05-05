using System.Threading.Tasks;
using DirectorioMedico.API.Models;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Data
{
    public interface IAuthRepository
    {
        Task<Doctor> Register(Doctor doctor);

        Task<Doctor> Login(string correo, string password);

        Task<bool> UserExits(string username);
    }
}