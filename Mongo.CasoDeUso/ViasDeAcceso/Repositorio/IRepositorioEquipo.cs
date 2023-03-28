using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso.Repositorio
{
    public interface IRepositorioEquipo
    {
        Task<AgregarEquipo> AgregarEquipoAsync(AgregarEquipo equipo);
        Task<List<Equipo>> ObtenerListaDeEquiposAsync();
        Task<Equipo> ObtenerEquipoPorIdAsync(int id);
        Task<EquipoCompleto> ObtenerEquipoCompletoPorIdAsync(int id);
    }
}
