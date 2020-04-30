using System.ComponentModel.DataAnnotations;

namespace DirectorioMedico.API.Models
{
    public class Especialidades
    {
        public int id { get; set; }

        [Required]
        public string descripcion { get; set; }

        [Required]
        public bool estado { get; set; }
  
        public Doctor Doctor { get; set; }

        public int DoctorID { get; set; }
    }
}