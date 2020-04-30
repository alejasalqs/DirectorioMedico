using System.Collections.Generic;
using DirectorioMedico.API.Models;

namespace DirectorioMedico.API.Dtos
{
    public class DoctorListDto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Primer_apellido { get; set; }

        public string Segundo_apellido { get; set; }

        public string Correo { get; set; }

        public string Sitio_web { get; set; }

        public ICollection<RedesSociales> RedesSociales { get; set; }

        public string Celular { get; set; }

        public string Telefono_oficina { get; set; }

        public string Foto { get; set; }
    }
}