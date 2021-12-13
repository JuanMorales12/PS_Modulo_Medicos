using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClinicaController : ControllerBase
    {
        private readonly IClinicaService _service;
        public ClinicaController(IClinicaService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Clinica>>> GetAllClinica()
        {
            var listaDeClinicas = await _service.GetAllClinica();
            
             if (listaDeClinicas != null)
            {
                return Ok(listaDeClinicas);
            }
            else
            {
                return NotFound();
            }


        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Clinica>> GetClinicaById(int id)
        {

            var clinica = await _service.GetClinicaById(id);

            if (clinica != null)
            {
                return Ok(clinica);
            }
            else
            {
                return NotFound();
            }

        }

    }
}
