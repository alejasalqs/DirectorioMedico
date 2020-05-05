using Microsoft.AspNetCore.Http;

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
    }
}