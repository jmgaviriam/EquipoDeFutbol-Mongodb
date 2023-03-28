using Mongo.CasoDeUso.ViasDeAcceso;
using Mongo.CasoDeUso.ViasDeAcceso.Repositorio;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.CasosDeUso
{
    public class EntrenadorCasoDeUso : IEntrenadorCasoDeUso
    {
        private readonly IRepositorioEntrenador _repositorioEntrenador;
        public EntrenadorCasoDeUso(IRepositorioEntrenador repositorioEntrenador)
        {
            _repositorioEntrenador = repositorioEntrenador;
        }
        public async Task<AgregarEntrenador> AgregarEntrenador(Entrenador entrenador)
        {
            return await _repositorioEntrenador.AgregarEntrenadorAsync(entrenador);
        }


        public async Task<ActualizarEntrenador> ActualizarEntrenador(ActualizarEntrenador entrenador)
        {
            return await _repositorioEntrenador.ActualizarEntrenadorAsync(entrenador);

        }

        public async Task<List<Entrenador>> ObtenerEntrenadores()
        {
            return await _repositorioEntrenador.ObtenerEntrenadoresAsync();
        }


        public async Task<string> EliminarEntrenador(string id)
        {
            return await _repositorioEntrenador.EliminarEntrenadorAsync(id);
        }

        public async Task<Entrenador> ObtenerEntrenadorPorId(int id)
        {
            return await _repositorioEntrenador.ObtenerEntrenadorPorIdAsync(id);
        }
    }
}
