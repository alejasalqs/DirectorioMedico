using System;
using System.ComponentModel.DataAnnotations;

namespace DirectorioMedico.API.Models
{
    public class Experiencia
    {
        public int id { get; set; }

        [Required]
        public string puesto { get; set; }

        [Required]
        public string lugar_trabajo { get; set; }

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