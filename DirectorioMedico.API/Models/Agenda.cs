using System;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Models
{
    public class Agenda
    {
        public int Id { get; set; }

        public string Evento { get; set; }

        public bool EsTodoElDia { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        public string Color { get; set; }

    }
}