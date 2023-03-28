using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso
{
    public interface IJugadorCasoDeUso
    {
        Task<List<Jugador>> ObtenerListaDeJugadores();
        Task<Jugador> ObtenerJugadorPorId(int id);
        Task<AgregarJugador> AgregarJugador(AgregarJugador jugador);
    }
}
