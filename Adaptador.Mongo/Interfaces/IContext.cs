using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaptador.Mongo.EntidadesMongo;
using MongoDB.Driver;

namespace Adaptador.Mongo.Interfaces
{
    public interface IContext
    {
        public IMongoCollection<EntrenadorMongo> Entrenadores { get; }
    }
}
