/*

Creado por asalguero
Fecha: 02/05/2020

Uso: Especifica un contenedor de datos con la información de los doctores en el momento en que
se consulta una lista de doctores.


*/

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

        public bool Estado { get; set; }

        public string Precio { get; set; }
        public string Celular { get; set; }

        public string Foto { get; set; }
    }
}