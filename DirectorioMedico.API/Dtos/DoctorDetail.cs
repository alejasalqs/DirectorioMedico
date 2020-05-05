using System;
using System.Collections.Generic;
using DirectorioMedico.API.Models;

/*

Creado por asalguero
Fecha: 02/05/2020

Uso: Especifica un contenedor de datos con el detalle de los doctores en el momento en que
se consulta un registro individual.

*/

namespace DirectorioMedico.API.Dtos
{
    public class DoctorDetail
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        public string Correo { get; set; }

        public string Sitio_web { get; set; }

        public ICollection<RedesSocialesDetailDto> RedesSociales { get; set; }

        public string Celular { get; set; }

        public string Telefono_oficina { get; set; }

        public ICollection<Especialidades> Especialidades { get; set; }

        public ICollection<Estudios> Estudios { get; set; }

        public ICollection<Experiencia> Experiencia { get; set; }

        public bool Estado { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaUltimaActividad { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Foto { get; set; }
    }
}