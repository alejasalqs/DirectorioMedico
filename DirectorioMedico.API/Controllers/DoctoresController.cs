using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DirectorioMedico.API.Data;
using DirectorioMedico.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace DirectorioMedico.API.Controllers
{
    //[Authorize]
    [ApiController]
    [Route("[controller]")]
    public class DoctoresController : ControllerBase
    {

        private readonly IDirectorioRepository _repo;
        private readonly IMapper _mapper;

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

               // var doctoresToReturn = _mapper.Map<IEnumerable<DoctorListDto>>(doctores);

                return Ok(doctores);
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

            //var valueToReturn = _mapper.Map<DoctorDetail>(value);

            return Ok(value);
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
         }

         [HttpPut("{id}")]
         public async Task<IActionResult> ModificarDoctor(int id, [FromBody] Doctor doctor)
         {
             if (doctor.Id == id)
             {
                 _context.Entry(doctor).State = EntityState.Modified;
                 _context.SaveChanges();
                 return Ok();
             }
             else
             {
                 return BadRequest();
             }
         }


         [HttpDelete("{id}")]
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