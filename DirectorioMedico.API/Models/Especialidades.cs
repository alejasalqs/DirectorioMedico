using System.ComponentModel.DataAnnotations;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

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