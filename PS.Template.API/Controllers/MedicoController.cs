using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PS.Template.Application.Services;
using PS.Template.Domain.DTOs;
using PS.Template.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PS.Template.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly IMedicoService _MedicoService;
        public MedicoController(IMedicoService doc)
        {
            _MedicoService = doc;
        }

        [HttpGet]
        public async Task<ActionResult<List<Medico>>> GetAllMedico()
        {
            var medicos = await _MedicoService.GetAllMedico();
            return Ok(medicos);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Medico>> GetMedicoById(int id)
        {
            var medico = await _MedicoService.GetMedicoById(id);
            if(medico.Count > 0)
            {
                return Ok(medico);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("clinicaId/{id:int}")]
        public async Task<ActionResult<Medico>> getAllMedicoByClinicaId(int id)
        {
            var medico = await _MedicoService.GetAllMedicoByClinicaId(id);
            if (medico.Count > 0)
            {
                return Ok(medico);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("especialidadId/{id:int}")]
        public async Task<ActionResult<Medico>> getAllMedicoByEspecialidadId(int id)
        {
            var medico = await _MedicoService.GetAllMedicoByEspecialidadId(id);
            if (medico.Count > 0 )
            {
                return Ok(medico);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("medicoespecial/{id:int}/{id2:int}")]
        public async Task<ActionResult<Medico>> getAllMedicoByEspecialidadId(int id, int id2)
        {
            var medico = await _MedicoService.GetAllMedicoByClinicaYespecialidad(id,id2);
            if (medico.Count > 0)
            {
                return Ok(medico);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("partidoId/{id:int}")]
        public async Task<ActionResult<Medico>> getAllMedicoByPartidoId(int id)
        {
            var medico = await _MedicoService.GetAllMedicoByPartidoId(id);
            if (medico.Count > 0)
            {
                return Ok(medico);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpPost]
        public async Task<ActionResult<Medico>> CrearMedico(MedicoDTO doctor)
        {
            var doc = await _MedicoService.CreateMedico(doctor);
            return Ok(doc);
        }

        [HttpPut]
        public async Task<ActionResult<MedicoDTO>> UpdateMedico(MedicoDTO medicoDTO)
        {
            var medicoModificado = await _MedicoService.UpdateMedico(medicoDTO);
            if (medicoModificado != null)
            {
                return Ok(medicoModificado);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
