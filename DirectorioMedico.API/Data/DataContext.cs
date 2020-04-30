using DirectorioMedico.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DirectorioMedico.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Representa el nombre de la tabla
        public DbSet<Doctor> Doctores { get; set; }
    }
}