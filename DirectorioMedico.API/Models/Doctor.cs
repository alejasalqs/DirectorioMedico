using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DirectorioMedico.API.Models
{
    public class Doctor
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }

        [Required]
        public string Password { get; set; }

        public string Sitio_web { get; set; }

        public ICollection<RedesSociales> RedesSociales { get; set; }

        public string Celular { get; set; }

        public string Telefono_oficina { get; set; }

        [Required]
        public ICollection<Especialidades> Especialidades { get; set; }

        [Required]
        public ICollection<Estudios> Estudios { get; set; }

        [Required]
        public ICollection<Experiencia> Experiencia { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaCreacion { get; set; }

        public DateTime FechaUltimaActividad { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }

        public string Foto { get; set; }
    }
}