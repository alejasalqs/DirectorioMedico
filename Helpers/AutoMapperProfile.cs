using AutoMapper;
using DirectorioMedico.API.Models;
using DirectorioMedico.API.Dtos;

namespace DirectorioMedico.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Doctor, DoctorListDto>();
            CreateMap<Doctor, DoctorDetail>();
        }
    }
}