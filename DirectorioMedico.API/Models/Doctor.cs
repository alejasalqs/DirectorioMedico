using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Models
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Primer Apellido")]
        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Correo")]
        [EmailAddress(ErrorMessage = "El campo Correo no es una dirección de correo electrónico válida")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Contraseña")]
        public string Password { get; set; }

        public string Sitio_web { get; set; }

        public ICollection<RedesSociales> RedesSociales { get; set; }

        public string Celular { get; set; }

        public string Telefono_oficina { get; set; }

        public ICollection<Especialidades> Especialidades { get; set; }

        public ICollection<Estudios> Estudios { get; set; }

        public ICollection<Experiencia> Experiencia { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaUltimaActividad { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public string Foto { get; set; }

        public string SobreMi { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Precio por Hora")]
        public string Precio { get; set; }

        public ICollection<Idioma> Idiomas { get; set; }

        public int Genero { get; set; }

        public string Locacion { get; set; }     

        public int IdAgenda { get; set; }

        public Agenda Agenda { get; set; }
    }
}