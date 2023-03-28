using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso.Repositorio
{
    public interface IRepositorioEntrenador
    {
        Task<AgregarEntrenador> AgregarEntrenadorAsync(Entrenador entrenador);
        Task<ActualizarEntrenador> ActualizarEntrenadorAsync(ActualizarEntrenador entrenador);
        Task<List<Entrenador>> ObtenerEntrenadoresAsync();
        Task<Entrenador> ObtenerEntrenadorPorIdAsync(int id);
    }
}
