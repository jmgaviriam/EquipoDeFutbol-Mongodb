using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.ViasDeAcceso
{
    public interface IEquipoCasoDeUso
    {
        Task<AgregarEquipo> AgregarEquipo(AgregarEquipo equipo);

        Task<List<Equipo>> ObtenerListaDeEquipos();
        Task<Equipo> ObtenerEquipoPorId(int id);
        Task<EquipoCompleto> ObtenerEquipoCompletoPorId(int id);
    }
}
