using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DirectorioMedico.API.Models;

/*

Creado por asalguero
Fecha: 05/05/2020

Uso: Especifica un contenedor de datos con la información de los doctores en el momento en que
se va a modificar la información de un registro.


*/

namespace DirectorioMedico.API.Dtos
{
    public class DoctorUpdateDto
    {
        [Required(ErrorMessage = "Es necesario llenar el campo Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Primer Apellido")]
        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Correo")]
        [EmailAddress]
        public string Correo { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Contraseña")]
        public string Password { get; set; }

        public string Sitio_web { get; set; }

        public ICollection<RedesSociales> RedesSociales { get; set; }

        public string Celular { get; set; }

        public string Telefono_oficina { get; set; }

        [Required(ErrorMessage = "Es necesario añadir especialidades")]
        public ICollection<Especialidades> Especialidades { get; set; }

        [Required(ErrorMessage = "Es necesario añadir estudios")]
        public ICollection<Estudios> Estudios { get; set; }

        [Required(ErrorMessage = "Es necesario añadir experiencia")]
        public ICollection<Experiencia> Experiencia { get; set; }

        [Required]
        public bool Estado { get; set; }


        [Required(ErrorMessage = "Es necesario llenar el campo fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Sobre mi")]
        public string SobreMi { get; set; }

        [Required(ErrorMessage = "Es necesario llenar el campo Precio por Hora")]
        public string Precio { get; set; }

        public ICollection<Idioma> Idioma { get; set; }

        public int Genero { get; set; }
    }
}