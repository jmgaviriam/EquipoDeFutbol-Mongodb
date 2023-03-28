using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Adaptador.Mongo.EntidadesMongo;
using Adaptador.Mongo.Interfaces;
using MongoDB.Driver;

namespace Adaptador.Mongo
{
    public class Context : IContext
    {
        private readonly IMongoDatabase _database;

        public Context(string stringConnection, string DBname)
        {
            MongoClient client = new MongoClient(stringConnection);
            _database = client.GetDatabase(DBname);
        }
        public IMongoCollection<EntrenadorMongo> Entrenadores => _database.GetCollection<EntrenadorMongo>("Entrenadores");
    }
}
