using System.Threading.Tasks;
using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectorioMedico.API.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;

        public AuthRepository(DataContext context)
        {
            _context = context;

        }
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

        public async Task<Doctor> Register(Doctor doctor)
        {

            // guardamos el usuario
            await _context.Doctores.AddAsync(doctor);
            await _context.SaveChangesAsync();

            return doctor;
        }

        public async Task<bool> UserExits(string username)
        {
            if (await _context.Doctores.AnyAsync(x => x.Correo == username))
            return true;

            return false;
        }
    }
}