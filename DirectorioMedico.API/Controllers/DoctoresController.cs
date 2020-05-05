using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using DirectorioMedico.API.Data;
using DirectorioMedico.API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

/*

Creado por asalguero
Fecha: 20/04/2020

*/

namespace DirectorioMedico.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DoctoresController : ControllerBase
    {

        private readonly IDirectorioRepository _repo;
        private readonly IMapper _mapper; // Clase de AutoMapper para transformar información

        public DoctoresController(IDirectorioRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        // GET
        [HttpGet]
        public async Task<IActionResult> GetDoctores()
        {
            try
            {
                var doctores = await _repo.ObtenerDoctores();

                var doctoresToReturn = _mapper.Map<IEnumerable<DoctorListDto>>(doctores);

                return Ok(doctoresToReturn);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        // GET BY ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDoctorPorID(int id)
        {
            var value = await _repo.ObtenerDoctor(id);

            var valueToReturn = _mapper.Map<DoctorDetail>(value);

            return Ok(valueToReturn);
        }

        /* [HttpPost]
          public async Task<IActionResult> AgregarDoctor([FromBody] Doctor doctor)
          {
              try
              {
                  _context.Doctores.Add(doctor);
                  _context.SaveChanges();
                  return Ok();
              }
              catch (System.Exception)
              {
                  return BadRequest();
              }
          }*/

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> ModificarPerfilDoctor(int id, DoctorUpdateDto doctorUpdateDto)
        {
            if (id != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
                return Unauthorized();

            var userFromDB = await _repo.ObtenerDoctor(id);

            _mapper.Map(doctorUpdateDto, userFromDB);

            if (await _repo.SaveAll())
                return NoContent();

            throw new Exception("No se pudo actualizar la información del usuario");
        }


        /* [HttpDelete("{id}")]
         public void EliminarDoctor(int id, [FromBody] Doctor doctor)
         {
             if (doctor.Id == id)
             {
                 _context.Entry(doctor).State = EntityState.Modified;
                 _context.SaveChanges();
             }
         }*/
    }
}