using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        public IEnumerable<Evento> _evento = new Evento[] {
             new Evento(){
                    EventoId = 1,
                    Tema = "Angular 11 .Net 5",
                    Local = "Sala 01",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                    },
                 new Evento(){
                    EventoId = 2,
                    Tema = "Angular 11 .Net 5",
                    Local = "Sala 02",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
                    },
                  new Evento(){
                    EventoId = 3,
                    Tema = "Angular 11 .Net 5",
                    Local = "Sala 03",
                    Lote = "1° Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(6).ToString("dd/MM/yyyy")
                    }

                };

        public EventoController() 
        {

        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> Get(int id)
        {
            return _evento.Where(e => e.EventoId == id);
        }

        [HttpPost]
        public string Post(){
        
            return "value";
        }

        [HttpPut("{id}")]
        public string Put(int id) {

            return $"Exemplo de Put com id = {id}";
        }


        [HttpDelete("{id}")]
        public string Delete(int id)
        {

            return $"Exemplo de Put com id = {id}";
        }

    }
}
