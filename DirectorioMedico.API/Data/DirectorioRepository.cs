using System.Collections.Generic;
using System.Threading.Tasks;
using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectorioMedico.API.Data
{
    public class DirectorioRepository : IDirectorioRepository
    {
        private readonly DataContext _context;

        public DirectorioRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Doctor> ObtenerDoctor(int id)
        {
            var doctor = await _context.Doctores
            .Include(r => r.RedesSociales)
            .Include(es => es.Especialidades)
            .Include(es => es.Estudios)
            .Include(ex => ex.Experiencia)
            .FirstOrDefaultAsync(doctor => doctor.Id == id);

            return doctor;
        }

        public async Task<IEnumerable<Doctor>> ObtenerDoctores()
        {
            var doctores = await _context.Doctores
            .Include(r => r.RedesSociales)
            .Include(es => es.Especialidades)
            .Include(es => es.Estudios)
            .Include(ex => ex.Experiencia)
            .ToListAsync();

            return doctores;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}