using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectorioMedico.API.Helpers;
using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

/*

Creado por asalguero
Fecha: 01/05/2020

*/

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

        public async Task<PagedList<Doctor>> ObtenerDoctores(UserParams userParams)
        {
            var doctores = _context.Doctores
            .Include(r => r.RedesSociales)
            .Include(es => es.Especialidades)
            .Include(es => es.Estudios)
            .Include(ex => ex.Experiencia).AsQueryable();

            if (userParams.Genero != 0)
            {
                doctores = doctores.Where(doc => doc.Genero == userParams.Genero);
            }

            //doctores = doctores.Where(doc => doc.Especialidades[0].descripcion = userParams.Especialidad);

            return await PagedList<Doctor>.CreateAsync(doctores, userParams.numeroPagina, userParams.TamanoPagina);
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}