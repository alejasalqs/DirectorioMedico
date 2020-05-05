using System.ComponentModel.DataAnnotations;

/*

Creado por asalguero
Fecha: 20/04/2020

Uso: Especifica un contenedor de datos con el detalle de los doctores en el momento en que
se va a iniciar sesion.

*/

namespace DirectorioMedico.API.Dtos
{
    public class UserForLoginDto
    {
        [Required(ErrorMessage = "Se debe ingresar el correo.")]
        public string correo { get; set; }

        [Required(ErrorMessage = "Se debe ingresar la contraseña.")]
        public string password { get; set; }
    }
}