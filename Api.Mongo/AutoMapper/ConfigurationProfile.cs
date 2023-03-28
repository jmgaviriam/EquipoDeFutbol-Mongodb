using Adaptador.Mongo.EntidadesMongo;
using AutoMapper;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Api.Mongo.AutoMapper
{
    public class ConfigurationProfile : Profile
    {
        public ConfigurationProfile()
        {
            CreateMap<AgregarEntrenador, Entrenador>().ReverseMap();
            CreateMap<ActualizarEntrenador, Entrenador>().ReverseMap();

            CreateMap<EntrenadorMongo, Entrenador>().ReverseMap();
            CreateMap<EntrenadorMongo, ActualizarEntrenador>().ReverseMap();

            CreateMap<AgregarJugador, Jugador>().ReverseMap();
            CreateMap<AgregarEquipo, Equipo>().ReverseMap();
        }
    }
}
