using AutoMapper;
using DirectorioMedico.API.Dtos;
using DirectorioMedico.API.Models;

/*

Creado por asalguero
Fecha: 30/04/2020

Uso: Clase de ayuda para AutoMapper, especifica como funcionan las transformaciones.

*/

namespace DirectorioMedico.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Doctor, DoctorListDto>();
            CreateMap<Doctor, DoctorDetail>();
            CreateMap<RedesSociales, RedesSocialesDetailDto>();
            CreateMap<DoctorUpdateDto, Doctor>();
        }
    }
}