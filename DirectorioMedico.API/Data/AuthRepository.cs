using System.Threading.Tasks;
using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;

        }

        /// <summary>
        /// Método para hacer login en el API.
        /// </summary>
        /// <param name="correo"> Recibe un correo en formato string.</param>
        /// <param name="password"> Recibe un password en formato string.</param>
        /// <returns>
        /// Retorna el dato que encuentre en la Base de datos con la información brindada en los parámetros.
        /// </returns>
        public async Task<Doctor> Login(string correo, string password)
        {
            var user = await _context.Doctores
             .FirstOrDefaultAsync(x => x.Correo == correo);

            if (user == null)
                return null;

            if (user.Password != password)
                return null;

            return user;
        }

        /// <summary>
        /// Método para registrarse en el API.
        /// </summary>
        /// <param name="doctor"> Recibe objeto de tipo doctor.</param>
        /// <returns>
        /// Retorna el objeto doctor creado.
        /// </returns>
        public async Task<Doctor> Register(Doctor doctor)
        {

            // guardamos el usuario
            await _context.Doctores.AddAsync(doctor);
            await _context.SaveChangesAsync();

            return doctor;
        }

        /// <summary>
        /// Verifica mediante el correo si un usuario existe.
        /// </summary>
        /// <param name="correo"> Recibe un correo en formato string.</param>
        /// <returns>
        /// Retorna true si el usuario existe en la Base de datos o false en caso cotrario.
        /// </returns>
        public async Task<bool> UserExits(string correo)
        {
            if (await _context.Doctores.AnyAsync(x => x.Correo == correo))
                return true;

            return false;
        }
    }
}