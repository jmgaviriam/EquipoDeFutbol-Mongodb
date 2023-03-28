using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso.Repositorio
{
    public interface IRepositorioJugador
    {
        Task<AgregarJugador> AgregarJugadorAsync(AgregarJugador agregarJugador);
        Task<List<Jugador>> ObtenerJugadoresAsync();
        Task<Jugador> ObtenerJugadorPorIdAsync(int id);
    }
}
