/*

Creado por asalguero
Fecha: 05/05/2020

Uso: Especifica un contenedor de datos con la información de las redes sociales en el momento en que
se consulta cualquier información de doctores.


*/

namespace DirectorioMedico.API.Dtos
{
    public class RedesSocialesDetailDto
    {
        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string Url { get; set; }

    }
}