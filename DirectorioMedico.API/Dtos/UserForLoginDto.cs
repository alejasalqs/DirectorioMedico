using System.ComponentModel.DataAnnotations;

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