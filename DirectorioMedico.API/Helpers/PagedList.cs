using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

/*

Creado por: asalguero
Fecha: 05/05/2020

*/

namespace DirectorioMedico.API.Helpers
{
    public class PagedList<T> : List<T>// recibe objetos genericos
    {
        public int PaginaActual { get; set; }

        public int PaginasTotales { get; set; }

        public int TamanoPagina { get; set; }

        public int CuentaTotal { get; set; }

        public PagedList(List<T> items, int cuenta, int numeroPagina, int tamanoPagina)
        {
            CuentaTotal = cuenta;
            TamanoPagina = tamanoPagina;
            PaginaActual = numeroPagina;
            PaginasTotales = (int)Math.Ceiling(cuenta / (double)tamanoPagina);
            this.AddRange(items);
        }


        public static async Task<PagedList<T>> CreateAsync(IQueryable<T> source, int numeroPagina, int tamanoPagina)
        {
            var count = await source.CountAsync();
            var items = await source.Skip((numeroPagina - 1) * tamanoPagina).Take(tamanoPagina).ToListAsync();
            return new PagedList<T>(items, count, numeroPagina, tamanoPagina);
        }
    }
}