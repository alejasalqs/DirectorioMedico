using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Representa el nombre de la tabla
        public DbSet<Doctor> Doctores { get; set; }

        public DbSet<Especialidades> Especialidades { get; set; }

        public DbSet<Estudios> Estudios { get; set; }

        public DbSet<Experiencia> Experiencia { get; set; }

        public DbSet<RedesSociales> RedesSociales { get; set; }

        public DbSet<Idioma> Idioma { get; set; }

        public DbSet<Agenda> Agenda { get; set; }
    }
}