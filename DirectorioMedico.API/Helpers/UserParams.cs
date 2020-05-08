/*

Creado por asalguero
Fecha: 06/05/2020

*/

namespace DirectorioMedico.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int numeroPagina { get; set; } = 1;

        private int tamanoPagina = 10;
        public int TamanoPagina
        {
            get { return tamanoPagina; }
            set { tamanoPagina = (value > MaxPageSize) ? MaxPageSize : value; }
        }

        public int Genero { get; set; } = 0;

        public string Especialidad { get; set; }

        public string OrdenarPor { get; set; }
    }
}