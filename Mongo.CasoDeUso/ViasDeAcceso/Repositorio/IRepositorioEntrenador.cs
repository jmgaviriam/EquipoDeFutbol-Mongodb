using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso.Repositorio
{
    public interface IRepositorioEntrenador
    {
        Task<AgregarEntrenador> AgregarEntrenadorAsync(Entrenador entrenador);
        Task<List<Entrenador>> ObtenerEntrenadoresAsync();
        Task<Entrenador> ObtenerEntrenadorPorIdAsync(int id);
    }
}
