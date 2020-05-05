using System;
using System.ComponentModel.DataAnnotations;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

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

        public string Labores { get; set; }

        [Required]
        public bool estado { get; set; }

        public Doctor Doctor { get; set; }

        public int DoctorID { get; set; }

    }
}