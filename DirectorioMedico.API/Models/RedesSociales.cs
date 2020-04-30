using System.ComponentModel.DataAnnotations;

namespace DirectorioMedico.API.Models
{
    public class RedesSociales
    {
        public int Id { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public string Url { get; set; }

        public Doctor Doctor { get; set; }

        public int DoctorID { get; set; }
    }
}