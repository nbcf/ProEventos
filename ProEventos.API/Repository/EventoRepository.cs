using AutoMapper;
using ProEventos.API.Models.Context;

using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using ProEventos.API.DTO;
using ProEventos.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ProEventos.API.Repository
{
    public class EventoRepository : IEventoRepository
        {
            private readonly MySQLContext _context;
            private IMapper _mapper;

            public EventoRepository(MySQLContext context, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
            }

            public async Task<IEnumerable<EventoDTO>> FindAll()
            {
              List<Evento> eventos = await _context.Eventos.ToListAsync();
                return _mapper.Map<List<EventoDTO>>(eventos);
            }

            public async Task<EventoDTO> FindById(long id)
            {
                Evento evento =
                    await _context.Eventos.Where(p => p.Id == id)
                    .FirstOrDefaultAsync();
                return _mapper.Map<EventoDTO>(evento);
            }

            public async Task<EventoDTO> Create(EventoDTO vo)
            {
            Evento evento = _mapper.Map<Evento>(vo);
                _context.Eventos.Add(evento);
                await _context.SaveChangesAsync();
                return _mapper.Map<EventoDTO>(evento);
            }
            public async Task<EventoDTO> Update(EventoDTO vo)
            {
            Evento evento = _mapper.Map<Evento>(vo);
                _context.Eventos.Update(evento);
                await _context.SaveChangesAsync();
                return _mapper.Map<EventoDTO>(evento);
            }

            public async Task<bool> Delete(long id)
            {
                try
                {
                Evento evento =
                    await _context.Eventos.Where(p => p.Id == id)
                        .FirstOrDefaultAsync();
                    if (evento == null) return false;
                    _context.Eventos.Remove(evento);
                    await _context.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
    }

