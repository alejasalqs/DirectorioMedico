using System.ComponentModel.DataAnnotations;

/*

Creado por asalguero
Fecha: 05/05/2020

*/

namespace DirectorioMedico.API.Models
{
    public class Idioma
    {
        public int Id { get; set; }
        [Required]
        public bool estado { get; set; }

        [Required]
        public string Descripcion { get; set; }

        public Doctor Doctor { get; set; }

        public int DoctorID { get; set; }
    }
}