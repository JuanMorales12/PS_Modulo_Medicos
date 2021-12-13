using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System.Collections.Generic;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EspecialidadController : ControllerBase
    {
        private readonly IEspecialidadService _service;
        public EspecialidadController(IEspecialidadService service)
        {
            _service = service;   
        }

        [HttpGet]
        public List<EspecialidadDTO> GetAllEspecialidades()
        {
            return _service.GetAllEspecialidades();
        }

        [HttpGet("{id:int}")]
        public EspecialidadDTO GetEspecialidadById(int id)
        {
            return _service.GetEspecialidadById(id);
        }

    }
}
