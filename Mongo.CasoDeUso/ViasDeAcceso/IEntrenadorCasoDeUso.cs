using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso
{
    public interface IEntrenadorCasoDeUso
    {
        Task<List<Entrenador>> ObtenerEntrenadores();
        Task<Entrenador> ObtenerEntrenadorPorId(int id);
        Task<AgregarEntrenador> AgregarEntrenador(Entrenador entrenador);
        Task<ActualizarEntrenador> ActualizarEntrenador(ActualizarEntrenador entrenador);
    }
}
