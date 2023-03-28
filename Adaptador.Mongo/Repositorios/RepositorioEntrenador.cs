using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaptador.Mongo.EntidadesMongo;
using Adaptador.Mongo.Interfaces;
using AutoMapper;
using Mongo.CasoDeUso.ViasDeAcceso.Repositorio;
using Mongo.Dominio.Comandos;
using Mongo.Dominio.Entidades;
using MongoDB.Driver;

namespace Adaptador.Mongo.Repositorios
{
    public class RepositorioEntrenador : IRepositorioEntrenador
    {

        private readonly IMongoCollection<EntrenadorMongo> coleccion;
        private readonly IMapper _mapper;

        public RepositorioEntrenador(IContext context, IMapper mapper)
        {
            coleccion = context.Entrenadores;
            _mapper = mapper;
        }

        public async Task<AgregarEntrenador> AgregarEntrenadorAsync(Entrenador entrenador)
        {
            var entrenadorGuardar = _mapper.Map<EntrenadorMongo>(entrenador);
            await coleccion.InsertOneAsync(entrenadorGuardar);
            return _mapper.Map<AgregarEntrenador>(entrenador);
        }

        public async Task<ActualizarEntrenador> ActualizarEntrenadorAsync(ActualizarEntrenador entrenador)
        {
            var entrenadorActualizar = _mapper.Map<EntrenadorMongo>(entrenador);
            var entrenadorActualizado = await coleccion.FindOneAndReplaceAsync(x => x.Id_Mongo == entrenador.Id_Mongo, entrenadorActualizar);
            if (entrenadorActualizado == null)
            {
                throw new Exception($"No se encontró ningún entrenador con el ID '{entrenador.Id_Mongo}'");
            }
            return _mapper.Map<ActualizarEntrenador>(entrenadorActualizado);
        }

        public async Task<List<Entrenador>> ObtenerEntrenadoresAsync()
        {
            var entrenadores = await coleccion.FindAsync(Builders<EntrenadorMongo>.Filter.Empty);
            var listaEntrenadores = entrenadores.ToEnumerable().Select(x => _mapper.Map<Entrenador>(x)).ToList();
            return listaEntrenadores;
        }

        public async Task<string> EliminarEntrenadorAsync(string id)
        {
            var entrenadores = await coleccion.DeleteOneAsync(x => x.Id_Mongo == id);
            if (entrenadores.DeletedCount.Equals(1))
            {
                return $"Entrenador con Id_Mongo: {id} eliminado correctamente";
            }
            else
            {
                return $"Entrenador con Id_Mongo: {id} no encontrado";
            }
        }


        public Task<Entrenador> ObtenerEntrenadorPorIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
