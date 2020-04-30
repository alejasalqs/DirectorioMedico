using System;
using System.ComponentModel.DataAnnotations;

namespace DirectorioMedico.API.Models
{
    public class Estudios
    {
        public int id { get; set; }

        [Required]
        public string grado { get; set; }

        [Required]
        public string centro_estudios { get; set; }

        [Required]
        public DateTime fecha_inicial { get; set; }

        [Required]
        public DateTime fecha_final { get; set; }

        [Required]
        public bool estado { get; set; } 

        public Doctor Doctor { get; set; }

        public int DoctorID { get; set; }
    }
}