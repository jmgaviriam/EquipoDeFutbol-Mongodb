using Mongo.CasoDeUso.ViasDeAcceso;
using Mongo.CasoDeUso.ViasDeAcceso.Repositorio;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;

namespace Mongo.CasoDeUso.CasosDeUso
{
    public class EquipoCasoDeUso : IEquipoCasoDeUso
    {
        private readonly IRepositorioEquipo _repositorioEquipo;
        public EquipoCasoDeUso(IRepositorioEquipo repositorioEquipo)
        {
            _repositorioEquipo = repositorioEquipo;
        }

        public async Task<AgregarEquipo> AgregarEquipo(AgregarEquipo equipo)
        {
            return await _repositorioEquipo.AgregarEquipoAsync(equipo);
        }

        public async Task<List<Equipo>> ObtenerListaDeEquipos()
        {
            return await _repositorioEquipo.ObtenerListaDeEquiposAsync();
        }

        public async Task<EquipoCompleto> ObtenerEquipoCompletoPorId(int id)
        {
            return await _repositorioEquipo.ObtenerEquipoCompletoPorIdAsync(id);
        }

        public async Task<Equipo> ObtenerEquipoPorId(int id)
        {
            return await _repositorioEquipo.ObtenerEquipoPorIdAsync(id);
        }

    }
}
