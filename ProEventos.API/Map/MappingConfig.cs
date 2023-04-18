using AutoMapper;
using ProEventos.API.DTO;
using ProEventos.API.Models;

namespace ProEventos.API.Map
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<EventoDTO, Evento>().ReverseMap();

            });
            return mappingConfig;
        }
    }
}
