using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

/*

Creado por asalguero
Fecha: 29/04/2020

Uso: Clase de ayuda para .net, atrapa los errores y los retorna en json.

*/

namespace DirectorioMedico.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse response, string message)
        {
            response.Headers.Add("Application-Error", message);
            response.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            response.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static void AddPagination(this HttpResponse response, int paginaActual, int itemsPorPagina, int itemsTotal, int paginasTotal)
        {
            var paginationHeader = new PaginationHeader(paginaActual, itemsPorPagina, itemsTotal, paginasTotal);
            var camelCase = new JsonSerializerSettings();
            camelCase.ContractResolver = new CamelCasePropertyNamesContractResolver();
            response.Headers.Add("Pagination", JsonConvert.SerializeObject(paginationHeader, camelCase));
            response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}