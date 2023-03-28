using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Mongo.CasoDeUso.ViasDeAcceso;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Api.Mongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ControladorEntrenador : ControllerBase
    {
        private readonly IEntrenadorCasoDeUso _entrenadorCasoDeUso;
        private readonly IMapper _mapper;

        public ControladorEntrenador(IEntrenadorCasoDeUso entrenadorCasoDeUso, IMapper mapper)
        {
            _entrenadorCasoDeUso = entrenadorCasoDeUso;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<Entrenador>> ObtenerEntrenadores()
        {
            return await _entrenadorCasoDeUso.ObtenerEntrenadores();
        }

        [HttpPost]
        public async Task<AgregarEntrenador> CrearEntrenador([FromBody] AgregarEntrenador comando)
        {
            return await _entrenadorCasoDeUso.AgregarEntrenador(_mapper.Map<Entrenador>(comando));
        }
    }
}
