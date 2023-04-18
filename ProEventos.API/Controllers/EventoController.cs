using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.DTO;
using ProEventos.API.Models;
using ProEventos.API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Controllers
{

[Route("api/v1/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        private IEventoRepository _repository;

        public EventoController(IEventoRepository repository)
        {
            _repository = repository ?? throw new  ArgumentNullException(nameof(repository));
        }



        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventoDTO>>> FindAll()
        {
            var eventos = await _repository.FindAll();
            return Ok (eventos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<EventoDTO>>> FindById(long id)
        {
            var eventos = await _repository.FindById(id);
            if (eventos == null) return NotFound();
            return Ok(eventos);
        }

        [HttpPost]
        public async Task<ActionResult<EventoDTO>> Create([FromBody] EventoDTO vo)
        {
            if (vo == null) return BadRequest();
            var eventos = await _repository.Create(vo);
            return Ok(eventos);
        }


        [HttpPut]
        public async Task<ActionResult<EventoDTO>> Update([FromBody] EventoDTO vo) 
        {
            if (vo == null) return BadRequest();
            var eventos = await _repository.Update(vo);
            return Ok(eventos);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(long id)
        {
            var status = await _repository.Delete(id);
            if (!status) return BadRequest();
            return Ok(status);
        }

    }
}
