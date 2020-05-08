/*

Creado por asalguero
Fecha: 06/05/2020

*/

namespace DirectorioMedico.API.Helpers
{
    public class PaginationHeader
    {
        public int PaginaActual { get; set; }

        public int ItemsPorPagina { get; set; }

        public int ItemsTotales { get; set; }

        public int PaginasTotales { get; set; }

        public PaginationHeader(int paginaActual, int itemsPorPagina, int itemsTotales, int paginasTotales)
        {
            this.PaginaActual = paginaActual;
            this.ItemsPorPagina = itemsPorPagina;
            this.ItemsTotales = itemsTotales;
            this.PaginasTotales = paginasTotales;
        }
    }
}