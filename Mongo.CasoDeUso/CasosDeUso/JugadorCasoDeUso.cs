using Mongo.CasoDeUso.ViasDeAcceso;
using Mongo.CasoDeUso.ViasDeAcceso.Repositorio;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.CasosDeUso
{
    public class JugadorCasoDeUso : IJugadorCasoDeUso
    {
        private readonly IRepositorioJugador _repositorioJugador;

        public JugadorCasoDeUso(IRepositorioJugador repositorioJugador)
        {
            _repositorioJugador = repositorioJugador;
        }

        public async Task<AgregarJugador> AgregarJugador(AgregarJugador agregarJugador)
        {
            return await _repositorioJugador.AgregarJugadorAsync(agregarJugador);
        }

        public async Task<List<Jugador>> ObtenerListaDeJugadores()
        {
            return await _repositorioJugador.ObtenerJugadoresAsync();
        }

        public async Task<Jugador> ObtenerJugadorPorId(int id)
        {
            return await _repositorioJugador.ObtenerJugadorPorIdAsync(id);
        }
    }
}
